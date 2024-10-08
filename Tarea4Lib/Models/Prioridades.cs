using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4Lib.Models
{
    public class Prioridades
    {
        [Key]
        public int PrioridadId { get; set; }

        [Required(ErrorMessage = "Este Campo es Obligatorio")]
        public string? Descripcion { get; set; }

        [Range(1, 31, ErrorMessage = "El valor debe estar entre 1 y 31")]
        public int DiasCompromiso { get; set; }
    }
}
