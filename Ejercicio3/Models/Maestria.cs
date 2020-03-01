using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class Maestria
    {
        [Required]
        public int IdMaestria { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Range(0,6, ErrorMessage = "Las maestrías duran entre 0.5 y 6 años")]
        [Display(Name = "Duración en Años")]
        public float Duracion { get; set; }

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
