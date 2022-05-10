using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Taller.Controllers
{
    public class FacturacionController : Controller
    {

        Models.db_TallerEntities1 db_TallerEntities = new Models.db_TallerEntities1();
        Models.Taller Taller = new Models.Taller();
        Models.Vehiculos Vh = new Models.Vehiculos();
        Models.Servicios sv = new Models.Servicios();
        
      

        // GET: Facturacion
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DatosFactura() {

            
            ViewBag.rncT= Taller.rnc;
            ViewBag.nombreT = Taller.nombre;
            ViewBag.direccionT = Taller.direccion;
            ViewBag.telefonoT = Taller.telefono;
            ViewBag.MarcaV = Vh.marca;
            ViewBag.ModeloV = Vh.modelo;
            ViewBag.ColorV = Vh.color;
            ViewBag.nombreS = sv.nombre;
            ViewBag.costoS= sv.costo.ToString();

            ViewBag.hola = "hola";
             
           
            return View();
        }


    }
}