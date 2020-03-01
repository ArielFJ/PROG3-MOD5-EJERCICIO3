using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class Docente
    {
        [Required]
        public int IdEmpleado { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(10)]
        [Range(0, Int64.MaxValue, ErrorMessage = "Sólo puede contener números")]
        public string Telefono { get; set; }

        private List<Universidad> universidades = new List<Universidad>();
        public List<Universidad> Universidades {
            get
            {
                if (universidades.Count > 0)
                {
                    for (int i = 0; i < universidades.Count; i++)
                    {
                        foreach (Universidad u in UniversidadManager.Instance.Universidades)
                        {
                            if (universidades[i].IdUniversidad == u.IdUniversidad)
                                universidades[i] = u;
                        }
                    }
                }
                return universidades;
            }
        }

        private List<Maestria> maestrias = new List<Maestria>();
        public List<Maestria> Maestrias {
            get
            {
                if (maestrias.Count > 0)
                {
                    for (int i = 0; i < maestrias.Count; i++)
                    {
                        foreach (Maestria master in UniversidadManager.Instance.Maestrias)
                        {
                            if (maestrias[i].IdMaestria == master.IdMaestria)
                                maestrias[i] = master;
                        }
                    }
                }
                return maestrias;
            }
        }
    }
}
