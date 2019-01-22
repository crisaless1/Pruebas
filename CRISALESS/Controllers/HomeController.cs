using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;

namespace CRISALESS.Controllers
{
    public class HomeController : Controller
    {

        private FACTURA factura = new FACTURA();

        public ActionResult Index()
        {
            return View(factura.Todas());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult EditarFactura(int id = 0)
        {
            return View(
                id == 0 ? new FACTURA()
                       : factura.Obtener(id));
        }

    }
}