using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestauranteNegocio
{
    public class Pedido
    {

        [Display(Name = "Fecha del Pedido")]
        public System.DateTime FECHA_PEDIDO { get; set; }

        [Display(Name = "Estado del Pedido")]
        [Range(0, 11, ErrorMessage = "Ingrese un número válido")]
        public int ESTADO_PEDIDO { get; set; }

    }
}
