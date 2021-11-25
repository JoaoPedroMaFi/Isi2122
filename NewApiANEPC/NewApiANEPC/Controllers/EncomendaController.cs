using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewApiANEPC.Controllers
{
    [Route("api/encomendas")]
    [ApiController]
    public class EncomendaController : Controller
    {
        // GET: EncomendaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EncomendaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EncomendaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EncomendaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EncomendaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EncomendaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EncomendaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EncomendaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
