
CREATE TABLE ROL (ID int primary key identity,
DESCRIPCION nvarchar(50),
FECHA_CREACION datetime default getdate());
GO
/*Tabla Permiso*/
CREATE TABLE PERMISO (ID int primary key identity,
ID_ROL int references ROL(ID),
NOMBRE_MENU varchar(100),
FECHA_CREACION datetime default getdate());
GO
/*Tabla Usuario*/
CREATE TABLE USUARIO (ID int primary key identity,
CODIGO nvarchar(30),
NOMBRE_COMPLETO varchar(50),
CORREO_ELECTRONICO nvarchar(50),
CLAVE varchar(30),
ID_ROL int references ROL(ID),
ESTADO bit,
FECHA_CREACION datetime default getdate()
);
GO
CREATE TABLE CANDIDATA(ID_CANDIDATA int primary key identity,
CEDULA varchar(10),
NOMBRES nvarchar(30),
FOTO_PRINCIPAL varbinary(max)NUll,
CARRERA nvarchar(15),
SEMESTRE int,
PASATIEMPOS nvarchar(250),
HABILIDADES nvarchar(50),
INTERESES nvarchar(50),
ASPIRACIONES nvarchar(50),
FECHA_REGISTRO datetime default getdate()
);
GO 
CREATE TABLE VOTO(ID_VOTO int primary key identity, 
ID_CANDIDATA int references CANDIDATA(ID_CANDIDATA),
ID_ESTUDIANTE int references USUARIO(ID),
TIPO_VOTACION varchar(15),
FECHA_REGISTRO datetime default getdate()
);
GO

CREATE TABLE ALBUM (ID_ALBUM int primary key identity,
    NOMBRE nvarchar(50),
    DESCRIPCION nvarchar(250),
    ID_USUARIO int references USUARIO(ID),
	ID_CANDIDATA int references CANDIDATA(ID_CANDIDATA ),
    FECHA_CREACION datetime default getdate()
);
GO

CREATE TABLE FOTO (ID_FOTO int primary key identity,
    ID_ALBUM int references ALBUM(ID_ALBUM),
    NOMBRE nvarchar(50),
    DESCRIPCION nvarchar(250),
    IMAGEN varbinary(max),
    FECHA_CREACION datetime default getdate()
);
GO

CREATE TABLE COMENTARIO (ID_COMENTARIO int primary key identity,
    ID_FOTO int references FOTO(ID_FOTO),
    ID_USUARIO int references USUARIO(ID),
    CONTENIDO nvarchar(500),
    FECHA_CREACION datetime default getdate()
);
GO
/* PROCEDIMIENTOS ALMACENADOS */
CREATE PROC PA_REGISTRAR_CANDIDATA(
@Cedula varchar(10),
@Nombres nvarchar(30),
@Foto_Principal varbinary(max) = NULL,
@Carrera nvarchar(15),
@Semestre int,
@Pasatiempos nvarchar(250),
@Habilidades nvarchar(250),
@Interes nvarchar(250),
@Aspiraciones nvarchar(250),
@Resultado int output,
@Mensaje varchar (500) output
)
as
begin
	set @Resultado = 0
	if not exists (SELECT * FROM CANDIDATA WHERE CEDULA = @Cedula)
	begin
		insert into CANDIDATA (CEDULA, NOMBRES, FOTO_PRINCIPAL, CARRERA, SEMESTRE, PASATIEMPOS, HABILIDADES, INTERESES, ASPIRACIONES) VALUES 
		(@Cedula, @Nombres, @Foto_Principal, @Carrera, @Semestre, @Pasatiempos, @Habilidades, @Interes, @Aspiraciones)
		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'Ya existe un candidata con esa cedula.'
end

GO

CREATE PROC PA_EDITAR_CANDIDATA(
@Id_Candidata int,
@Cedula varchar(10),
@Nombres nvarchar(30),
@Foto_Principal varbinary(max) = NULL,
@Carrera nvarchar(15),
@Semestre int,
@Pasatiempos nvarchar(250),
@Habilidades nvarchar(250),
@Interes nvarchar(250),
@Aspiraciones nvarchar(250),
@Resultado bit output,
@Mensaje varchar (500) output
)
as
begin 
	set @Resultado = 1
	if not exists (SELECT * FROM CANDIDATA WHERE CEDULA = @Cedula and ID_CANDIDATA != @Id_Candidata)
		update CANDIDATA set
		CEDULA = @Cedula,
		NOMBRES = @Nombres,
		FOTO_PRINCIPAL = @Foto_Principal,
		CARRERA = @Cedula,
		SEMESTRE = @Semestre,
		PASATIEMPOS = @Pasatiempos,
		HABILIDADES = @Habilidades,
		INTERESES = @Interes
		Where ID_CANDIDATA = @Id_Candidata
	else
	begin
		set @Resultado = 0
		set @Mensaje = 'Ya existe una candidata con esa cedula.'
	end 
