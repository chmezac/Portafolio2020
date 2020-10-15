using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestauranteDatos.Datos
{
    public class ClienteDatos
    {
        [Required]
        [StringLength(maximumLength: 15, ErrorMessage = "El Nombre no puede superar los 15 caracteres")]
        [Display(Name = "Nombre")]
        public string PNOMBRE_CLIENTE { get; set; }

    }
}
