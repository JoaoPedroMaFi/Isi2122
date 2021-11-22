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
    public class encomendasController : Controller
    {
        private mydb_isiEntities db = new mydb_isiEntities();

        // GET: encomendas
        public async Task<ActionResult> Index()
        {
            var encomendas = db.encomendas.Include(e => e.equipa);
            return View(await encomendas.ToListAsync());
        }

        // GET: encomendas/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            encomenda encomenda = await db.encomendas.FindAsync(id);
            if (encomenda == null)
            {
                return HttpNotFound();
            }
            return View(encomenda);
        }

        // GET: encomendas/Create
        public ActionResult Create()
        {
            ViewBag.idequipa = new SelectList(db.equipas, "idequipa", "equipa_nome");
            return View();
        }

        // POST: encomendas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "idencomenda,idequipa,entregue")] encomenda encomenda)
        {
            if (ModelState.IsValid)
            {
                db.encomendas.Add(encomenda);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.idequipa = new SelectList(db.equipas, "idequipa", "equipa_nome", encomenda.idequipa);
            return View(encomenda);
        }

        // GET: encomendas/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            encomenda encomenda = await db.encomendas.FindAsync(id);
            if (encomenda == null)
            {
                return HttpNotFound();
            }
            ViewBag.idequipa = new SelectList(db.equipas, "idequipa", "equipa_nome", encomenda.idequipa);
            return View(encomenda);
        }

        // POST: encomendas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "idencomenda,idequipa,entregue")] encomenda encomenda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(encomenda).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.idequipa = new SelectList(db.equipas, "idequipa", "equipa_nome", encomenda.idequipa);
            return View(encomenda);
        }

        // GET: encomendas/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            encomenda encomenda = await db.encomendas.FindAsync(id);
            if (encomenda == null)
            {
                return HttpNotFound();
            }
            return View(encomenda);
        }

        // POST: encomendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            encomenda encomenda = await db.encomendas.FindAsync(id);
            db.encomendas.Remove(encomenda);
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
