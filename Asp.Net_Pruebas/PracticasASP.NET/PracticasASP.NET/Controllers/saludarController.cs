using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticasASP.NET.Controllers
{
    public class saludarController : Controller
    {
        // GET: saludar
        public ActionResult saludo()
        {

            return View();
        }

        public string Hola (string nombre) {

            string hola = $"Hola {nombre}";

            return hola;
        
        
        }
    }
}