using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestauranteDatos;
using RestauranteWeb.Models.Repos;


namespace RestauranteWeb.Controllers
{
    public class RolController : Controller
    {


        // GET: Rol
        private RolRepo context = new RolRepo();


        public ActionResult Index()
        {
            return View(context.listarRoles());
        }

        // GET: Rol/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rol/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rol/Create
        [HttpPost]
        public ActionResult Create(ROL model)
        {
            if (ModelState.IsValid)
            {

                if (context.insertarRol(model))
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

        // GET: Rol/Edit/5
        public ActionResult Edit(int id)
        {
            var var = this.context.buscarRol(id);
            if (var != null)
            {
                return View(var);
            }
            else
            {
                return this.RedirectToAction("Index");
            }
        }

        // POST: Rol/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ROL rol)
        {

            if (ModelState.IsValid)
            {
                bool edit = this.context.editarRool(id, rol);
                if (edit != false)
                {

                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Error en editar la mesa");
                    return View(rol);
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Error en editar la mesa");
                return View(rol);
            }
        }

        // GET: Rol/Delete/5
        public ActionResult Delete(int id)
        {
            if (this.context.eliminarRol(id))
            {
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Error al eliminar usuario");
                return View("Index");
            }
        }

        // POST: Rol/Delete/5
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