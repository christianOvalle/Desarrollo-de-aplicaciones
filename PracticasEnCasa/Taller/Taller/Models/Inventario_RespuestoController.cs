using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Taller.Models
{
    public class Inventario_RespuestoController : Controller
    {
        private db_TallerEntities db = new db_TallerEntities();

        // GET: Inventario_Respuesto
        public ActionResult Index()
        {
            return View(db.Inventario_Respuesto.ToList());
        }

        // GET: Inventario_Respuesto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventario_Respuesto inventario_Respuesto = db.Inventario_Respuesto.Find(id);
            if (inventario_Respuesto == null)
            {
                return HttpNotFound();
            }
            return View(inventario_Respuesto);
        }

        // GET: Inventario_Respuesto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Inventario_Respuesto/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre_pieza,cantidad_pieza,precio_pieza,cantidad_disponible,estado_piezas")] Inventario_Respuesto inventario_Respuesto)
        {
            if (ModelState.IsValid)
            {
                db.Inventario_Respuesto.Add(inventario_Respuesto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(inventario_Respuesto);
        }

        // GET: Inventario_Respuesto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventario_Respuesto inventario_Respuesto = db.Inventario_Respuesto.Find(id);
            if (inventario_Respuesto == null)
            {
                return HttpNotFound();
            }
            return View(inventario_Respuesto);
        }

        // POST: Inventario_Respuesto/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre_pieza,cantidad_pieza,precio_pieza,cantidad_disponible,estado_piezas")] Inventario_Respuesto inventario_Respuesto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inventario_Respuesto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(inventario_Respuesto);
        }

        // GET: Inventario_Respuesto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inventario_Respuesto inventario_Respuesto = db.Inventario_Respuesto.Find(id);
            if (inventario_Respuesto == null)
            {
                return HttpNotFound();
            }
            return View(inventario_Respuesto);
        }

        // POST: Inventario_Respuesto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Inventario_Respuesto inventario_Respuesto = db.Inventario_Respuesto.Find(id);
            db.Inventario_Respuesto.Remove(inventario_Respuesto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
