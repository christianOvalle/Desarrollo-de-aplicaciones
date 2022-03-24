using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practicas.Controllers
{
    public class RandomController : Controller
    {
        // GET: Random
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NumeroRandom() {


            Random random = new Random();

           ViewBag.resultado = random.Next(1, 100);

            return View();
        }
    }
}