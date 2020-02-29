using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class UniversidadManager
    {
        public static readonly UniversidadManager Instance = new UniversidadManager();
        private UniversidadManager() {  }

        public List<Alumno> Alumnos { get; } = new List<Alumno>() 
        {
            new Alumno(){ BoletaAlumno = 1, Nombre = "Ariel", CURP="213438223", FechaNac = DateTime.Parse("7,16,2001")},
            new Alumno(){ BoletaAlumno = 2, Nombre = "José", CURP="3554321", FechaNac = DateTime.Parse("9,26,1990")},
        };
        public List<Docente> Docentes { get; } = new List<Docente>();
        public List<Maestria> Maestrias { get; } = new List<Maestria>();
        public List<Universidad> Universidades { get; } = new List<Universidad>();

        // Manejo de alumnos
        public void ActualizarAlumno(int id, Alumno datos)
        {
            int index = Alumnos.FindIndex(a => a.BoletaAlumno == id);
            Alumnos[index] = datos;
        }

        public void AgregarAlumno(Alumno alumno)
        {
            var id = Alumnos.Count > 0 ? Alumnos.Max(s => s.BoletaAlumno) + 1 : 0;
            alumno.BoletaAlumno = id;
            Alumnos.Add(alumno);
        }

        public void EliminarAlumno(int id)
        {
            Alumnos.Remove(ObtenerAlumno(id));
        }

        public Alumno ObtenerAlumno(int id)
        {
            return Alumnos.FirstOrDefault(a => a.BoletaAlumno == id);
        }

        public void AgregarMaestriaAlumno(int id, Maestria maestria)
        {
            ObtenerAlumno(id).Maestrias.Add(maestria);
        }

        // Manejo de Maestrias

        public void AgregarMaestria(Maestria maestria)
        {
            var id = Maestrias.Count > 0 ? Maestrias.Max(s => s.IdMaestria) + 1 : 0;
            maestria.IdMaestria = id;
            Maestrias.Add(maestria);
        }
    }
}
