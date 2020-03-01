using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class UniversidadManager
    {
        public static readonly UniversidadManager Instance = new UniversidadManager();
        private UniversidadManager() { }

        public List<Alumno> Alumnos { get; } = new List<Alumno>();
        public List<Docente> Docentes { get; } = new List<Docente>();
        public List<Maestria> Maestrias { get; } = new List<Maestria>();
        public List<Universidad> Universidades { get; } = new List<Universidad>();

        #region ManejoAlumnos
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
        #endregion

        #region ManejoMaestrias

        public void AgregarMaestria(Maestria maestria)
        {
            var id = Maestrias.Count > 0 ? Maestrias.Max(s => s.IdMaestria) + 1 : 0;
            maestria.IdMaestria = id;
            Maestrias.Add(maestria);
        }

        public Maestria ObtenerMaestria(int id)
        {
            return Maestrias.FirstOrDefault(m => m.IdMaestria == id);
        }

        public void ActualizarMaestria(int id, Maestria datos)
        {
            int index = Maestrias.FindIndex(m => m.IdMaestria == id);
            datos.IdMaestria = id;
            Maestrias[index] = datos;
        }

        public void EliminarMaestria(int id)
        {
            Maestrias.Remove(ObtenerMaestria(id));
        }
        #endregion

        #region ManejoDocentes

        public void AgregarDocente(Docente docente)
        {
            var id = Docentes.Count > 0 ? Docentes.Max(s => s.IdEmpleado) + 1 : 0;
            docente.IdEmpleado = id;
            Docentes.Add(docente);
        }

        public Docente ObtenerDocente(int id)
        {
            return Docentes.FirstOrDefault(m => m.IdEmpleado == id);
        }

        public void ActualizarDocente(int id, Docente datos)
        {
            int index = Docentes.FindIndex(m => m.IdEmpleado == id);
            datos.IdEmpleado = id;
            Docentes[index] = datos;
        }

        public void EliminarDocente(int id)
        {
            Docentes.Remove(ObtenerDocente(id));
        }
        #endregion

        #region ManejoUniversidades

        public void AgregarUnivesidad(Universidad universidad)
        {
            var id = Universidades.Count > 0 ? Universidades.Max(s => s.IdUniversidad) + 1 : 0;
            universidad.IdUniversidad = id;
            Universidades.Add(universidad);
        }

        public Universidad ObtenerUniversidad(int id)
        {
            return Universidades.FirstOrDefault(m => m.IdUniversidad == id);
        }

        public void ActualizarUnivesidad(int id, Universidad datos)
        {
            int index = Universidades.FindIndex(m => m.IdUniversidad == id);
            datos.IdUniversidad = id;
            Universidades[index] = datos;
        }

        public void EliminarUniversidad(int id)
        {
            Universidades.Remove(ObtenerUniversidad(id));
        }
        #endregion

        #region ManejoDependencias
        public bool MaestriaAlumnoDependencia(int id)
        {
            foreach (var item in Alumnos)
                foreach (var maestria in item.Maestrias)
                    if (maestria.IdMaestria == id)
                        return true;
            return false;
        }

        public bool MaestriaDocenteDependencia(int id)
        {
            foreach (var item in Docentes)
                foreach (var maestria in item.Maestrias)
                    if (maestria.IdMaestria == id)
                        return true;
            return false;
        }

        public bool DocenteMaestriaDependencia(int id)
        {
            foreach (var item in Maestrias)
                foreach (var docente in item.Docentes)
                    if (docente.IdEmpleado == id)
                        return true;
            return false;
        }

        public bool UniversidadDocenteDependencia(int id)
        {
            foreach (var item in Universidades)
                foreach (var docente in item.Docentes)
                    if (docente.IdEmpleado == id)
                        return true;
            return false;
        }

        public bool DocenteUniversidadDependencia(int id)
        {
            foreach (var item in Docentes)
                foreach (var universidad in item.Universidades)
                    if (universidad.IdUniversidad == id)
                        return true;
            return false;
        }
        #endregion
    }
}
