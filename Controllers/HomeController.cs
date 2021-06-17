using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Peliculas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Descripción de la Pagina.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Datos para contactarme.";

            return View();
        }
        public ActionResult Peliculas()
        {
            ViewBag.Message = "Listado de peliculas Disponibles";

            return View();
        }
        public ActionResult Series()
        {
            return View();
        }
        public ActionResult Animes()
        {
            return View();
        }
        public ActionResult Documentales()
        {
            return View();
        }
    }
}