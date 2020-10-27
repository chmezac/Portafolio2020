using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace RestauranteNegocio
{
    public class Rol
    {
        public int ID_ROL { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "nombre")]
        public string NOMBRE_ROL { get; set; }


        [Required]
        [StringLength(30)]
        [Display(Name = "descripcion")]
        public string DESCRIPCION_ROL { get; set; }



    }

}
