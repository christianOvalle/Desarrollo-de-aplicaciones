using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticasASP.NET.Controllers
{
    public class RandoDeNotaController : Controller
    {
        // GET: RandoDeNota
        public ActionResult Index()
        {
            return View();
        }

        public string TuRango(String Nota) {

            
            string Informe = "";

            if (int.Parse(Nota) < 69)
            {

                Informe = $"D ({Nota})";
            }
            else if (int.Parse(Nota) < 79 || int.Parse(Nota) > 70)
            {

                Informe = $"C ({Nota})";

            }

            else if (int.Parse(Nota) < 89 || int.Parse(Nota) > 80)
            {

                Informe = $"B ({Nota})";

            }

            else if (int.Parse(Nota) < 100 || int.Parse(Nota) > 90)
            {

                Informe = $"C ({Nota})";

            }

            else {

                Informe = "A ocurrido un error";
            
            }

            return Informe;
        }


    }
}