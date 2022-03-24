 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practicas.Controllers
{
    public class ListaController : Controller
    {
        // GET: Lista
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult lista() {


            List<int> MiLista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            for (int i = 1; i <= MiLista.Count; i++) {

                ViewBag.Lista += i + " ";     
                  
            }

            int NumeroMasAlto =MiLista.Max();
            int NumeroMenor = MiLista.Min();
            int Suma = MiLista.Sum();
           


            ViewBag.MasAlto = $"Numero mas alto: {NumeroMasAlto}";
            ViewBag.Menor = $"Numero menor:{NumeroMenor}";
            ViewBag.Suma = $"Suma de numero {Suma}";
            ViewBag.promedio =$"Promedio: {Suma / MiLista.Count}";
            return View();


        
        
        }



    }
}