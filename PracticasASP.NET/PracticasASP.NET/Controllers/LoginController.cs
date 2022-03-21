using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticasASP.NET.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index1()
        {
          return View();
        }

        public string loginUsuario(string Usuario, string Clave) {

            string usuario = "infotep";
            string clave = "transparencia";
            string mensaje = "";
            

            if (Usuario == usuario || clave == Clave) {

                mensaje = "Usted a ingresado";

            }
            else if (Usuario != usuario && clave != Clave){


                mensaje = "Usuario o clave incorrecto.";

            }
           
            return mensaje;











        }
    }
}