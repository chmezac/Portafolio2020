using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestauranteNegocio
{
    public class Insumo
    {

        [Required]
        [Display(Name = "Nombre insumo")]
        [StringLength(20, ErrorMessage = "Nombre del insumo no puede ser mayor a 20 caracteres")]
        public string NOMBRE_INSUMO { get; set; }

        [Required]
        [Display(Name = "Stock")]
        [Range(0, 9999, ErrorMessage = "Ingrese número válido")]
        public int STOCK_INSUMO { get; set; }

        [Required]
        [Display(Name = "Unidad medida")]
        [StringLength(20, ErrorMessage = "Unidad medida del insumo no puede ser mayor a 20 caracteres")]
        public string UNIDAD_MEDIDA_INSUMO { get; set; }

        [Required]
        [Display(Name = "Precio")]
        [Range(0, 999999, ErrorMessage = "Ingrese numero valido")]
        public int PRECIO_INSUMO { get; set; }


    }
}
