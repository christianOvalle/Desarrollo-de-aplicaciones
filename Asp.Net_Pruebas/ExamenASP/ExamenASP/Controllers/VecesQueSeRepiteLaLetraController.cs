using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenASP.Controllers
{
    public class VecesQueSeRepiteLaLetraController : Controller
    {
        // GET: VecesQueSeRepiteLaLetra
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Verificar() {

           // string[] arreglo = new string[ “Un héroe no es más valiente que cualquier otra persona, solamente es valiente cinco minutos más.”];

            //List<string> lista = new List<string>();

            string letra =  "Un héroe no es más valiente que cualquier otra persona,solamente es valiente cinco minuto más";
            int contador = 0;
            for (int i = 0; i < letra.Length; i++) {

                if (letra[i] == 'a') { 
                
                   contador++;
                    ViewBag.contador = contador; 
                }
            
            
            }
        return View();
        
        }

    }
}