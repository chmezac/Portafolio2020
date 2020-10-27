using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestauranteNegocio
{
    public class Mesa
    {

        [Required]
        [Display(Name = "Numero mesa")]
        [Range(0, 3, ErrorMessage = "Ingrese número valido")]
        public int NUM_MESA { get; set; }


        [Display(Name = "Estado de la mesa")]
        public int ESTADO_MESA { get; set; }


        [Required]
        [Range(0, 2, ErrorMessage = "Ingrese número valido")]
        [Display(Name = "Capacidad de personas")]
        public int CANT_PERSONAS { get; set; }


    }
}
