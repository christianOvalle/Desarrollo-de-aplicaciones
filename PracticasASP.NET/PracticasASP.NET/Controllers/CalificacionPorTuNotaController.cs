using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticasASP.NET.Controllers
{
    public class CalificacionPorTuNotaController : Controller
    {
        // GET: CalificacionPorTuNota
        public ActionResult Index()
        {
            return View();
        }

        public string TuLetraPorNota(string nota1, string nota2, string nota3, string nota4)
        {

            int resultado = 0;
            string aviso = "";

            resultado = (int.Parse(nota1) + int.Parse(nota2) + int.Parse(nota3) + int.Parse(nota4)) / 4;


            if (resultado <= 69)
            {

                aviso = $"Tu calificacion es {resultado}, Equivale a D";

            }

            else if (resultado >= 69 || resultado <= 79)
            {

                aviso = $"Tu calificacion es {resultado}, Equivale a C";

            }

            else if (resultado >= 79 || resultado <= 89)
            {

                aviso = $"Tu calificacion es {resultado}, Equivale a B";

            }

            else if (resultado >= 89 || resultado <= 100)
            {

                aviso = $"Tu calificacion es {resultado}, Equivale A";

            }

            return aviso;



        }
    }
}