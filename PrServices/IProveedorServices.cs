using Sofas.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sofas_Services
{
    public interface IProveedorServices
    {
         List<ProveedorViewModels> RecuperarProveedor();
        void CargaPrueba();

    }
}
