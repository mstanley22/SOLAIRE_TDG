using System;
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
    public class PeriodosController : Controller
    {
        private SolaireContext db = new SolaireContext();

        // GET: Periodos
        public async Task<ActionResult> Index()
        {
            return View(await db.Periodos.ToListAsync());
        }

        // GET: Periodos/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Periodo periodo = await db.Periodos.FindAsync(id);
            if (periodo == null)
            {
                return HttpNotFound();
            }
            return View("Partials/Details", periodo);
        }

        // GET: Periodos/Create
        public ActionResult Create()
        {
            return View("Partials/Create");
        }

        // POST: Periodos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
       // [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,FechaInicio,FechaFin,LastUpdate,ModifiedBy")] Periodo periodo)
        {
            if (ModelState.IsValid)
            {
                db.Periodos.Add(periodo);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View("Partials/Create", periodo);
        }

        // GET: Periodos/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Periodo periodo = await db.Periodos.FindAsync(id);
            if (periodo == null)
            {
                return HttpNotFound();
            }
            return View("Partials/Edit", periodo);
        }

        // POST: Periodos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,FechaInicio,FechaFin,LastUpdate,ModifiedBy")] Periodo periodo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(periodo).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View("Partials/Edit", periodo);
        }

        // GET: Periodos/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Periodo periodo = await db.Periodos.FindAsync(id);
            if (periodo == null)
            {
                return HttpNotFound();
            }
            return View("Partials/Delete", periodo);
        }

        // POST: Periodos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Periodo periodo = await db.Periodos.FindAsync(id);
            db.Periodos.Remove(periodo);
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
