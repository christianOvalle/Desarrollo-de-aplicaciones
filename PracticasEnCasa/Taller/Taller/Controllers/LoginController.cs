using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Taller.Controllers
{
    public class LoginController : Controller
    {
        Models.db_TallerEntities db = new Models.db_TallerEntities();
        

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        

        public ActionResult ProcesarLogin(string nombre, string clave) {


            var UsuAux= db.Usuario.Where(x => x.nombre == nombre && x.contrasena == clave).FirstOrDefault();

            if (UsuAux != null) {

                return RedirectToAction("Index", "Clientes");
            
            }

            return Content("Nombre o Clave incorrectos");
        
        
        }
    }
}