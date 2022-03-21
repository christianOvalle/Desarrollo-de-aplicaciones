using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practicas.Controllers
{
    public class TablaMultiController : Controller
    {
        // GET: TablaMulti
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TablaProceso(string Usuario) {


            int numero = int.Parse(Usuario);

            for (int i = numero; i<= numero; i++) {
               
                for (int m = 1; m <= 12; m++) {
                    
                    ViewBag.tabla += i + "x" + m + "=" + (m * i) +"<br>";
                   


                }                                    
            }
            
            return View("proceso");

        
        
        }

    }
}