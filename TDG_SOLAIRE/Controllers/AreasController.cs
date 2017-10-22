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
    public class AreasController : Controller
    {
        private SolaireContext db = new SolaireContext();

        // GET: Areas
        public async Task<ActionResult> Index()
        {
            var areas = db.Areas.Include(a => a.Departamento).Include(a => a.Encargado);
            return View(await areas.ToListAsync());
        }

        // GET: Areas/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Area area = await db.Areas.FindAsync(id);
            if (area == null)
            {
                return HttpNotFound();
            }
            return View("Partials/Details", area);
        }

        // GET: Areas/Create
        public ActionResult Create()
        {
            ViewBag.DeparatmentoId = new SelectList(db.Departamentos, "Id", "Nombre");
            ViewBag.EncargadoId = new SelectList(db.Empleados, "Id", "Nombres");
            //return View();      
                return View("Partials/Create");

        }

        // POST: Areas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Nombre,DeparatmentoId,EncargadoId,LastUpdate,ModifiedBy")] Area area)
        {
            if (ModelState.IsValid)
            {
                db.Areas.Add(area);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.DeparatmentoId = new SelectList(db.Departamentos, "Id", "Nombre", area.DeparatmentoId);
            ViewBag.EncargadoId = new SelectList(db.Empleados, "Id", "Nombres", area.EncargadoId);
            return View("Partials/Create", area);
        }

        // GET: Areas/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Area area = await db.Areas.FindAsync(id);
            if (area == null)
            {
                return HttpNotFound();
            }
            ViewBag.DeparatmentoId = new SelectList(db.Departamentos, "Id", "Nombre", area.DeparatmentoId);
            ViewBag.EncargadoId = new SelectList(db.Empleados, "Id", "Nombres", area.EncargadoId);
            return View("Partials/Edit", area);
        }

        // POST: Areas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Nombre,DeparatmentoId,EncargadoId,LastUpdate,ModifiedBy")] Area area)
        {
            if (ModelState.IsValid)
            {
                db.Entry(area).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.DeparatmentoId = new SelectList(db.Departamentos, "Id", "Nombre", area.DeparatmentoId);
            ViewBag.EncargadoId = new SelectList(db.Empleados, "Id", "Nombres", area.EncargadoId);
            return View("Partials/Edit", area);
        }

        // GET: Areas/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Area area = await db.Areas.FindAsync(id);
            if (area == null)
            {
                return HttpNotFound();
            }
            return View(area);
        }

        // POST: Areas/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Area area = await db.Areas.FindAsync(id);
            db.Areas.Remove(area);
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
