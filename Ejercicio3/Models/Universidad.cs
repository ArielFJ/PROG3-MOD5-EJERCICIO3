using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class Universidad
    {
        public int IdUniversidad { get; set; }
        public string Nombre { get; set; }
        private List<Docente> docentes = new List<Docente>();
        public List<Docente> Docentes
        {
            get
            {
                if (docentes.Count > 0)
                {
                    for (int i = 0; i < docentes.Count; i++)
                    {
                        foreach (Docente d in UniversidadManager.Instance.Docentes)
                        {
                            if (docentes[i].IdEmpleado == d.IdEmpleado)
                                docentes[i] = d;
                        }
                    }
                }
                return docentes;
            }
        }
    }
}
