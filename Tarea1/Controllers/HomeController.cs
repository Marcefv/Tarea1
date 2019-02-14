using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarea1.Models;

namespace Tarea1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Formulario()
        {          

            return View();
        }

        [HttpPost]
        public ActionResult Formulario(Gato modeloGato)
        {
            return View("InfoGato", modeloGato);
        }
    }
}