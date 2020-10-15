using System;
using System.Collections.Generic;
using System.Text;
using Sofas.Domain.Models;

namespace Sofas_Services
{
    public interface IConsumiblesServices
    {
        IList<Consumibles> RetornarConsumibles();
        void CargaPrueba();

    }
}
