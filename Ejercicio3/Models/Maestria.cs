using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class Maestria
    {
        public int IdMaestria { get; set; }
        public string Nombre { get; set; }
        public float Duracion { get; set; }
        public int BoletaAlumno { get; set; }
        
        public List<Docente> Docentes { get; set; }
    }
}
