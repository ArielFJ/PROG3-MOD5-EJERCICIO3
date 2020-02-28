using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    interface IUniversidadRepo
    {
        IEnumerable<Universidad> AllUniversidades { get; }
        void AgregarUniversidad(Universidad universidad);
        void EliminarUniversidad(int id);
        void ActualizarUniversidad(int id, Universidad datos);
        Alumno ObtenerUniversidad(int id);
    }
}
