using System;
using System.Collections.Generic;
using System.Text;

namespace Sofas.Domain.Models
{
    public class ToDo
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public bool completado { get; set; }
    }
}
