using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestauranteNegocio;
using RestauranteDatos;

namespace RestauranteWeb.Models.Repos
{
    public class ClienteRepo
    {

        private RestauranteEntities context;

        public ClienteRepo(RestauranteEntities _context)
        {
            this.context = _context;
        }

        public ClienteRepo()
        {
            this.context = new RestauranteEntities();
        }

        public List<MESA> listMesas()
        {
            return this.context.MESA.Where(n => n.NUM_MESA > 0).ToList();
        }

        public List<CLIENTE> listarClientes()
        {
            return this.context.CLIENTE.ToList();
        }

        public List<RESERVA> listarReserva()
        {
            return this.context.RESERVA.ToList();
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

        public CLIENTE buscarCliente(string rut)
        {

            return this.context.CLIENTE.Where(n => n.RUT_CLIENTE == rut).FirstOrDefault();

        }

        public RESERVA buscarReserva(int id)
        {

            return this.context.RESERVA.Where(n => n.ID_RESERVA == id).FirstOrDefault();

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

        public bool editarCliente(string rut, CLIENTE model)
        {
            try
            {
                CLIENTE var = buscarCliente(rut);
                if (var != null)
                {
                    var.NOMBRE_CLIENTE = model.NOMBRE_CLIENTE;
                    var.APELLIDO_CLIENTE = model.APELLIDO_CLIENTE;
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

                return false;
            }
        }

        public bool editarReserva(int id, RESERVA model)
        {
            try
            {
                RESERVA var = buscarReserva(id);
                if (var != null)
                {
                    var.ESTADO_RESERVA = model.ESTADO_RESERVA;
                    var.MESA_NUM_MESA = model.MESA_NUM_MESA;
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

                return false;
            }
        }


        public bool eliminarCliente(string rut)
        {
            CLIENTE user = this.buscarCliente(rut);
            if (user != null)
            {
                this.context.CLIENTE.Remove(user);
                this.context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool eliminarReserva(int id)
        {
            RESERVA user = this.buscarReserva(id);
            if (user != null)
            {
                this.context.RESERVA.Remove(user);
                this.context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}