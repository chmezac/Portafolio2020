//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestauranteDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class BANCO
    {
        public BANCO()
        {
            this.TARJETA = new HashSet<TARJETA>();
        }
    
        public string ID_BANCO { get; set; }
        public string NOM_BANCO { get; set; }
    
        public virtual ICollection<TARJETA> TARJETA { get; set; }
    }
}