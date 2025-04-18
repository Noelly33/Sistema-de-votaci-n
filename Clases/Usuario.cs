using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombres_Completo { get; set; }
        public string Clave {  get; set; }
        public string Correo_Electronico {  get; set; }
        public Rol oRol {  get; set; }
        public bool Estado { get; set; }
    }
}
