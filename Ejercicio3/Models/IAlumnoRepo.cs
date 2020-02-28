using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    interface IAlumnoRepo
    {
        IEnumerable<Alumno> AllAlumnos { get; }
        void AgregarAlumno(Alumno alumno);
        void EliminarAlumno(int id);
        void ActualizarAlumno(int id, Alumno datos);
        Alumno ObtenerAlumno(int id);
    }
}
