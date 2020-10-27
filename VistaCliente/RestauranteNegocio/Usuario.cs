using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestauranteNegocio
{
   public  class Usuario
    {

        [Required]
        [Display(Name = "Rol")]
        public int ROL_ID_ROL { get; set; }

        [Required]
        [StringLength(maximumLength: 10, MinimumLength = 9, ErrorMessage = "Error, RUT inválido")]
        [Display(Name = "Rut")]
        public string RUT_USUARIO { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [StringLength(20, ErrorMessage = "Nombre no puede ser mayor a 20 caracteres")]
        public string NOMBRE_USUARIO { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Apellido no puede ser mayor a 20 caracteres")]
        [Display(Name = "Apellido")]
        public string APELLIDO_USUARIO { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Email no puede ser mayor a 40 caracteres")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string EMAIL_USUARIO { get; set; }

        [Required]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        [StringLength(maximumLength: 20, MinimumLength = 6, ErrorMessage = "La contraseña debe tener entre 6 y 20 caracteres")]
        public string PASSWORD_USUARIO { get; set; }








    }

}
