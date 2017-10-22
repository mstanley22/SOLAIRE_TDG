﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Context;
using Models.Models;

namespace TDG_SOLAIRE.Controllers
{
    public class EmpresasController : Controller
    {
        private SolaireContext db = new SolaireContext();

        // GET: Empresas
        public async Task<ActionResult> Index()
        {
            return View(await db.Empresas.ToListAsync());
        }

        // GET: Empresas/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empresa empresa = await db.Empresas.FindAsync(id);
            if (empresa == null)
            {
                return HttpNotFound();
            }
            return View("Partials/Details", empresa);
        }

        // GET: Empresas/Create
        public ActionResult Create()
        {
            return View("Partials/Create");
        }

        // POST: Empresas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
       // [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Nombre,Siglas,Logo,Direccion,LastUpdate,ModifiedBy")] Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                db.Empresas.Add(empresa);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View("Partials/Create", empresa);
        }

        // GET: Empresas/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empresa empresa = await db.Empresas.FindAsync(id);
            if (empresa == null)
            {
                return HttpNotFound();
            }
            return View("Partials/Edit", empresa);
        }

        // POST: Empresas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Nombre,Siglas,Logo,Direccion,LastUpdate,ModifiedBy")] Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empresa).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View("Partials/Edit", empresa);
        }

        // GET: Empresas/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empresa empresa = await db.Empresas.FindAsync(id);
            if (empresa == null)
            {
                return HttpNotFound();
            }
            return View("Partials/Delete", empresa);
        }

        // POST: Empresas/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Empresa empresa = await db.Empresas.FindAsync(id);
            db.Empresas.Remove(empresa);
            await db.SaveChangesAsync();
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
