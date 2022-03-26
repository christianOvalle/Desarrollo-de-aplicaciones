using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticasASP.NET.Controllers
{
    public class NotasController : Controller
    {
        // GET: Notas
        public ActionResult NotasPromedio()
        {
            return View();
        }


        public string ReprobarOno(string nota1, string nota2, string nota3, string nota4)
        {

            int resultado = 0;
            string Aviso = "";


            if (nota1 == "" || nota2 == "" || nota3 == "" || nota4 == "")
            {

                Aviso = "No se pudo procesar";
            }

            else
            {
                resultado = (int.Parse(nota1) + int.Parse(nota2) + int.Parse(nota3) + int.Parse(nota4)) / 4;

                if (resultado >= 70)
                {
                    Aviso = $"A aprobado la materia con {resultado}";
                }
                else if (resultado <= 70)
                {
                    Aviso = $"A reprobado la materia con {resultado}";
                }

            }

            return Aviso;
        }

    }
}