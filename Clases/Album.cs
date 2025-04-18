using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Album
    {
        public int Id_Album { get; set; }
        public string Nombre { get; set; }            
        public string Descripcion { get; set; }
        public List<Foto> Fotos { get; set; }
        public Usuario oUsuario { get; set; }
        public Candidata oCandidata { get; set; }
    }
}
