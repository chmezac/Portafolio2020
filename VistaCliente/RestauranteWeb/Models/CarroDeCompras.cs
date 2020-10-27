using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestauranteDatos;

namespace RestauranteWeb.Models
{
    public class CarroDeCompras
    {

        public List<PEDIDO_PLATOS> ListaProductos { get; private set; }
        public static CarroDeCompras CapturarProducto()
        {
            CarroDeCompras _carrito = (CarroDeCompras)HttpContext.Current.Session["ASPCarroDeCompras"];
            if (_carrito == null)
            {
                HttpContext.Current.Session["ASPCarroDeCompras"] = _carrito = new CarroDeCompras();
            }
            return _carrito;
        }

        protected CarroDeCompras()
        {
            ListaProductos = new List<PEDIDO_PLATOS>();
        }

        public void Agregar(int pIdProducto)
        {
            PEDIDO_PLATOS NuevoProducto = new PEDIDO_PLATOS();

            using (RestauranteEntities entities = new RestauranteEntities())
            {
                NuevoProducto.PLATO = entities.PLATO.Where(n => n.ID_PLATO == pIdProducto).FirstOrDefault();
                NuevoProducto.PLATO_ID_PLATO = NuevoProducto.PLATO.ID_PLATO;
            }
            if (ListaProductos.Where(n => n.PLATO_ID_PLATO == NuevoProducto.PLATO_ID_PLATO).FirstOrDefault() != null)
            {
                foreach (PEDIDO_PLATOS item in ListaProductos)
                {
                    if (item.PLATO_ID_PLATO.Equals(NuevoProducto.PLATO_ID_PLATO))
                    {
                        item.CANTIDAD++;
                        return;
                    }
                }
            }
            else
            {
                NuevoProducto.CANTIDAD = 1;
                ListaProductos.Add(NuevoProducto);
            }
        }
        public void EliminarProductos(int pIdProducto)
        {
            PEDIDO_PLATOS eliminaritems = new PEDIDO_PLATOS();
            using (RestauranteEntities entities = new RestauranteEntities())
            {
                eliminaritems.PLATO = entities.PLATO.Where(n => n.ID_PLATO == pIdProducto).FirstOrDefault();
                eliminaritems.PLATO_ID_PLATO = eliminaritems.PLATO.ID_PLATO;
            }
            ListaProductos.Remove(ListaProductos.Where(c => c.PLATO.ID_PLATO == eliminaritems.PLATO.ID_PLATO).First());
        }


        //public void CantidadDeProductos(int pIdProducto, int pCantidad)
        //{
        //    if (pCantidad == 0)
        //    {
        //        EliminarProductos(pIdProducto);
        ///        return;
        //    }
        //    PEDIDO_PLATOS updateProductos = new PEDIDO_PLATOS();
        //    updateProductos.PLATO_ID_PLATO =  pIdProducto;
         //   foreach (PEDIDO_PLATOS item in ListaProductos)
         ///   {
        //        if (item.Equals(updateProductos))
         //       {
        //            item.CANTIDAD = pCantidad;
         //           return;
        //        }
         //   }
       // }



        public decimal SubTotal()
        {
            decimal subtotal = 0;
            foreach (PEDIDO_PLATOS item in ListaProductos)
            {
                subtotal += (item.CANTIDAD * item.PLATO.PRECIO_PLATO);
            }
            return subtotal;
        }
        public void sumar(int pIdProducto)
        {
            if (ListaProductos.Where(n => n.PLATO_ID_PLATO == pIdProducto).FirstOrDefault() != null)
            {
                foreach (PEDIDO_PLATOS item in ListaProductos)
                {
                    if (item.PLATO_ID_PLATO.Equals(pIdProducto))
                    {
                        item.CANTIDAD++;
                        return;
                    }
                }
            }
        }
        public void restar(int pIdProducto)
        {
            if (ListaProductos.Where(n => n.PLATO_ID_PLATO == pIdProducto).FirstOrDefault() != null)
            {
                foreach (PEDIDO_PLATOS item in ListaProductos)
                {
                    if (item.PLATO_ID_PLATO.Equals(pIdProducto))
                    {
                        if (item.CANTIDAD == 1)
                        {
                            EliminarProductos(pIdProducto);
                            return;
                        }
                        else
                        {
                            item.CANTIDAD--;
                            return;
                        }
                    }
                }
            }
        }











    }
}