using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestauranteNegocio;

namespace RestauranteWeb.Controllers
{

    [Authorize]

    public class PlatoController : Controller
    {
        // GET: Plato
        public ActionResult Index()
        {
            ViewBag.platos = new Plato().ReadAll();
            return View();
        }

        // GET: Plato/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Plato/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Plato/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Plato/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Plato/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Plato/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Plato/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
