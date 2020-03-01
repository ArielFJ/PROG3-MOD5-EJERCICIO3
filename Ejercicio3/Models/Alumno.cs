using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class Alumno
    {
        [Required]
        public int BoletaAlumno { get; set; } //Clave primaria

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(20)]
        [Range(0, Int64.MaxValue, ErrorMessage = "Sólo puede contener números")]
        public string CURP { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNac { get; set; }

        private List<Maestria> maestrias = new List<Maestria>();

        public List<Maestria> Maestrias {
            get 
            {
                if (maestrias.Count > 0)
                {
                    for (int i = 0; i <maestrias.Count; i++)
                    {
                        foreach(Maestria master in UniversidadManager.Instance.Maestrias)
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
