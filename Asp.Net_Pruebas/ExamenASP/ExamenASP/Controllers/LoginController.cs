using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenASP.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Logeo(string Nombre, string Clave) {

            if (Nombre == "Cristian" && Clave == "123")
            {

                ViewBag.Login = "A ingresado";

            }
            else {

                ViewBag.Login = "Usuario o clave incorrecto";

            }

            return View();
        }
    }
}