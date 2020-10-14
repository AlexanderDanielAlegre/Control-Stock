using System;
using System.Collections.Generic;
using System.Text;

namespace Sofas.Domain.Models
{
    public class Proveedor : Personas
    {
        public int IdPersona { get; set; }

        public virtual Personas personas { get; set; }
    }
}
