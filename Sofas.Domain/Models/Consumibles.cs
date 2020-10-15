using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;



namespace Sofas.Domain.Models
{
    public class Consumibles
    {
        [Key]
        public int id { get; set; }
        public string Producto { get; set; }
        // public string MyProperty { get; set; }
    }
}
