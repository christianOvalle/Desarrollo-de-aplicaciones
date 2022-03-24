using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practicas.Controllers
{
    public class NumeroDeAparicionesController : Controller
    {
        // GET: NumeroDeApariciones
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RellenandoYobteniendo(int Numero)
        {

            if (Numero < 50 || Numero > 100)
            {
                return View("Index");
            }

            else
            {
                int apariciones = 0;
                int[] arreglo = new int[30];
                Random num = new Random();

                for (int i = 0; i < 30; i++)
                {
                    arreglo[i] = num.Next(50, 100);                 
                    ViewBag.numero += arreglo[i] + " ";

                    if (Numero == arreglo[i])
                    {                       
                        apariciones++;                       
                    }
                }
                ViewBag.contado = $"Numero de aparaciones: {apariciones}";
                }
                   return View();
            }
        }
    }
