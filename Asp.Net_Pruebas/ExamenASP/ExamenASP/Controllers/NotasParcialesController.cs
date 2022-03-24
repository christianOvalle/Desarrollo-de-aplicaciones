using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenASP.Controllers
{
    public class NotasParcialesController : Controller
    {
        // GET: NotasParciales
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AproboOno(string Nota, string Nota2, string Nota3,string nombre) {



            int promedio = (int.Parse(Nota) + int.Parse(Nota) + int.Parse(Nota)) / 3;

            if (promedio == 70)
            {

                ViewBag.Resultado = $"{nombre} Has Aprobado con {promedio}";

            }

            else if (promedio < 70) {

                ViewBag.Resultado = $"{nombre} Has Reprobado con {promedio}";

            }


            return View();

        }

    }
}