using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practicas.Controllers
{
    public class RandomThirthyController : Controller
    {
        // GET: RandomThirthy
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Rellenando(int numero)
        {

            if (numero < 50 || numero > 100)
            {

                
                
                return View("Index");


            }
            else
            {

                int[] arreglo = new int[30];
                Random num = new Random();

                for (int i = 0; i < 30; i++)
                {

                    arreglo[i] = num.Next(50, 101);
                    ViewBag.numero += arreglo[i] + "_";
                }

                return View();
            }
        }
    }
}