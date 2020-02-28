using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class AlumnoRepo : IAlumnoRepo
    {
        private readonly UniversidadManager manager;

        public AlumnoRepo(UniversidadManager manager)
        {
            this.manager = manager;
        }

        public IEnumerable<Alumno> AllAlumnos => manager.Alumnos;

        public void ActualizarAlumno(int id, Alumno datos)
        {
            int index = manager.Alumnos.FindIndex(a => a.BoletaAlumno == id);
            manager.Alumnos[index] = datos;
        }

        public void AgregarAlumno(Alumno alumno)
        {
            manager.Alumnos.Add(alumno);
        }

        public void EliminarAlumno(int id)
        {
            manager.Alumnos.Remove(ObtenerAlumno(id));
        }

        public Alumno ObtenerAlumno(int id)
        {
            return manager.Alumnos.FirstOrDefault(a => a.BoletaAlumno == id);
        }
    }
}
