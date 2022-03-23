using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Periodico.Controllers
{
    public class EnviarArchivosController : Controller
    {
        // GET: EnviarArchivos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RecibirUnArchivo(HttpPostedFileBase Archivo) {

            string ms = "";

            ms +=  Archivo.FileName + "_" + Archivo.ContentType + "_" + Archivo.ContentLength.ToString() + "|";
            Archivo.SaveAs(Server.MapPath("~/Content/Imagenes/") + Archivo.FileName);
        
        
            return Content("A sido Enviada");
        
        
        }

        public ActionResult Prueba() {

            return View();
        
        }

        public ActionResult VariosArchivos(List<HttpPostedFileBase> Archivos) {

            string msv = "";

            foreach (HttpPostedFileBase item in Archivos)
            {

                msv += item.FileName + "_" + item.ContentType + "_" + item.ContentLength.ToString() + "|";
                item.SaveAs(Server.MapPath("~/Content/Imagenes/") + item.FileName);



            }
            return Content("Listo");
        }


    }
}