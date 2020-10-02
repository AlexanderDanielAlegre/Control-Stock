using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sofas.Domain;
using Sofas.Domain.ViewModels;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class ConsumiblesController : Controller
    {
        private Sofas.Domain.SofasContext db;
        public ConsumiblesController(SofasContext context)
        {
            db = context;
        }
        //[HttpGet("[action]")]
        //public IActionResult Index()
        //{
        //    List<SofasContext.Consumibles> lst = null;
        //    lst = db.consumibles.ToList();
        //    return View();
        //}
        [HttpGet("[action]")]
        public IEnumerable<Sofas.Domain.ViewModels.ConsumiblesViewModels> Consumibles()
        {
            List<ConsumiblesViewModels> lst = null;
            lst = (from datebase in db.consumibles
                   select new ConsumiblesViewModels
                   {
                       Id = datebase.id,
                       Consumibles_Descripcion = datebase.Producto
                   }).ToList();

            return lst;           //    //return View();
            }

        }
}