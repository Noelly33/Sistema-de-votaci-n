using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Votacion
    {
        public int Id_Votacion { get; set; }
        public Candidata oCandidata { get; set; }
        public Usuario oUsuario { get; set; }
        public string Tipo_votacion { get; set; }
    }
}