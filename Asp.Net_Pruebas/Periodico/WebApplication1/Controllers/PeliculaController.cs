using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class PeliculaController : Controller
    {
        // GET: Pelicula
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Movies() {
            List<string> peliculas = new List<string>();
            peliculas.Add("Volver al futuro 1");
            peliculas.Add("Volver al futuro 2");
            peliculas.Add("Volver al futuro 3");

            return View(peliculas);
        }
    }
}