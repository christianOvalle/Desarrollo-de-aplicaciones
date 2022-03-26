using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticasASP.NET.Controllers
{
    public class TablaDel6Controller : Controller
    {
        // GET: TablaDel6
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult tabla()
        {

            int numero = 6; 

            for (int i = 1; i <= numero; i++)
            {
                ViewBag.tabla += numero + "x" + i + "=" + numero * i + "----";
               
            }

            return View();
        }
    }
}