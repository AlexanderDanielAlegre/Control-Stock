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
    public class ProveedoresController : Controller
    {
        private Sofas_Services.IProveedorServices services_proveedores { get; set;}
        private Sofas.Domain.SofasContext db;

        public ProveedoresController(SofasContext context, IProveedorServices proveedoresServices)
        {
            db = context;
            services_proveedores = proveedoresServices;
        }
        [HttpGet("[action]")]
        public void CargarPrueba()
        {
            services_proveedores.CargaPrueba();
           // return View();
         }
        //[HttpGet("[action]")]
        //public IActionResult Index()
        //{
        //    List<SofasContext.Consumibles> lst = null;
        //    lst = db.consumibles.ToList();
        //    return View();
        //}

        [HttpGet("[action]")]
        public IList<Sofas.Domain.ViewModels.ProveedorViewModels> Proveedores()
        {
            List<ProveedorViewModels> lst = null;

            //var lista = services_consumibles.RetornarConsumibles();

            //return lista;           //    //return View();

            var lista = services_proveedores.RecuperarProveedor();

            //lst = (List<ConsumiblesViewModels>)lista;//.ToList<ConsumiblesViewModels>();

            lst = (from _lista in lista
                   select new ProveedorViewModels
                   {
                       IdPersona = _lista.IdPersona,
                       personas = _lista.personas
                   }).ToList();

            return lst;  
            }

    }
}