using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practicas.Controllers
{
    public class InvesionController : Controller
    {
        // GET: Invesion
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Interese() { 


        double Capital = 300450;
        double Intereses = 0;

        Intereses = (Capital * 0.10) * 8;
        
        ViewBag.Intereses = Intereses;

            return View();
        
        
        
        
        
        
        }
    }
}