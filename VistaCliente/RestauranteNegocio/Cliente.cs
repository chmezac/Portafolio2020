using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestauranteDatos;

namespace RestauranteNegocio
{
    public class Cliente
    {

        public decimal Id { get; set; }


        [Required(ErrorMessage = "Debe ingresar su RUT (obligatorio)")]
        public decimal Rut { get; set; }

        [Required(ErrorMessage = "Debe ingresar su DV (obligatorio)"), MaxLength(1, ErrorMessage ="El {0} debe tener {1} caracter.")]
        public string Dv { get; set; }

        [Required(ErrorMessage = "Debe ingresar su Contraseña (obligatorio)")]
        public string Pass { get; set; }

        public string PNombre { get; set; }

        public string SNombre { get; set; }

        public string ApPaterno { get; set; }

        public string ApMaterno { get; set; }

        public string Sexo { get; set; }

        public string Direccion { get; set; }

        public decimal NDireccion { get; set; }

        public decimal Telefono { get; set; }

        public DateTime FechaN { get; set; }

        public string Correo { get; set; }

        public decimal IdMesa { get; set; }



        RestauranteEntities db = new RestauranteEntities();

        public bool Autenticar()
        {
            return db.CLIENTE
                .Where(c => c.RUT_CLIENTE  == this.Rut && c.DV_CLIENTE == this.Dv && c.PASSWD_CLIENTE == this.Pass)
                .FirstOrDefault() != null;   
        }
        
        
        }
    
    }

