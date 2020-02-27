using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class Alumno
    {
        public int Boleta { get; set; } //Clave primaria
        public string Nombre { get; set; }
        public string CURP { get; set; }
        public DateTime FechaNac { get; set; }
    }
}
