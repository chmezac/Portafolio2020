using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestauranteDatos;


namespace RestauranteWeb.Models.Repos
{
    public class UsuarioRepo
    {

        private RestauranteEntities context;

        public UsuarioRepo(RestauranteEntities _context)
        {
            this.context = _context;
        }

        public UsuarioRepo()
        {
            this.context = new RestauranteEntities();
        }

        public List<USUARIO> listarUsuarios()
        {
            return this.context.USUARIO.ToList();
        }

        public List<ROL> listarRoles()
        {
            return this.context.ROL.ToList();
        }

        public bool insertarUsuario(USUARIO usuario)
        {
            try
            {
                context.INSERTUSUARIO(usuario.RUT_USUARIO, usuario.NOMBRE_USUARIO, usuario.APELLIDO_USUARIO, usuario.EMAIL_USUARIO, usuario.PASSWORD_USUARIO,usuario.ROL_ID_ROL);
                context.SaveChanges();

                return true;
            }
            catch
            {

                return false;
            }
        }

        public USUARIO buscarUsuario(int idUser)
        {
            return this.context.USUARIO.Find(idUser);
        }

        public bool buscarUsuarioBool(int idUser)
        {
            var res = this.context.USUARIO.Find(idUser);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool editarUsuario(int id, USUARIO model)
        {
            try
            {
                USUARIO var = buscarUsuario(id);
                if (var != null)
                {
                    var.RUT_USUARIO = model.RUT_USUARIO;
                    var.NOMBRE_USUARIO = model.NOMBRE_USUARIO;
                    var.APELLIDO_USUARIO = model.APELLIDO_USUARIO;
                    var.EMAIL_USUARIO = model.EMAIL_USUARIO;
                    var.PASSWORD_USUARIO = model.PASSWORD_USUARIO;
                    var.ROL_ID_ROL = model.ROL_ID_ROL;
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

        public bool eliminarUsuario(int idUser)
        {
            USUARIO user = this.buscarUsuario(idUser);
            if (user != null)
            {
                this.context.USUARIO.Remove(user);
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