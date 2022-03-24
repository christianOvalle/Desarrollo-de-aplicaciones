using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenASP.Controllers
{
    public class RestoController : Controller
    {
        // GET: Resto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RestoMetodo(string num1,string num2) {

            if (int.Parse(num1) == 0 || int.Parse(num2) == 0)
            {

                return Content("Nose puede realizar la operacion");
            }

            else
            {
                int resultado = int.Parse(num1) % int.Parse(num2);

                ViewBag.resultado = resultado;
            }
            return View();   
        }

    }
}