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
    public class PedidoClienteController : Controller
    {


        private PedidoClienteRepo context = new PedidoClienteRepo();
        // GET: PedidoCliente
        public ActionResult Index()
        {
            if (Session["idcliente"] != null)
            {
                return View(context.listarPlatos());
            }
            else
            {
                return RedirectToAction("Cliente");
            }
        }

        public ActionResult Pedidos()
        {
            if (Session["idcliente"] != null)
            {
                return View(context.listarPedidos());
            }
            else
            {
                return RedirectToAction("Cliente");
            }
        }

        public ActionResult pedirCuenta()
        {
            if (Session["idcliente"] != null)
            {
                int idCliente = Convert.ToInt32(Session["idcliente"]);
                if (context.pedirCuenta(idCliente))
                {
                    return RedirectToAction("Pedidos");
                }
                else
                {

                    return RedirectToAction("index");
                }

            }
            else
            {
                return RedirectToAction("Cliente");
            }
        }

        // GET: PedidoCliente/Create
        public ActionResult Create(int id)
        {
            CarroDeCompras carrito = CarroDeCompras.CapturarProducto();
            carrito.Agregar(id);

            return RedirectToAction("Index");
        }

        public ActionResult Carro()
        {
            if (Session["idcliente"] != null)
            {
                List<SelectListItem> item = context.listMesas().ConvertAll(mesa =>
                {
                    return new SelectListItem()
                    {
                        Text = "Mesa N° " + mesa.NUM_MESA,
                        Value = mesa.NUM_MESA.ToString()
                    };
                });
                ViewBag.items = item;
                return View(CarroDeCompras.CapturarProducto().ListaProductos);
            }
            else
            {
                return RedirectToAction("Cliente");
            }


        }

        // POST: PedidoCliente/Create
        [HttpPost]
        public ActionResult Carro(PEDIDO_PLATOS collection, string idMesa)
        {
            try
            {
                int idCliente = Convert.ToInt32(Session["idcliente"]); ;
                PEDIDO ped = new PEDIDO();
                ped.CLIENTE_ID_CLIENTE = idCliente;
                ped.ESTADO_PEDIDO = 0;
                ped.FECHA_PEDIDO = DateTime.Now;
                ped.MESA_NUM_MESA = Convert.ToInt16(idMesa);
                context.insertarPedido(ped);
                List<PEDIDO_PLATOS> platos = CarroDeCompras.CapturarProducto().ListaProductos;

                foreach (var item in platos)
                {
                    item.PEDIDO_ID_PEDIDO = context.buscarIdPedido(idCliente);
                    this.context.insertarPedidoPlatos(item);
                }
                System.Web.HttpContext.Current.Session.Remove("ASPCarroDeCompras");
                return RedirectToAction("index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Cliente()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Cliente(CLIENTE cliente)
        {
            if (ModelState.IsValid)
            {
                CLIENTE cl = new CLIENTE();
                cl = context.buscarCliente(cliente.RUT_CLIENTE);
                if (cl == null)
                {
                    cliente.CORREO_CLIENTE = "No existe correo";
                    cliente.TELEFONO_CLIENTE = 0;
                    context.insertarCliente(cliente);
                    cl = context.buscarCliente(cliente.RUT_CLIENTE);

                }
                   System.Web.HttpContext.Current.Session["idcliente"] = cl.ID_CLIENTE;
                   System.Web.HttpContext.Current.Session["nombre"] = cl.NOMBRE_CLIENTE; 
                return RedirectToAction("Index");
            }
            else
            {
                return View(cliente);
            }
        }

        public ActionResult Sumar(int id)
        {
            CarroDeCompras.CapturarProducto().sumar(id);
            return RedirectToAction("Carro");
        }

        public ActionResult Restar(int id)
        {
            CarroDeCompras.CapturarProducto().restar(id);
            return RedirectToAction("Carro");
        }

        // GET: PedidoCliente/Delete/5
        public ActionResult Delete(int id)
        {
            CarroDeCompras.CapturarProducto().EliminarProductos(id);
            return RedirectToAction("Carro");
        }

        // POST: PedidoCliente/Delete/5
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

        public ActionResult SingOut()
        {
            System.Web.HttpContext.Current.Session.Remove("idcliente");
            System.Web.HttpContext.Current.Session.Remove("nombre");
            return this.RedirectToAction("cliente");

        }












    }
}