using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestauranteDatos;

namespace RestauranteNegocio
{
    public class Categoria
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }


        RestauranteEntities db = new RestauranteEntities();

        public List<Categoria> ReadAll()
        {
            return db.CATEGORIA.Select(c => new Categoria()
            {
                Id = c.ID_CATEG,
                Descripcion = c.DESCRIP_CATEG,
                Nombre = c.NOM_CATEG
            }

            ).ToList();
        }


    }
}
