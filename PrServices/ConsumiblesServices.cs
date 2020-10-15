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
            int a;
            //int? b;
            //System.Nullable<decimal> a;

            using (_context)
            {
                 datosconsumibles = _context.consumibles.ToList();
                //datosconsumibles = _context.consumibles.Where(x => x.id == 1).Select(x => x.id).FirstOrDefault();

            }
            // IList<IList<Consumibles>> ret = new List<IList<Consumibles>>();
            return datosconsumibles;
        }

        public void CargaPrueba()
        {
            Consumibles consumible = new Consumibles();
            consumible.Producto = "Harina 0000";
            _context.SaveChanges();
        }
    }

}
