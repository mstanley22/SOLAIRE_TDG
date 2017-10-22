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
    public class DepartamentosController : Controller
    {
        private SolaireContext db = new SolaireContext();

        // GET: Departamentos
        public async Task<ActionResult> Index()
        {
            var departamentos = db.Departamentos.Include(d => d.Empresa).Include(d => d.Encargado);
            return View(await departamentos.ToListAsync());
        }

        // GET: Departamentos/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Departamento departamento = await db.Departamentos.FindAsync(id);
            if (departamento == null)
            {
                return HttpNotFound();
            }
            return View("Partials/Details", departamento);            
        }

        // GET: Departamentos/Create
        public ActionResult Create()
        {
            ViewBag.EmpresaId = new SelectList(db.Empresas, "Id", "Nombre");
            ViewBag.EncargadoId = new SelectList(db.Empleados, "Id", "Nombres");          
            return View("Partials/Create");
        }

        // POST: Departamentos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Nombre,EncargadoId,EmpresaId,LastUpdate,ModifiedBy")] Departamento departamento)
        {
            if (ModelState.IsValid)
            {
                db.Departamentos.Add(departamento);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.EmpresaId = new SelectList(db.Empresas, "Id", "Nombre", departamento.EmpresaId);
            ViewBag.EncargadoId = new SelectList(db.Empleados, "Id", "Nombres", departamento.EncargadoId);
            return View("Partials/Create", departamento);
        }

        // GET: Departamentos/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Departamento departamento = await db.Departamentos.FindAsync(id);
            if (departamento == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmpresaId = new SelectList(db.Empresas, "Id", "Nombre", departamento.EmpresaId);
            ViewBag.EncargadoId = new SelectList(db.Empleados, "Id", "Nombres", departamento.EncargadoId);
            return View("Partials/Edit", departamento);
        }

        // POST: Departamentos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Nombre,EncargadoId,EmpresaId,LastUpdate,ModifiedBy")] Departamento departamento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(departamento).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.EmpresaId = new SelectList(db.Empresas, "Id", "Nombre", departamento.EmpresaId);
            ViewBag.EncargadoId = new SelectList(db.Empleados, "Id", "Nombres", departamento.EncargadoId);
            return View("Partials/Edit", departamento);
        }

        // GET: Departamentos/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Departamento departamento = await db.Departamentos.FindAsync(id);
            if (departamento == null)
            {
                return HttpNotFound();
            }
            return View("Partials/Delete", departamento);
        }

        // POST: Departamentos/Delete/5
        [HttpPost, ActionName("Delete")]
       // [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Departamento departamento = await db.Departamentos.FindAsync(id);
            db.Departamentos.Remove(departamento);
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
