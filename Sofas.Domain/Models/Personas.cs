using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sofas.Domain.Models
{
    [Table("Personas")]
    public class Personas
    {
        public int id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [DataType(DataType.Text)]
        public string nombre { get; set; }
        [DataType(DataType.Text)]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "")]
        public string apellido { get; set; }
        [EmailAddress]
        public string email { get; set; }

    }
}
