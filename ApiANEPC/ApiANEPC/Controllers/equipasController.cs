using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ApiANEPC.Models;

namespace ApiANEPC.Controllers
{
    public class equipasController : Controller
    {
        private mydb_isiEntities db = new mydb_isiEntities();

        // GET: equipas
        public async Task<ActionResult> Index()
        {
            var equipas = db.equipas.Include(e => e.cidade);
            return View(await equipas.ToListAsync());
        }

        // GET: equipas/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            equipa equipa = await db.equipas.FindAsync(id);
            if (equipa == null)
            {
                return HttpNotFound();
            }
            return View(equipa);
        }

        // GET: equipas/Create
        public ActionResult Create()
        {
            ViewBag.idcidade = new SelectList(db.cidades, "idcidade", "cidade_nome");
            return View();
        }

        // POST: equipas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "idequipa,idcidade,equipa_nome")] equipa equipa)
        {
            if (ModelState.IsValid)
            {
                db.equipas.Add(equipa);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.idcidade = new SelectList(db.cidades, "idcidade", "cidade_nome", equipa.idcidade);
            return View(equipa);
        }

        // GET: equipas/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            equipa equipa = await db.equipas.FindAsync(id);
            if (equipa == null)
            {
                return HttpNotFound();
            }
            ViewBag.idcidade = new SelectList(db.cidades, "idcidade", "cidade_nome", equipa.idcidade);
            return View(equipa);
        }

        // POST: equipas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "idequipa,idcidade,equipa_nome")] equipa equipa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equipa).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.idcidade = new SelectList(db.cidades, "idcidade", "cidade_nome", equipa.idcidade);
            return View(equipa);
        }

        // GET: equipas/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            equipa equipa = await db.equipas.FindAsync(id);
            if (equipa == null)
            {
                return HttpNotFound();
            }
            return View(equipa);
        }

        // POST: equipas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            equipa equipa = await db.equipas.FindAsync(id);
            db.equipas.Remove(equipa);
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
