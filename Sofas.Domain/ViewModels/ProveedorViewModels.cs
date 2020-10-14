using Sofas.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sofas.Domain.ViewModels
{
   public class ProveedorViewModels
    {
        public int IdPersona { get; set; }

        public virtual Personas personas { get; set; }
    }
}
