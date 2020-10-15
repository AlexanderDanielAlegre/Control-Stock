using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sofas.Domain;
using Sofas.Domain.ViewModels;
using Sofas.Domain.Models;
using Sofas_Services;


namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class ConsumiblesController : Controller
    {
        private Sofas_Services.IConsumiblesServices services_consumibles { get; set;}
        private Sofas.Domain.SofasContext db;

        public ConsumiblesController(SofasContext context, IConsumiblesServices consumiblesServices)
        {
            db = context;
            services_consumibles = consumiblesServices;
        }

        public ActionResult Index()
        {
            services_consumibles.CargaPrueba();
            return View();
         }
        //[HttpGet("[action]")]
        //public IActionResult Index()
        //{
        //    List<SofasContext.Consumibles> lst = null;
        //    lst = db.consumibles.ToList();
        //    return View();
        //}

        [HttpGet("[action]")]
        public IList<Sofas.Domain.ViewModels.ConsumiblesViewModels> Consumibles()
        {
            List<ConsumiblesViewModels> lst = null;

            //var lista = services_consumibles.RetornarConsumibles();

            //return lista;           //    //return View();

           var lista = services_consumibles.RetornarConsumibles();

            //lst = (List<ConsumiblesViewModels>)lista;//.ToList<ConsumiblesViewModels>();

            lst = (from _lista in lista
                   select new ConsumiblesViewModels
                   {
                       Id = _lista.id,
                       Consumibles_Descripcion = _lista.Producto
                   }).ToList();

            return lst;  
            }

    }
}