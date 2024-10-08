using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4Lib.Models
{
    public class Sistemas
    {
        [Key]
        public int SistemaId { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string? NombreSistema { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string? DescripcionSistema { get; set; }
    }
}
