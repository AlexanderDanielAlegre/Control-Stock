using Remotion.Linq.Clauses;
using Sofas.Domain;
using Sofas.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Sofas.Domain.Models;

namespace Sofas_Services
{
    public class ProveedorServices : IProveedorServices
    {
        private SofasContext _context;
        public ProveedorServices(SofasContext context)
        {
            _context = context;
        }
        public List<ProveedorViewModels> RecuperarProveedor()
        {
            List<ProveedorViewModels> lst = null;
            lst = (from _lista in _context.proveedores
                   join _personas in _context.personas
                   on _lista.IdPersona equals _personas.id
                   select new ProveedorViewModels
                   {
                       IdPersona = _lista.IdPersona

                   }).ToList();
            return lst;
        }
    }
}
