using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TDG_SOLAIRE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Solaire.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Informacion de Contacto.";

            return View();
        }
    }
}