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
                //datosconsumibles = _context.consumibles.Where(x => x.id == 1).Select(x => x.id).FirstOrDefault();

            }
            return datosconsumibles;
        }

        public void CargaPrueba()
        {
            Consumibles consumible = new Consumibles();
            consumible.Producto = "Harina 0000";
        //    consumible.id = 4;
           // _context.
            _context.consumibles.Add(consumible);
            _context.SaveChanges();
        }

        /// <summary>
        /// recives the consumible to save in the database
        /// </summary>
        /// <param name="consumible"></param>
        /// 
        public void CargaConsumibles(string _consumible)
        {
            Consumibles consumible = new Consumibles();

            consumible.Producto = _consumible;
            _context.consumibles.Add(consumible);
            _context.SaveChanges();
        }
        public void CargaConsumibles(List<string> _consumibles)
        {
            List<Consumibles> consumiblesgrabar = new List<Consumibles>();

            foreach (var item in _consumibles)
            {
                Consumibles consumible = new Consumibles();
                consumible.Producto = item;/*item.ElementAt<1>*/

                consumiblesgrabar.Add(consumible);

            }
            //metodo para guardar una lista con foreach directo a la BD


            _context.SaveChanges();
        }



    }

}
