using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticasASP.NET.Controllers
{
    public class Bucle10En10Controller : Controller
    {
        // GET: Bucle10En10
        public ActionResult Index()
        {
            return View();
        }

        public string Bucle()
        {
            
           string numero = "";
            
            for (int i = 600; i <= 800; i+= 10)
            {
              numero += i + "-";
                
            }    

            return numero;

             



        }
    }
}