using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestauranteDatos;

namespace RestauranteWeb.Models.Repos
{
    public class PedidoClienteRepo
    {

        private RestauranteEntities context;

        public PedidoClienteRepo(RestauranteEntities _context)
        {
            this.context = _context;
        }

        public PedidoClienteRepo()
        {
            this.context = new RestauranteEntities();
        }


        public List<PLATO> listarPlatos()
        {
            return this.context.PLATO.ToList();
        }

        public bool pedirCuenta(int id)
        {
            try
            {
                PEDIDO ped = this.context.PEDIDO.Where(n => n.ESTADO_PEDIDO == 1 && n.CLIENTE.ID_CLIENTE == id).FirstOrDefault();
                if (ped != null)
                {
                    ped.ESTADO_PEDIDO = 1;
                    this.context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<PEDIDO_PLATOS> listarPedidos()
        {
            return this.context.PEDIDO_PLATOS.Where(n => n.PEDIDO.ESTADO_PEDIDO != 3).ToList();
        }

        public List<MESA> listMesas()
        {
            return this.context.MESA.Where(n => n.ESTADO_MESA == 0).ToList();
        }

        public bool insertarCliente(CLIENTE cliente)
        {
            try
            {
                context.INSERTCLIENTE(cliente.RUT_CLIENTE, cliente.PASSWORD_CLIENTE, cliente.NOMBRE_CLIENTE, cliente.APELLIDO_CLIENTE, cliente.CORREO_CLIENTE, cliente.TELEFONO_CLIENTE);
                context.SaveChanges();

                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool insertarPedido(PEDIDO pedido)
        {
            try
            {
                context.INSERTPEDIDO(pedido.FECHA_PEDIDO, pedido.ESTADO_PEDIDO, pedido.MESA_NUM_MESA, pedido.CLIENTE_ID_CLIENTE);
                context.SaveChanges();

                return true;
            }
            catch
            {

                return false;
            }
        }


        public bool insertarPedidoPlatos(PEDIDO_PLATOS pedido)
        {
            try
            {

                context.INSERTPEDIDOPLATOS(pedido.PEDIDO_ID_PEDIDO, pedido.PLATO_ID_PLATO, pedido.CANTIDAD);
                context.SaveChanges();

                return true;
            }
            catch
            {

                return false;
            }
        }


        public CLIENTE buscarCliente(string rut)
        {

            return this.context.CLIENTE.Where(n => n.RUT_CLIENTE == rut).FirstOrDefault();

        }

        public int buscarIdPedido(int id)
        {

            var var = this.context.PEDIDO.Where(n => n.CLIENTE_ID_CLIENTE == id).FirstOrDefault();
            return var.ID_PEDIDO;

        }

        public bool buscarClienteBool(string rut)
        {
            var res = this.context.CLIENTE.Where(n => n.RUT_CLIENTE == rut).FirstOrDefault();
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public MESA buscarMesa(int num)
        {
            return this.context.MESA.Find(num);

        }

















    }
}