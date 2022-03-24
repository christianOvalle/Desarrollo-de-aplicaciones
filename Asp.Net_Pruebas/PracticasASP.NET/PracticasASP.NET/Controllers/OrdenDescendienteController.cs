using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticasASP.NET.Controllers
{
    public class OrdenDescendienteController : Controller
    {
        // GET: OrdenDescendiente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Descender()
        {

            for (int i = 2020; i > 1990; i--)
            {
                ViewBag.mostrar += i.ToString()+"_";

            }

            return View();
        }

        public ActionResult DescenderWhile() {

            int i =2020;

            while (i >= 1991) { 
            
            ViewBag.MostrarWhile += i.ToString()+"_";   

                i--;
        
            
            }


            return View();
        
        }

    }
}