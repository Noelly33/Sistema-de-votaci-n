using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Candidata
    {
        public int Id_Candidata { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public byte[] Foto_Principal { get; set; }
        public string Carrera { get; set; }
        public int Semestre { get; set; }
        public string Pasatiempos { get; set; }
        public string Habilidades { get; set; }
        public string Intereses { get; set; }
        public string Aspiraciones { get; set; }
    }
}