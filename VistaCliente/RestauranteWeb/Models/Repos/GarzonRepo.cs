using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestauranteNegocio;
using RestauranteDatos;

namespace RestauranteWeb.Models.Repos
{
    public class GarzonRepo
    {

        private RestauranteEntities context;


        public GarzonRepo()
        {
            this.context = new RestauranteEntities();
        }


        public USUARIO buscarUsuario(string rut)
        {

            return this.context.USUARIO.Where(n => n.RUT_USUARIO == rut).FirstOrDefault();

        }



        public bool buscarUsuarioBool(string rut)
        {
            var res = this.context.USUARIO.Where(n => n.RUT_USUARIO == rut).FirstOrDefault();
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


     }
}