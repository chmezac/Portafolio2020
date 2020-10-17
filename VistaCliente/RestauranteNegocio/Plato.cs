using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestauranteDatos;

namespace RestauranteNegocio
{
    public class Plato
    {
        public decimal Id { get; set; }

        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        public string Descripcion { get; set; }

        public string CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

        /*public Receta Receta { get; set; }*/


        RestauranteEntities db = new RestauranteEntities();



        /*LEER DATOS*/
        public List<Plato> ReadAll()
        {
            return this.db.PLATO.Select(p => new Plato()
            {

                Id = (decimal)p.ID_PLATO,
                Nombre = p.NOM_PLATO,
                Precio = (decimal)p.PRECIO_PLATO,
                Descripcion = p.DECRIP_PLATO,
                CategoriaId = p.CATEGORIA_ID_CATEG,

                Categoria = new Categoria()
                {
                    Id = p.CATEGORIA_ID_CATEG,
                    /*Descripcion = p.DESCRIP_CATEG,
                    Nombre = p.NOM_CATEG*/
                }

            }).ToList();
        }



    }
}
