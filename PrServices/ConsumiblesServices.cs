using System;
using System.Collections.Generic;
using System.Linq;
using Sofas.Domain;
using Sofas.Domain.Models;
using static Sofas.Domain.SofasContext;
namespace Sofas_Services
{
    public class ConsumiblesServices : IConsumiblesServices 
    {
        private SofasContext _context;
        public ConsumiblesServices(SofasContext context)
        {
            _context = context;
        }
       // 

        public IList<Consumibles> RetornarConsumibles()
        {
            List<Consumibles> datosconsumibles;

            using (_context)
            {
                 datosconsumibles = _context.consumibles.ToList();

            }
           // IList<IList<Consumibles>> ret = new List<IList<Consumibles>>();

            return datosconsumibles;
        }
    }

}
