using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Comentario
    {
        public int Id_Comentario { get; set; }
        public Foto oFoto { get; set; }
        public Usuario oUsuario { get; set; }
        public string Contenido { get; set; }
    }
}
