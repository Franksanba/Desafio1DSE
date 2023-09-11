using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Desafio_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Somos Tu mejor opcion en medicamentos";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Aquí como puedes contactarnos";

            return View();
        }
    }
}