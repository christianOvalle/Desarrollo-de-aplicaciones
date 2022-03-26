﻿using System;
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
    public class AulasController : Controller
    {
        private db_CursosEntities db = new db_CursosEntities();

        // GET: Aulas
        public ActionResult Index()
        {
            var aulas = db.Aulas.Include(a => a.taller);
            return View(aulas.ToList());
        }

        // GET: Aulas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aula aula = db.Aulas.Find(id);
            if (aula == null)
            {
                return HttpNotFound();
            }
            return View(aula);
        }

        // GET: Aulas/Create
        public ActionResult Create()
        {
            ViewBag.taller_id = new SelectList(db.tallers, "id", "NombreDeTaller");
            return View();
        }

        // POST: Aulas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,taller_id,NombreAula,TipoAula,CantidadDeEstudiante")] Aula aula)
        {
            if (ModelState.IsValid)
            {
                db.Aulas.Add(aula);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.taller_id = new SelectList(db.tallers, "id", "NombreDeTaller", aula.taller_id);
            return View(aula);
        }

        // GET: Aulas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aula aula = db.Aulas.Find(id);
            if (aula == null)
            {
                return HttpNotFound();
            }
            ViewBag.taller_id = new SelectList(db.tallers, "id", "NombreDeTaller", aula.taller_id);
            return View(aula);
        }

        // POST: Aulas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,taller_id,NombreAula,TipoAula,CantidadDeEstudiante")] Aula aula)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aula).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.taller_id = new SelectList(db.tallers, "id", "NombreDeTaller", aula.taller_id);
            return View(aula);
        }

        // GET: Aulas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aula aula = db.Aulas.Find(id);
            if (aula == null)
            {
                return HttpNotFound();
            }
            return View(aula);
        }

        // POST: Aulas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Aula aula = db.Aulas.Find(id);
            db.Aulas.Remove(aula);
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

        public ActionResult MostrarCursos() { 
        
            List<Aula> aulaLista = new List<Aula>();
           
            aulaLista = db.Aulas.ToList();
            
           return View(aulaLista);
            

        }

    }
}
