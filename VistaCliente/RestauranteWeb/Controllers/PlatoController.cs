using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestauranteDatos;
using RestauranteWeb.Models.Repos;
using RestauranteWeb.Models;
using System.IO;

namespace RestauranteWeb.Controllers
{
    public class PlatoController : Controller
    {


        private PlatoRepo context = new PlatoRepo();
        // GET: Plato
        public ActionResult Index()
        {
            return View(context.listarPlatos());
        }

        // GET: Plato/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.plato = this.context.buscarPlato(id);
            return View(context.listarRecetas(id));
        }

        // GET: Plato/Create
        public ActionResult Create()
        {
            List<SelectListItem> item = context.listarTipoPlatos().ConvertAll(tipo =>
            {
                return new SelectListItem()
                {
                    Text = tipo.NOMBRE_TIPO_PLATO,
                    Value = tipo.ID_TIPO_PLATO.ToString(),
                };
            });
            ViewBag.items = item;
            return View();
        }

        public ActionResult CreateReceta(int id)
        {
            ViewBag.plato = this.context.buscarPlato(id);

            List<SelectListItem> item = context.listarInsumos().ConvertAll(rol =>
            {
                return new SelectListItem()
                {
                    Text = rol.NOMBRE_INSUMO + " -" + rol.UNIDAD_MEDIDA_INSUMO,
                    Value = rol.ID_INSUMO.ToString(),
                };
            });
            ViewBag.items = item;
            return View();
        }

        [HttpPost]
        public ActionResult CreateReceta(RECETA model)
        {
            if (ModelState.IsValid)
            {
                if (context.insertarReceta(model))
                {
                    return RedirectToAction("Details", new { id = model.PLATO_ID_PLATO });
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Usuario ya existe");
                    return View(model);
                }

            }
            else
            {
                return View(model);
            }
        }
        // POST: Plato/Create
        [HttpPost]
        public ActionResult Create(PLATO model, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {

                if (context.insertarPlato(model))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Usuario ya existe");
                    return View(model);
                }

            }
            else
            {
                return View(model);
            }
        }


        // GET: Plato/Edit/5
        public ActionResult Edit(int id)
        {

            var var = this.context.buscarPlato(id);
            if (var != null)
            {
                List<SelectListItem> item = context.listarTipoPlatos().ConvertAll(tipo =>
                {
                    return new SelectListItem()
                    {
                        Text = tipo.NOMBRE_TIPO_PLATO,
                        Value = tipo.ID_TIPO_PLATO.ToString(),
                    };
                });
                ViewBag.items = item;
                return View(var);
            }
            else
            {
                return this.RedirectToAction("Index");
            }
        }

        // POST: Plato/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, PLATO model, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                bool edit = this.context.editarPlato(id, model);
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

        // GET: Plato/Delete/5
        public ActionResult Delete(int id)
        {
            if (this.context.eliminarPLato(id))
            {
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Error al eliminar usuario");
                return View("Index");
            }
        }

        public ActionResult DeleteReceta(int id)
        {
            int idInt = this.context.buscarReceta(id).PLATO_ID_PLATO;
            if (this.context.eliminarReceta(id))
            {

                return RedirectToAction("Details", new { id = idInt });
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Error al eliminar usuario");
                return View("Index");
            }
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