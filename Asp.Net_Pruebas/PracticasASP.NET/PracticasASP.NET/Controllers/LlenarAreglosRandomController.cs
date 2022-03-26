using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practicas.Controllers
{
    public class LlenarAreglosRandomController : Controller
    {
        // GET: LlenarAreglosRandom
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Relleno()
        {

            int[] arreglo = new int[15];
            Random num = new Random();

            for (int i = 0; i < 15; i++) {

                arreglo[i] = num.Next(1, 100);
                ViewBag.numero += arreglo[i] + "_";            
            }

            return View();

        }


    }
}