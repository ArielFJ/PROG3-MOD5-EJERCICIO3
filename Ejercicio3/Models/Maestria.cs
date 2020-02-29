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
        [Range(0,6)]
        [Display(Name = "Duración en Años")]
        public float Duracion { get; set; }
        public List<Docente> Docentes { get; set; } = new List<Docente>();
    }
}
