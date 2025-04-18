using System;
using Clases;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Datos
    {
        public SqlConnection ConexioBDD()
        {
            SqlConnection cn = new SqlConnection("server= DESKTOP-TFVCTTI\\SQLEXPRESS ; database=  SISTEMA_DE_VOTACION; integrated security=true;");//Conexion BD
            cn.Open();
            return cn;
        }

        public List<Usuario> ingresarUsuario()
        {
            List<Usuario> listaUsuario = new List<Usuario>();
            try
            {
                string registrar = "SELECT ID, CODIGO, NOMBRE_COMPLETO, CORREO_ELECTRONICO, CLAVE, ID_ROL, ESTADO FROM USUARIO";
                SqlCommand cmd = new SqlCommand(registrar, ConexioBDD());
                cmd.CommandType = CommandType.Text;
                SqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    listaUsuario.Add(new Usuario()
                    {
                        ID = Convert.ToInt32(leer["ID"]),
                        Codigo = leer["CODIGO"].ToString(),
                        Nombres_Completo = leer["NOMBRE_COMPLETO"].ToString(),
                        Correo_Electronico = leer["CORREO_ELECTRONICO"].ToString(),
                        Clave = leer["CLAVE"].ToString(),
                        Estado = Convert.ToBoolean(leer["ESTADO"])
                    });
                }
            }
            catch (Exception us)
            {
                listaUsuario = new List<Usuario>();
            }
            return listaUsuario;
        }
        public Usuario recuperarClave(string correoElectronico)
        {
            Usuario usuario = null;
            try
            {
                string consulta = "SELECT CLAVE FROM USUARIO WHERE CORREO_ELECTRONICO = @correoElectronico";
                SqlCommand cmd = new SqlCommand(consulta, ConexioBDD());
                cmd.Parameters.AddWithValue("@correoElectronico", correoElectronico);
                cmd.CommandType = CommandType.Text;
                SqlDataReader leer = cmd.ExecuteReader();

                if (leer.Read())
                {
                    usuario = new Usuario()
                    {
                        Clave = leer["CLAVE"].ToString()
                    };
                }
            }
            catch (Exception us)
            {

            }
            return usuario;
        }
        //Permiso
        public List<Permiso> permisosMenu(int idusuario)
        {
            List<Permiso> listaPermiso = new List<Permiso>();
            try
            {
                StringBuilder permisos = new StringBuilder();
                permisos.AppendLine("SELECT p.ID_ROL, p.NOMBRE_MENU FROM PERMISO p");
                permisos.AppendLine("inner join ROL r on r.ID = p.ID_ROL");
                permisos.AppendLine("inner join USUARIO u on u.ID_ROL = r.ID");
                permisos.AppendLine("WHERE U.ID = @id_usuario");
                SqlCommand cmd = new SqlCommand(permisos.ToString(), ConexioBDD());
                cmd.Parameters.AddWithValue("@id_usuario", idusuario);
                cmd.CommandType = CommandType.Text;
                SqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    listaPermiso.Add(new Permiso()
                    {
                        oRol = new Rol() { ID = Convert.ToInt32(leer["ID_ROL"]) },
                        NombreMenu = leer["NOMBRE_MENU"].ToString(),
                    });
                }
            }
            catch (Exception pe)
            {
                listaPermiso = new List<Permiso>();
            }
            return listaPermiso;
        }
        //Rol
        public List<Rol> listarRol()
        {
            List<Rol> listaRoles = new List<Rol>();
            try
            {
                StringBuilder rol = new StringBuilder();
                rol.AppendLine("SELECT ID, DESCRIPCION FROM ROL");
                SqlCommand cmd = new SqlCommand(rol.ToString(), ConexioBDD());
                cmd.CommandType = CommandType.Text;
                SqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    listaRoles.Add(new Rol()
                    {
                        ID = Convert.ToInt32(leer["ID"]),
                        Descripcion = leer["DESCRIPCION"].ToString(),
                    }); ;
                }
            }
            catch (Exception ro)
            {
                listaRoles = new List<Rol>();
            }
            return listaRoles;
        }
        public List<Candidata> mostrarCandidata()
        {
            List<Candidata> listaCandidata = new List<Candidata>();
            try
            {
                string mostrar = "SELECT ID_CANDIDATA, CEDULA, NOMBRES, FOTO_PRINCIPAL, CARRERA, SEMESTRE, PASATIEMPOS, HABILIDADES, INTERESES, ASPIRACIONES FROM CANDIDATA";
                SqlCommand cmd = new SqlCommand(mostrar, ConexioBDD());
                cmd.CommandType = CommandType.Text;
                SqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    listaCandidata.Add(new Candidata()
                    {
                        Id_Candidata = Convert.ToInt32(leer["ID_CANDIDATA"]),
                        Cedula = leer["CEDULA"].ToString(),
                        Nombres = leer["NOMBRES"].ToString(),
                        Foto_Principal = (byte[])leer["FOTO_PRINCIPAL"],
                        Carrera = leer["CARRERA"].ToString(),
                        Semestre = Convert.ToInt32(leer["SEMESTRE"].ToString()),
                        Pasatiempos = leer["PASATIEMPOS"].ToString(),
                        Habilidades = leer["HABILIDADES"].ToString(),
                        Intereses = leer["INTERESES"].ToString(),
                        Aspiraciones = leer["ASPIRACIONES"].ToString()
                    });
                }
            }
            catch (Exception tra)
            {
                listaCandidata = new List<Candidata>();
            }
            return listaCandidata;
        }
        public int registrarCandidata(Candidata obj, byte[] foto, out string mensaje)
        {
            int idCandidataGenerada = 0;
            mensaje = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("PA_REGISTRAR_CANDIDATA", ConexioBDD());
                cmd.Parameters.AddWithValue("Cedula", obj.Cedula);
                cmd.Parameters.AddWithValue("Nombres", obj.Nombres);
                cmd.Parameters.AddWithValue("Foto_Principal", foto);
                cmd.Parameters.AddWithValue("Carrera", obj.Carrera);
                cmd.Parameters.AddWithValue("Semestre", obj.Semestre);
                cmd.Parameters.AddWithValue("Pasatiempos", obj.Pasatiempos);
                cmd.Parameters.AddWithValue("Habilidades", obj.Habilidades);
                cmd.Parameters.AddWithValue("Interes", obj.Intereses);
                cmd.Parameters.AddWithValue("Aspiraciones", obj.Aspiraciones);
                cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                idCandidataGenerada = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                mensaje = cmd.Parameters["Mensaje"].Value.ToString();
            }
            catch (Exception tr)
            {
                idCandidataGenerada = 0;
                mensaje = tr.Message;

            }
            return idCandidataGenerada;
        }
        public bool editarCandidata(Candidata obj, byte[] foto, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("PA_EDITAR_CANDIDATA", ConexioBDD());
                cmd.Parameters.AddWithValue("Id_Candidata", obj.Id_Candidata);
                cmd.Parameters.AddWithValue("Cedula", obj.Cedula);
                cmd.Parameters.AddWithValue("Nombres_Completo", obj.Nombres);
                cmd.Parameters.AddWithValue("Foto_Principal", foto);
                cmd.Parameters.AddWithValue("Carrera", obj.Carrera);
                cmd.Parameters.AddWithValue("Semestre", obj.Semestre);
                cmd.Parameters.AddWithValue("Pasatiempos", obj.Pasatiempos);
                cmd.Parameters.AddWithValue("Habilidades", obj.Habilidades);
                cmd.Parameters.AddWithValue("Interes", obj.Intereses);
                cmd.Parameters.AddWithValue("Aspiraciones", obj.Aspiraciones);
                cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                mensaje = cmd.Parameters["Mensaje"].Value.ToString();
            }
            catch (Exception tr)
            {
                respuesta = false;
                mensaje = tr.Message;
            }
            return respuesta;
        }
        public bool eliminarCandidata(Candidata obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("PA_ELIMINAR_Candidata", ConexioBDD());
                cmd.Parameters.AddWithValue("Id_Candidata", obj.Id_Candidata);
                cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                mensaje = cmd.Parameters["Mensaje"].Value.ToString();
            }
            catch (Exception tr)
            {
                respuesta = false;
                mensaje = tr.Message;
            }
            return respuesta;
        }

        public int RegistrarVoto(Votacion obj, out string mensaje)
        {
            int idVotacion = 0;
            mensaje = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("PA_REGISTRAR_VOTO", ConexioBDD());
                cmd.Parameters.AddWithValue("Id_Candidata", obj.oCandidata.Id_Candidata);
                cmd.Parameters.AddWithValue("Id_Estudiante", obj.oUsuario.ID);
                cmd.Parameters.AddWithValue("Tipo_Votacion", obj.Tipo_votacion);
                cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                idVotacion = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                mensaje = cmd.Parameters["Mensaje"].Value.ToString();
            }
            catch (Exception tr)
            {
                idVotacion = 0;
                mensaje = tr.Message;
            }
            return idVotacion;
        }
        public DataTable GetVotacionFotogenia()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder ganadora = new StringBuilder();
                ganadora.AppendLine("SELECT TOP 1 C.NOMBRES, COUNT(V.ID_VOTO) AS NUM_VOTOS FROM CANDIDATA C");
                ganadora.AppendLine("JOIN VOTO V ON C.ID_CANDIDATA = V.ID_CANDIDATA");
                ganadora.AppendLine("WHERE V.TIPO_VOTACION = 'Miss Fotogenia'");
                ganadora.AppendLine("GROUP BY C.NOMBRES");
                ganadora.AppendLine("ORDER BY NUM_VOTOS DESC");
                SqlCommand cmd = new SqlCommand(ganadora.ToString(), ConexioBDD());
                SqlDataAdapter missGanadora = new SqlDataAdapter(cmd);
                missGanadora.Fill(dt);

            }
            catch (Exception tr)
            {
                Console.WriteLine(tr.Message);
            }
            return dt;
        }

        public DataTable GetVotacionReina()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder ganadora = new StringBuilder();
                ganadora.AppendLine("SELECT TOP 1 C.NOMBRES, COUNT(V.ID_VOTO) AS NUM_VOTOS FROM CANDIDATA C");
                ganadora.AppendLine("JOIN VOTO V ON C.ID_CANDIDATA = V.ID_CANDIDATA");
                ganadora.AppendLine("WHERE V.TIPO_VOTACION = 'Reina FCMF'");
                ganadora.AppendLine("GROUP BY C.NOMBRES");
                ganadora.AppendLine("ORDER BY NUM_VOTOS DESC;");
                SqlCommand cmd = new SqlCommand(ganadora.ToString(), ConexioBDD());
                SqlDataAdapter missGanadora = new SqlDataAdapter(cmd);
                missGanadora.Fill(dt);
            }
            catch (Exception tr)
            {
                Console.WriteLine(tr.Message);
            }
            return dt;
        }
        public void CrearAlbumYFotos(string nombreAlbum, string descripcionAlbum, int idCandidata, string nombreFoto, string descripcionFoto, byte[] imagen)
        {
            try
            {
                using (SqlConnection cn = ConexioBDD())
                {
                    using (SqlCommand cmd = new SqlCommand("CrearAlbumYFotos", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@NombreAlbum", nombreAlbum);
                        cmd.Parameters.AddWithValue("@DescripcionAlbum", descripcionAlbum);
                        cmd.Parameters.AddWithValue("@IdCandidata", idCandidata);
                        cmd.Parameters.AddWithValue("@NombreFoto", nombreFoto);
                        cmd.Parameters.AddWithValue("@DescripcionFoto", descripcionFoto);
                        cmd.Parameters.AddWithValue("@Imagen", imagen);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
            }
        }

        public bool AgregarComentarioAFoto(int idFoto, int idUsuario, string contenidoComentario, out string mensaje)
        {
            bool exito = false;
            mensaje = string.Empty;
            try
            {
                using (SqlConnection cn = ConexioBDD())
                {
                    SqlCommand cmd = new SqlCommand("ComentarFoto", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("IdFoto", idFoto);
                    cmd.Parameters.AddWithValue("IdUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("Contenido", contenidoComentario);

                    cmd.ExecuteNonQuery();

                    mensaje = "Comentario agregado exitosamente.";
                    exito = true;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return exito;
        }

        public List<Album> ObtenerAlbumesYFotosPorCandidata(int idCandidata)
        {
            List<Album> listaAlbumes = new List<Album>();

            try
            {
                using (SqlConnection cn = ConexioBDD())
                {
                    string query = @"
            SELECT A.ID_ALBUM, A.NOMBRE AS ALBUM_NOMBRE, A.DESCRIPCION AS ALBUM_DESCRIPCION,
            F.ID_FOTO, F.NOMBRE AS FOTO_NOMBRE, F.DESCRIPCION AS FOTO_DESCRIPCION, F.IMAGEN AS FOTO_IMAGEN
            FROM ALBUM A
            INNER JOIN FOTO F ON A.ID_ALBUM = F.ID_ALBUM
            WHERE  A.ID_CANDIDATA = @IdCandidata";

                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@IdCandidata", idCandidata);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id_Album = Convert.ToInt32(reader["ID_ALBUM"]);
                        Album album = listaAlbumes.FirstOrDefault(a => a.Id_Album == id_Album);

                        if (album == null)
                        {
                            album = new Album
                            {
                                Id_Album = id_Album,
                                Nombre = reader["ALBUM_NOMBRE"].ToString(),
                                Descripcion = reader["ALBUM_DESCRIPCION"].ToString(),
                                oCandidata = new Candidata { Id_Candidata = idCandidata },
                                Fotos = new List<Foto>()
                            };

                            listaAlbumes.Add(album);
                        }

                        Foto foto = new Foto
                        {
                            Id_Foto = Convert.ToInt32(reader["ID_FOTO"]),
                            Nombre = reader["FOTO_NOMBRE"].ToString(),
                            Descripcion = reader["FOTO_DESCRIPCION"].ToString(),
                            Imagen = (byte[])reader["FOTO_IMAGEN"],
                            oAlbum = album
                        };

                        album.Fotos.Add(foto);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
            }

            return listaAlbumes;
        }

    }
}

