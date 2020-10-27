using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestauranteDatos;

namespace RestauranteWeb.Models.Repos
{
    public class PlatoRepo
    {

        private RestauranteEntities context;

        public PlatoRepo(RestauranteEntities _context)
        {
            this.context = _context;
        }

        public PlatoRepo()
        {
            this.context = new RestauranteEntities();
        }



        public List<RECETA> listarRecetas(int idPlato)
        {
            return this.context.RECETA.Where(n => n.PLATO_ID_PLATO == idPlato).ToList();
        }


        public List<PLATO> listarPlatos()
        {
            return this.context.PLATO.ToList();
        }

        public List<INSUMO> listarInsumos()
        {
            return this.context.INSUMO.ToList();
        }



        public bool insertarPlato(PLATO usuario)
        {
            try
            {

                context.INSERTPLATO(usuario.NOMBRE_PLATO, usuario.PRECIO_PLATO, usuario.DESCRIPCION_PLATO, usuario.TIEMPO_PREPARACION, usuario.TIPO_PLATO_ID_TIPO_PLATO);
                context.SaveChanges();

                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool insertarReceta(RECETA receta)
        {
            try
            {

                context.INSERTRECETA(receta.CANTIDAD_UTILIZAR, receta.DESCRIPCION_RECETA, receta.INSUMO_ID_INSUMO, receta.PLATO_ID_PLATO);
                context.SaveChanges();

                return true;
            }
            catch
            {

                return false;
            }
        }


        public PLATO buscarPlato(int idPlato)
        {
            return this.context.PLATO.Find(idPlato);

        }

        public RECETA buscarReceta(int idReceta)
        {

            return this.context.RECETA.Find(idReceta);

        }

        public bool buscarPlatoBool(int idPlato)
        {
            var res = this.context.PLATO.Find(idPlato);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public bool buscarRecetaBool(int idPlato)
        {
            var res = this.context.RECETA.Where(n => n.PLATO_ID_PLATO == idPlato).FirstOrDefault();
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool editarPlato(int id, PLATO model)
        {
            try
            {
                PLATO var = buscarPlato(id);
                if (var != null)
                {
                    var.NOMBRE_PLATO = model.NOMBRE_PLATO;
                    var.PRECIO_PLATO = model.PRECIO_PLATO;
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

        /*
        public USUARIO UsuarioViewToUsuario(UsuarioViewModel model)
        {
            USUARIO user = new USUARIO();
            user.RUT_USUARIO = model.RUT_USUARIO;
            user.NOMBRE_USUARIO = model.NOMBRE_USUARIO;
            user.APELLIDO_USUARIO = model.APELLIDO_USUARIO;
            user.EMAIL_USUARIO = model.EMAIL_USUARIO;
            user.PASSWORD = model.Password;
            user.ROL_ID_ROL = model.Rol;

            return user;
        }
        */

        public bool eliminarPLato(int idPlato)
        {
            PLATO user = this.buscarPlato(idPlato);
            if (user != null)
            {
                if (this.buscarRecetaBool(idPlato) == true)
                {
                    this.eliminarRecetaPlato(idPlato);
                    this.context.PLATO.Remove(user);
                    this.context.SaveChanges();
                    return true;
                }
                else
                {
                    this.context.PLATO.Remove(user);
                    this.context.SaveChanges();
                    return true;
                }
            }
            else
            {
                return false;
            }

        }

        public bool eliminarRecetaPlato(int id)
        {
            var var = this.context.RECETA.Where(n => n.PLATO_ID_PLATO == id).ToList();

            foreach (var item in var)
            {
                this.context.RECETA.Remove(item);
                this.context.SaveChanges();
            }
            return true;
        }


        public bool eliminarReceta(int id)
        {

            RECETA user = this.buscarReceta(id);
            if (user != null)
            {
                this.context.RECETA.Remove(user);
                this.context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<TIPO_PLATO> listarTipoPlatos()
        {
            return this.context.TIPO_PLATO.ToList();
        }










    }
}