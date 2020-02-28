using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    interface IMaestriaRepo
    {
        IEnumerable<Maestria> AllMaestria { get; }
        void AgregarMaestria(Maestria maestria);
        void EliminarMaestria(int id);
        void ActualizarMaestria(int id, Maestria datos);
        Alumno ObtenerMaestria(int id);
    }
}
