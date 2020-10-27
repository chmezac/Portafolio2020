using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestauranteDatos;
using RestauranteWeb.Models;
using RestauranteWeb.Models.Repos;


namespace RestauranteWeb.Controllers
{
    public class MesaController : Controller
    {

        // GET: Mesa

        private MesaRepo context = new MesaRepo();


        public ActionResult Index()
        {
            return View(context.listMesas());
        }

        // GET: Mesa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mesa/Create
        [HttpPost]
        public ActionResult Create(MESA model)
        {
            if (ModelState.IsValid)
            {
                bool existe = context.buscarMesaBool(model.NUM_MESA);
                if (existe == false)
                {
                    bool res = this.context.InsertarMesa(model);

                    if (res != false)
                    {
                        return this.RedirectToAction("Index");
                    }
                    else
                    {
                        this.ModelState.AddModelError(string.Empty, "Error al insertar mesa");
                        return View(model);
                    }
                }
                else
                {
                    this.ModelState.AddModelError(string.Empty, "Numero de mesa ya existe");
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }

        // GET: Mesa/Edit/5
        public ActionResult Edit(int id)
        {

            var var = this.context.buscarMesa(id);
            if (var != null)
            {
                return View(var);
            }
            else
            {
                return this.RedirectToAction("Index");
            }

        }


        // POST: Mesa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, MESA model)
        {

            if (ModelState.IsValid)
            {
                bool edit = this.context.EditMesa(id, model);
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

        // GET: Mesa/Delete/5
        public ActionResult Delete(int id)
        {
            if (this.context.eliminarMesa(id))
            {
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Error al eliminar usuario");
                return View("Index");
            }
        }

        // POST: Mesa/Delete/5
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