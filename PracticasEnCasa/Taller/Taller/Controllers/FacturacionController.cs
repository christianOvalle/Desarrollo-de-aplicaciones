using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Taller.Controllers
{
    public class FacturacionController : Controller
    {

        Models.db_TallerEntities db_TallerEntities = new Models.db_TallerEntities();
        Models.Taller Taller = new Models.Taller();
        Models.Vehiculos Vh = new Models.Vehiculos();
        Models.Servicios sv = new Models.Servicios();



        // GET: Facturacion
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DatosFactura(string rnc_Taller,string vehi_modelo, string vehi_marca, string vehi_color, string nombre_servicio, string nombre_taller, string direccion_taller, string telefono_taller, string costo_trabajo) {

            rnc_Taller = Taller.rnc;
            nombre_taller = Taller.nombre;
            direccion_taller = Taller.direccion;
            telefono_taller = Taller.telefono;
            vehi_marca = Vh.marca;
            vehi_modelo = Vh.modelo;
            vehi_color = Vh.color;
            nombre_servicio = sv.nombre;
            costo_trabajo = sv.costo;

            List<Models.Facturacion> fac = new List<Models.Facturacion>();
            fac = db_TallerEntities.Facturacion.ToList();


            return View(fac);
        }


    }
}