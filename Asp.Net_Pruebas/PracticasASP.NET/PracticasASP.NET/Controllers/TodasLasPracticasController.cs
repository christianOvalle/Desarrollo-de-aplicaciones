using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticasASP.NET.Controllers
{
    public class TodasLasPracticasController : Controller
    {
        // GET: TodasLasPracticas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SelectPruebas(string Decision) {

            if (Decision == "1") {

                return RedirectToAction("IndexSaludo", "HolaMundo");

            }

            else if (Decision == "2") {

                return RedirectToAction("saludo", "saludar");

            }

            else if (Decision == "3") {


                return View("NotasPromedio", "Notas");

            }
            else if (Decision == "4") {


                return View("Index", "RandoDeNota");
            }

            else if (Decision == "4")


                return View("Index", "RandoDeNota");
        }

    }
}    
