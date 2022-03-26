using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows;
namespace PracticasASP.NET.Controllers
{
    public class HolaMundoController : Controller
    {
        // GET: HolaMundo
        public ActionResult IndexSaludo()
        {
           
            
            return View("IndexHola");
        }
    }
}