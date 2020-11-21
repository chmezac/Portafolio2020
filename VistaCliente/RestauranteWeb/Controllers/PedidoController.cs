using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestauranteWeb.Models.Repos;

namespace RestauranteWeb.Controllers
{
    public class PedidoController : Controller
    {

        // GET: Pedido
        private PedidoRepo context = new PedidoRepo();

        public ActionResult Index()
        {
            return View(context.listarPedidos());
        }

        // GET: Pedido/Details/5
        public ActionResult Details(int id)
        {
            this.ViewBag.id = id;
            return View(this.context.listarPedidosFull(id));
        }

        // GET: Pedido/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult CambiarEstadoPedido(int id)
        {

            if (this.context.editarPedido(id, 1))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }

        // POST: Pedido/Create
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

        // GET: Pedido/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pedido/Edit/5
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

        // GET: Pedido/Delete/5
        public ActionResult Delete(int id)
        {
            this.context.eliminarPedido(id);
            return RedirectToAction("Index");
        }

        // POST: Pedido/Delete/5
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