using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestauranteNegocio
{
    public class Cliente
    {
        [Required]
        [StringLength(maximumLength: 10, MinimumLength = 9, ErrorMessage = "RUT inválido")]
        [Display(Name = "Rut")]
        public string RUT_CLIENTE { get; set; }


        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "Contraseña no puede ser mayor a 20 caracteres")]
        [Display(Name = "Pass")]
        public string PASSWORD_CLIENTE { get; set; }

        
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "Nombre no puede ser mayor a 20 caracteres")]
        [Display(Name = "Nombre")]
        public string NOMBRE_CLIENTE { get; set; }

        
        [Required]
        [StringLength(20, ErrorMessage = "Apellido no puede ser mayor a 20 caracteres")]
        [Display(Name = "Apellido")]
        public string APELLIDO_CLIENTE { get; set; }


        [StringLength(40, ErrorMessage = "Correo no puede ser mayor a 40 caracteres")]
        [Display(Name = "Correo")]
        public string CORREO_CLIENTE { get; set; }

        [Range(0, 9999999999, ErrorMessage = "Ingrese un número válido")]
        [Display(Name = "Telefono")]
        public int TELEFONO_CLIENTE { get; set; }



    }
}
