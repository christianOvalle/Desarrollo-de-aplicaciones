using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practicas.Controllers
{
    public class IntereseConOpcionesController : Controller
    {
        // GET: IntereseConOpciones
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InteresesYopciones(int Years, string Opcion) {

            double Capital = 100450;
            double Intereses = 0;

            Intereses = (Capital * 0.15) * Years;

            if (Opcion == "No")
            {

                ViewBag.Intereses = $"Interese Sin capital: {Intereses}";

            }

            else if (Opcion == "Si")
            {

                ViewBag.Intereses = $"Interese Con capital: { (Intereses + Capital)}";


            }

            return View();

        }
    }
}