using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExamenASP.Models;

namespace ExamenASP.Controllers
{
    public class tallersController : Controller
    {
        private db_CursosEntities db = new db_CursosEntities();

        // GET: tallers
        public ActionResult Index()
        {
            return View(db.tallers.ToList());
        }

        // GET: tallers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            taller taller = db.tallers.Find(id);
            if (taller == null)
            {
                return HttpNotFound();
            }
            return View(taller);
        }

        // GET: tallers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tallers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,NombreDeTaller")] taller taller)
        {
            if (ModelState.IsValid)
            {
                db.tallers.Add(taller);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(taller);
        }

        // GET: tallers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            taller taller = db.tallers.Find(id);
            if (taller == null)
            {
                return HttpNotFound();
            }
            return View(taller);
        }

        // POST: tallers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,NombreDeTaller")] taller taller)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taller).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(taller);
        }

        // GET: tallers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            taller taller = db.tallers.Find(id);
            if (taller == null)
            {
                return HttpNotFound();
            }
            return View(taller);
        }

        // POST: tallers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            taller taller = db.tallers.Find(id);
            db.tallers.Remove(taller);
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
