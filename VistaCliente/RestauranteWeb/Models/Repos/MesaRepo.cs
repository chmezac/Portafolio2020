using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestauranteDatos;

namespace RestauranteWeb.Models.Repos
{
    public class MesaRepo
    {

        private RestauranteEntities context;

        public MesaRepo(RestauranteEntities _context)
        {
            this.context = _context;
        }

        public MesaRepo()
        {
            this.context = new RestauranteEntities();
        }

        public List<MESA> listMesas()
        {
            return this.context.MESA.Where(n => n.NUM_MESA > 0).ToList();
        }

        public bool InsertarMesa(MESA mesa)
        {
            try
            {
                context.INSERTMESA(mesa.NUM_MESA, mesa.ESTADO_MESA, mesa.CANT_PERSONAS);
                context.SaveChanges();

                return true;
            }
            catch
            {

                return false;
            }
        }

        public MESA buscarMesa(int num)
        {
            return this.context.MESA.Find(num);

        }

        public bool EditMesa(int id, MESA model)
        {
            try
            {
                MESA var = buscarMesa(id);
                if (var != null)
                {
                    var.ESTADO_MESA = model.ESTADO_MESA;
                    var.NUM_MESA = model.NUM_MESA;
                    var.CANT_PERSONAS = model.CANT_PERSONAS;
                    this.context.SaveChanges();
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch
            {

                return false;
            }
        }

        public bool buscarMesaBool(int num)
        {
            var res = this.context.MESA.Find(num);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool eliminarMesa(int num)
        {
            MESA user = this.buscarMesa(num);
            if (user != null)
            {
                this.context.MESA.Remove(user);
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