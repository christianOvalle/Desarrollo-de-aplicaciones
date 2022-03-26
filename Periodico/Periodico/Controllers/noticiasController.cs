using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Periodico.Models;

namespace Periodico.Controllers
{
    public class noticiasController : Controller
    {
        private db_periodicoEntities db = new db_periodicoEntities();

        // GET: noticias
        public ActionResult Index()
        {
            var noticias = db.noticias.Include(n => n.categoria);
            return View(noticias.ToList());
        }

        // GET: noticias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            noticia noticia = db.noticias.Find(id);
            if (noticia == null)
            {
                return HttpNotFound();
            }
            return View(noticia);
        }

        // GET: noticias/Create
        public ActionResult Create()
        {
            ViewBag.categoria_id = new SelectList(db.categorias, "id", "nombre");
            return View();
        }

        // POST: noticias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,categoria_id,titulo,detale_completo,detalle_corto,fecha,imagen,ruta_imagen")] noticia noticia)
        {
            if (ModelState.IsValid)
            {
                db.noticias.Add(noticia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.categoria_id = new SelectList(db.categorias, "id", "nombre", noticia.categoria_id);
            return View(noticia);
        }

        // GET: noticias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            noticia noticia = db.noticias.Find(id);
            if (noticia == null)
            {
                return HttpNotFound();
            }
            ViewBag.categoria_id = new SelectList(db.categorias, "id", "nombre", noticia.categoria_id);
            return View(noticia);
        }

        // POST: noticias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,categoria_id,titulo,detale_completo,detalle_corto,fecha,imagen,ruta_imagen")] noticia noticia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(noticia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.categoria_id = new SelectList(db.categorias, "id", "nombre", noticia.categoria_id);
            return View(noticia);
        }

        // GET: noticias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            noticia noticia = db.noticias.Find(id);
            if (noticia == null)
            {
                return HttpNotFound();
            }
            return View(noticia);
        }

        // POST: noticias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            noticia noticia = db.noticias.Find(id);
            db.noticias.Remove(noticia);
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
