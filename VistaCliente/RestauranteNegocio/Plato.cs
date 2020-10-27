using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestauranteNegocio
{
    public class Plato
    {

        [Required]
        [StringLength(35, ErrorMessage = "Nombre del plato no puede ser mayor a 35 caracteres")]
        [Display(Name = "Nombre plato")]
        public string NOMBRE_PLATO { get; set; }

        [Required]
        [Range(0, 50000, ErrorMessage = "Ingrese un número válido")]
        [Display(Name = "Precio Venta")]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public int PRECIO_PLATO { get; set; }


        [Required]
        [StringLength(40, ErrorMessage = "Descripcion no puede ser mayor a 40 caracteres")]
        [Display(Name = "Descripción")]
        public string DESCRIPCION_PLATO { get; set; }

        [Required]
        [Range(0, 350, ErrorMessage = "Ingrese numero valido")]
        [Display(Name = "Tiempo Preparación")]
        public int TIEMPO_PREPARACION { get; set; }

    }
}
