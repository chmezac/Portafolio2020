using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestauranteDatos;
using RestauranteWeb.Models.Repos;


namespace RestauranteWeb.Controllers
{
    public class InsumoController : Controller
    {

        private InsumosRepo context = new InsumosRepo();
        // GET: Insumo
        public ActionResult Index()
        {
            return View(this.context.listarInsumos());
        }

        // GET: Insumo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Insumo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insumo/Create
        [HttpPost]
        public ActionResult Create(INSUMO model, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (context.insertarInsumo(model))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Insumo ya existe");
                    return View(model);
                }

            }
            else
            {
                return View(model);
            }
        }

        // GET: Insumo/Edit/5
        public ActionResult Edit(int id)
        {

            var var = this.context.buscarInsumo(id);
            if (var != null)
            {
                return View(var);
            }
            else
            {
                return this.RedirectToAction("Index");
            }
        }

        public ActionResult SolicitarInsumo(int id)
        {

            var var = this.context.buscarInsumo(id);
            if (var != null)
            {
                return View(var);
            }
            else
            {
                return this.RedirectToAction("Index");
            }
        }

        // POST: Insumo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, INSUMO model, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                bool edit = this.context.editarInsumo(id, model);
                if (edit != false)
                {

                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Error en editar la mesa");
                    return View(model);
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Error en editar la mesa");
                return View(model);
            }
        }

        // GET: Insumo/Delete/5
        public ActionResult Delete(int id)
        {
            if (this.context.eliminarInsumo(id))
            {
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Error al eliminar usuario");
                return View("Index");
            }
        }

        // POST: Insumo/Delete/5
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