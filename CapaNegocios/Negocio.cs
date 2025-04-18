using System;
using CapaDatos;
using Clases;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocios
{
    public class Negocio
    {
        private Datos objecto = new Datos();
        //Usuario
        public List<Usuario> ListarUsuarios()
        {
            return objecto.ingresarUsuario();
        }
        public Usuario recuperarClaveSQL(string correo)
        {
            return objecto.recuperarClave(correo);
        }
        //Permiso
        public List<Permiso> permisosSQL(int idUsuario)
        {
            return objecto.permisosMenu(idUsuario);
        }
        //Rol
        public List<Rol> rolesSQL()
        {
            return objecto.listarRol();
        }
        public List<Candidata> mostrarCandidataSQL()
        {
            return objecto.mostrarCandidata();
        }
        public int resgistrarCandidataSQL(Candidata obj, byte[] foto, out string mensaje)
        {
            return objecto.registrarCandidata(obj, foto, out mensaje);
        }
        public bool editarCandidataSQL(Candidata obj, byte[] foto, out string mensaje)
        {
            mensaje = string.Empty;
            if (obj.Cedula == "")
            {
                mensaje += "Es necesario el documento del transportista.\n";
            }
            if (obj.Nombres == "")
            {
                mensaje += "Es necesario los dos nombres del transportista.\n";
            }
            if (obj.Carrera == "")
            {
                mensaje += "Es necesario los dos apellidos del transportista.\n";
            }
            if (obj.Semestre == 0)
            {
                mensaje += "Es necesario la cédula del transportista.\n";
            }
            if (obj.Pasatiempos == "")
            {
                mensaje += "Es necesario el teléfono del transportista.\n";
            }
            if (obj.Habilidades == "")
            {
                mensaje += "Es necesario el correo electrénico del transportista.\n";
            }
            if (obj.Intereses == "")
            {
                mensaje += "Es necesario el correo electrénico del transportista.\n";
            }
            if (obj.Aspiraciones == "")
            {
                mensaje += "Es necesario el correo electrénico del transportista.\n";
            }
            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objecto.editarCandidata(obj, foto, out mensaje);
            }
        }
        public bool eliminarCandidataSQL(Candidata obj, out string mensaje)
        {
            return objecto.eliminarCandidata(obj, out mensaje);
        }
        public int VotacionCandidataSQL(Votacion obj, out string mensaje)
        {
            return objecto.RegistrarVoto(obj, out mensaje);
        }
        public DataTable GanadoraFotogenia()
        {
            return objecto.GetVotacionFotogenia();
        }
        public DataTable GanadoraReina()
        {
            return objecto.GetVotacionReina();
        }
       
        public void CrearAlbumYFotos(string nombreAlbum, string descripcionAlbum, int idCandidata, string nombreFoto, string descripcionFoto, byte[] imagen)
        {
            objecto.CrearAlbumYFotos(nombreAlbum, descripcionAlbum, idCandidata, nombreFoto, descripcionFoto, imagen);
        }
        public bool AgregarComentarioAFoto(int idFoto, int idUsuario, string contenidoComentario, out string mensaje)
        {
            return objecto.AgregarComentarioAFoto(idFoto, idUsuario, contenidoComentario, out mensaje);
        }
        public List<Album> ObtenerAlbumesYFotosPorCandidata(int idCandidata)
        {
            return objecto.ObtenerAlbumesYFotosPorCandidata(idCandidata);
        }

    }
}
