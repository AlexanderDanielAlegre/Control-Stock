using System;
using System.Linq;
using Sofas.Domain;

namespace PrServices
{
    public class ConsumiblesServices
    {
        private SofasContext context;

        public void RetornarConsumibles()
        {
            using (context)
            {
                var datosconsumibles = context.consumibles.ToList();

            }
        }
    }

}
