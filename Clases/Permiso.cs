using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Permiso
    {
        public int ID { get; set; }
        public Rol oRol { get; set; }
        public string NombreMenu { get; set; }
    }
}
