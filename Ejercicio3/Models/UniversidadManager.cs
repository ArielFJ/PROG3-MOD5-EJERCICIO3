using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class UniversidadManager
    {
        public List<Alumno> Alumnos { get; set; } = new List<Alumno>();
        public List<Docente> Docentes { get; set; } = new List<Docente>();
        public List<Maestria> Maestrias { get; set; } = new List<Maestria>();
        public List<Universidad> Universidades { get; set; } = new List<Universidad>();
    }
}
