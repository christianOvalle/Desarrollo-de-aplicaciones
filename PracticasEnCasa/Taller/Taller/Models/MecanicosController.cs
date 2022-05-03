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
    public class MecanicosController : Controller
    {
        private db_TallerEntities db = new db_TallerEntities();

        // GET: Mecanicos
        public ActionResult Index()
        {
            var mecanicos = db.Mecanicos.Include(m => m.Taller);
            return View(mecanicos.ToList());
        }

        // GET: Mecanicos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mecanicos mecanicos = db.Mecanicos.Find(id);
            if (mecanicos == null)
            {
                return HttpNotFound();
            }
            return View(mecanicos);
        }

        // GET: Mecanicos/Create
        public ActionResult Create()
        {
            ViewBag.id_taller_mecanico = new SelectList(db.Taller, "id_taller", "rnc");
            return View();
        }

        // POST: Mecanicos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_mecanico,id_taller_mecanico,nombre,apellido,cedula,fecha_nacimiento,estatus")] Mecanicos mecanicos)
        {
            if (ModelState.IsValid)
            {
                db.Mecanicos.Add(mecanicos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_taller_mecanico = new SelectList(db.Taller, "id_taller", "rnc", mecanicos.id_taller_mecanico);
            return View(mecanicos);
        }

        // GET: Mecanicos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mecanicos mecanicos = db.Mecanicos.Find(id);
            if (mecanicos == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_taller_mecanico = new SelectList(db.Taller, "id_taller", "rnc", mecanicos.id_taller_mecanico);
            return View(mecanicos);
        }

        // POST: Mecanicos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_mecanico,id_taller_mecanico,nombre,apellido,cedula,fecha_nacimiento,estatus")] Mecanicos mecanicos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mecanicos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_taller_mecanico = new SelectList(db.Taller, "id_taller", "rnc", mecanicos.id_taller_mecanico);
            return View(mecanicos);
        }

        // GET: Mecanicos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mecanicos mecanicos = db.Mecanicos.Find(id);
            if (mecanicos == null)
            {
                return HttpNotFound();
            }
            return View(mecanicos);
        }

        // POST: Mecanicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mecanicos mecanicos = db.Mecanicos.Find(id);
            db.Mecanicos.Remove(mecanicos);
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
