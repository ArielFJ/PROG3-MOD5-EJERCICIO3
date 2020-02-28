using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public interface IDocenteRepo
    {
        IEnumerable<Docente> AllDocentes { get; }
        void AgregarDocente(Docente docente);
        void EliminarDocente(int id);
        void ActualizarDocente(int id, Docente datos);
        Docente ObtenerDocente(int id);
    }
}
