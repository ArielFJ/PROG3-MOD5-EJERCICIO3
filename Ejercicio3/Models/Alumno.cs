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
        public string CURP { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNac { get; set; }

        public List<Maestria> Maestrias { get; set; } = new List<Maestria>();
    }
}
