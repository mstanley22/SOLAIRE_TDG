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
    public class InsumosController : Controller
    {
        private SolaireContext db = new SolaireContext();

        // GET: Insumos
        public async Task<ActionResult> Index()
        {
            var insumos = db.Insumos.Include(i => i.InsumoUtilizado);
            return View(await insumos.ToListAsync());
        }

        // GET: Insumos/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insumo insumo = await db.Insumos.FindAsync(id);
            if (insumo == null)
            {
                return HttpNotFound();
            }
            return View(insumo);
        }

        // GET: Insumos/Create
        public ActionResult Create()
        {
            ViewBag.InsumoUtilizadoId = new SelectList(db.InsumoUtilizados, "Id", "Cantidad");
            return View();
        }

        // POST: Insumos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Nombre,UnidadMedida,Descripcion,Marca,PrecioUnitario,InsumoUtilizadoId,LastUpdate,ModifiedBy")] Insumo insumo)
        {
            if (ModelState.IsValid)
            {
                db.Insumos.Add(insumo);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.InsumoUtilizadoId = new SelectList(db.InsumoUtilizados, "Id", "Cantidad", insumo.InsumoUtilizadoId);
            return View(insumo);
        }

        // GET: Insumos/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insumo insumo = await db.Insumos.FindAsync(id);
            if (insumo == null)
            {
                return HttpNotFound();
            }
            ViewBag.InsumoUtilizadoId = new SelectList(db.InsumoUtilizados, "Id", "Cantidad", insumo.InsumoUtilizadoId);
            return View(insumo);
        }

        // POST: Insumos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Nombre,UnidadMedida,Descripcion,Marca,PrecioUnitario,InsumoUtilizadoId,LastUpdate,ModifiedBy")] Insumo insumo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insumo).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.InsumoUtilizadoId = new SelectList(db.InsumoUtilizados, "Id", "Cantidad", insumo.InsumoUtilizadoId);
            return View(insumo);
        }

        // GET: Insumos/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insumo insumo = await db.Insumos.FindAsync(id);
            if (insumo == null)
            {
                return HttpNotFound();
            }
            return View(insumo);
        }

        // POST: Insumos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Insumo insumo = await db.Insumos.FindAsync(id);
            db.Insumos.Remove(insumo);
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
