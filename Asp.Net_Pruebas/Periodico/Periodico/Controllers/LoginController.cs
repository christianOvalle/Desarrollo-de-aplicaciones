using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Periodico.Controllers
{
    public class LoginController : Controller
    {

        Models.db_periodicoEntities db = new Models.db_periodicoEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProcesarLogin(string Usuario,string Clave) {

           var UsuarioAux= db.Usuarios.Where(x => x.usuario1 == "Cristian" && x.clave == "1234").FirstOrDefault();

            if (UsuarioAux != null)
            {

                return RedirectToAction("Index", "Usuario");

            }
            else if (UsuarioAux == null) {

                return Content("No a ingresado");
            
            }

            return View();
        
        
        }


    }
}