using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestauranteDatos;

namespace RestauranteWeb.Models.Repos
{
    public class RolRepo
    {

        private RestauranteEntities context;

        public RolRepo(RestauranteEntities _context)
        {
            this.context = _context;
        }

        public RolRepo()
        {
            this.context = new RestauranteEntities();
        }

        public List<ROL> listarRoles()
        {
            return this.context.ROL.ToList();
        }

        public bool insertarRol(ROL rol)
        {
            try
            {

                context.INSERTROL(rol.ID_ROL, rol.NOMBRE_ROL, rol.DESCRIPCION_ROL);
                context.SaveChanges();

                return true;
            }
            catch
            {

                return false;
            }
        }

        public ROL buscarRol(int idRol)
        {

            return this.context.ROL.Find(idRol);

        }

        public bool buscarRolBool(int idRol)
        {
            var res = this.context.ROL.Find(idRol);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool editarRool(int id, ROL model)
        {
            try
            {
                ROL var = buscarRol(id);
                if (var != null)
                {
                    var.NOMBRE_ROL = model.NOMBRE_ROL;
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
        }*/

        public bool eliminarRol(int idRol)
        {
            ROL user = this.buscarRol(idRol);
            if (user != null)
            {
                this.context.ROL.Remove(user);
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