end
GO
CREATE PROC PA_ELIMINAR_CANDIDATA (
@Id_Candidata int,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
    set @Resultado = 1;
    DELETE FROM CANDIDATA WHERE ID_CANDIDATA = @Id_Candidata;
    if @@ROWCOUNT > 0
    begin
        set @Mensaje = 'La candidata ha sido eliminada exitosamente.';
    end
    else
    begin
        set @Resultado = 0;
        set @Mensaje = 'No se encontró ninguna candidata con el ID especificado.';
    end
end
GO

GO
CREATE PROCEDURE PA_REGISTRAR_VOTO(
    @ID_CANDIDATA int,
    @ID_ESTUDIANTE int,
    @TIPO_VOTACION varchar(15),
	@Resultado bit output,
    @Mensaje varchar(500) output
)AS
BEGIN
	set @Resultado = 0
    IF NOT EXISTS (SELECT *  FROM VOTO 
                   WHERE ID_CANDIDATA = @ID_CANDIDATA 
                     AND ID_ESTUDIANTE = @ID_ESTUDIANTE 
                     AND TIPO_VOTACION = @TIPO_VOTACION)
    BEGIN
        INSERT INTO VOTO (ID_CANDIDATA, ID_ESTUDIANTE, TIPO_VOTACION)
        VALUES (@ID_CANDIDATA, @ID_ESTUDIANTE, @TIPO_VOTACION );
		set @Resultado = SCOPE_IDENTITY()
        set @Mensaje = 'Voto registrado exitosamente.';
    END
    ELSE
       set @Mensaje = 'El estudiante ya ha votado para este tipo de votación.';
END;
GO
CREATE PROCEDURE CrearAlbumYFotos(
    @NombreAlbum nvarchar(50),
    @DescripcionAlbum nvarchar(250),
    @IdCandidata int,
    @NombreFoto nvarchar(50),
    @DescripcionFoto nvarchar(250),
    @Imagen varbinary(max))
AS
BEGIN
    DECLARE @IdAlbum int;

    -- Verificar si ya existe un álbum con el mismo nombre para la candidata
    SELECT @IdAlbum = ID_ALBUM
    FROM ALBUM
    WHERE NOMBRE = @NombreAlbum AND ID_CANDIDATA = @IdCandidata;

    -- Si no existe el álbum, crearlo
    IF @IdAlbum IS NULL
    BEGIN
        INSERT INTO ALBUM (NOMBRE, DESCRIPCION, ID_CANDIDATA)
        VALUES (@NombreAlbum, @DescripcionAlbum, @IdCandidata);
        
        -- Obtener el ID del álbum recién creado
        SET @IdAlbum = SCOPE_IDENTITY();
    END

    -- Insertar la foto en la tabla FOTO con el ID del álbum obtenido o recién creado
    INSERT INTO FOTO (ID_ALBUM, NOMBRE, DESCRIPCION, IMAGEN)
    VALUES (@IdAlbum, @NombreFoto, @DescripcionFoto, @Imagen);
END;
GO

CREATE PROCEDURE ComentarFoto(
    @IdFoto int,
    @IdUsuario int,
    @Contenido nvarchar(500))
AS
BEGIN
    -- Insertar el comentario en la tabla COMENTARIO
    INSERT INTO COMENTARIO (ID_FOTO, ID_USUARIO, CONTENIDO)
    VALUES (@IdFoto, @IdUsuario, @Contenido);
END;
GO


/*INSERCIONES*/
INSERT INTO ROL (DESCRIPCION) VALUES('Administrador');
GO
INSERT INTO ROL (DESCRIPCION) VALUES ('Estudiante');
GO
INSERT INTO PERMISO (ID_ROL,NOMBRE_MENU) VALUES
(1,'menuCandidata'),
(1,'menuAlbum'),
(1,'menuResultado'),
(1,'menuAcercaDe');
GO
INSERT INTO PERMISO (ID_ROL,NOMBRE_MENU) VALUES
(2,'menuVisitaCandidata'),
(2,'menuVotacion'),
(2,'menuAcercaDe');
GO


INSERT INTO USUARIO (CODIGO, NOMBRE_COMPLETO, CORREO_ELECTRONICO, CLAVE, ID_ROL,ESTADO) VALUES ('00001','Noely Gisel Ruiz','noe@gmail.com','admin',1,1);
GO
INSERT INTO USUARIO (CODIGO, NOMBRE_COMPLETO, CORREO_ELECTRONICO, CLAVE, ID_ROL,ESTADO) VALUES ('00002','Diana Andrea Ballesteros','dianita@gmail.com','1111',2,1);
GO
INSERT INTO USUARIO (CODIGO, NOMBRE_COMPLETO, CORREO_ELECTRONICO, CLAVE, ID_ROL,ESTADO) VALUES ('00003','Adrián Gonzalez Astudillo','Adrian@gmail.com','3333',2,1);
GO
INSERT INTO USUARIO (CODIGO, NOMBRE_COMPLETO, CORREO_ELECTRONICO, CLAVE, ID_ROL,ESTADO) VALUES ('00004','Hector Gonzalez Vera','hector@gmail.com','5555',2,1);
GO
INSERT INTO USUARIO (CODIGO, NOMBRE_COMPLETO, CORREO_ELECTRONICO, CLAVE, ID_ROL,ESTADO) VALUES ('00005','Walter Bernardi Correa','WalterB@gmail.com','4444',2,1);
GO



