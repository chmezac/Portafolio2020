using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestauranteDatos;
using RestauranteNegocio;
using RestauranteWeb.Models.Repos;

namespace RestauranteWeb.Controllers
{
    public class ClienteController : Controller
    {

        private ClienteRepo context = new ClienteRepo();
        // GET: Cliente
        public ActionResult Index()
        {
            return View(context.listarClientes());
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(CLIENTE cliente)
        {
            if (ModelState.IsValid)
            {
                if (context.insertarCliente(cliente))
                {
                    return RedirectToAction("Cliente", "PedidoCliente");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Cliente ya existe");
                    return View(cliente);
                }

            }
            else
            {
                return View(cliente);
            }
        }


        // GET: Cliente/Edit/5
        public ActionResult Edit(string id)
        {
            var var = this.context.buscarCliente(id);

            if (var != null)
            {

                return View(var);
            }
            else
            {
                return this.RedirectToAction("Index");
            }
        }

        public ActionResult EditReserva(int id)
        {
            var var = this.context.buscarReserva(id);
            IEnumerable<SelectListItem> item = context.listMesas().Select(rol => new SelectListItem
            {
                Text = rol.NUM_MESA.ToString(),
                Value = rol.NUM_MESA.ToString()
            });
            ViewBag.items = item;
            if (var != null)
            {

                return View(var);
            }
            else
            {
                return this.RedirectToAction("Reservas");
            }
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, CLIENTE cliente)
        {
            if (ModelState.IsValid)
            {

                bool edit = this.context.editarCliente(id, cliente);
                if (edit != false)
                {

                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Error en editar la mesa");
                    return View(cliente);
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Error en editar la mesa");
                return View(cliente);
            }
        }

        [HttpPost]
        public ActionResult EditReserva(int id, RESERVA reserva)
        {
            if (ModelState.IsValid)
            {

                bool edit = this.context.editarReserva(id, reserva);
                if (edit != false)
                {

                    return RedirectToAction("Reservas");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Error en editar la mesa");
                    return View(reserva);
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Error en editar la mesa");
                return View(reserva);
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(string id)
        {
            if (this.context.eliminarCliente(id))
            {
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Error al eliminar cliente");
                return View("Index");
            }
        }

        public ActionResult DeleteReserva(int id)
        {
            if (this.context.eliminarReserva(id))
            {
                return RedirectToAction("Reservas");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Error al eliminar reserva");
                return View("Reservas");
            }
        }

        // POST: Cliente/Delete/5
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

        public ActionResult Reservas()
        {
            return View(context.listarReserva());
        }







    }
}