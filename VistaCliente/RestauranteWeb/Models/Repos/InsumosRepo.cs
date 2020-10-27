using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestauranteDatos;

namespace RestauranteWeb.Models.Repos
{
    public class InsumosRepo
    {

        private RestauranteEntities context;

        public InsumosRepo(RestauranteEntities _context)
        {
            this.context = _context;
        }

        public InsumosRepo()
        {
            this.context = new RestauranteEntities();
        }

        public List<INSUMO> listarInsumos()
        {
            return this.context.INSUMO.ToList();
        }

        public List<PEDIDO_INSUMO> listarPedidosInsumos()
        {
            return this.context.PEDIDO_INSUMO.ToList();
        }


        //public bool marcarPedidoComprado(int id)
        //{
         //   PEDIDO_INSUMO ped = this.context.PEDIDO_INSUMO.Where(n => n.ID_PEDIDO_INSUMO == id).FirstOrDefault();
          //  INSUMO ins = this.context.INSUMO.Where(n => n.ID_INSUMO == ped.INSUMO_ID_INSUMO).FirstOrDefault();
           // if (ins != null)
           // {
             //   ins.STOCK_INSUMO = ins.STOCK_INSUMO + ped.CANTIDAD; 
              //  this.context.PEDIDO_INSUMO.Remove(ped);
              //  this.context.SaveChanges();
              //  return true;
           // }
            //else
           // {
             //   return false;
            //
            // }




            //ARREGLAR ESTO
       // public bool insertPedidoInsumo(int id, INSUMO insumo)
       // {
        //    try
         //   {
          //      INSUMO ins = this.context.INSUMO.Where(n => n.ID_INSUMO == id).FirstOrDefault();
           //     if (ins != null)
           //     {
            //        context.INSERTPEDIDOINSUMO(ins.ID_INSUMO, ins.NOMBRE_INSUMO, ins.STOCK_INSUMO, ins.UNIDAD_MEDIDA_INSUMO);
             //       context.SaveChanges();
             //       return true;
              //  }
               // else
               // {
               //     return false;
               // }
               
            //}
            //catch
            //{

             //   return false;
            //}
        //}

        public bool insertarInsumo(INSUMO insumo)
        {
            try
            {
                context.INSERTINSUMO(insumo.NOMBRE_INSUMO, insumo.STOCK_INSUMO, insumo.UNIDAD_MEDIDA_INSUMO,insumo.PRECIO_INSUMO);
                context.SaveChanges();

                return true;
            }
            catch
            {

                return false;
            }
        }

        public INSUMO buscarInsumo(int idUser)
        {
            return this.context.INSUMO.Find(idUser);
        }

        public bool buscarInsumoBool(int idUser)
        {
            var res = this.context.INSUMO.Find(idUser);
            if (res != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool editarInsumo(int id, INSUMO model)
        {
            try
            {
                INSUMO var = buscarInsumo(id);
                if (var != null)
                {
                    var.NOMBRE_INSUMO = model.NOMBRE_INSUMO;
                    var.STOCK_INSUMO = model.STOCK_INSUMO;
                    var.UNIDAD_MEDIDA_INSUMO = model.UNIDAD_MEDIDA_INSUMO;
                    var.PRECIO_INSUMO = model.PRECIO_INSUMO;
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
        public bool eliminarInsumo(int id)
        {
            INSUMO user = this.buscarInsumo(id);
            if (user != null)
            {
                this.context.INSUMO.Remove(user);
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