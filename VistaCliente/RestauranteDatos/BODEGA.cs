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
    
    public partial class BODEGA
    {
        public BODEGA()
        {
            this.PRODUCTO = new HashSet<PRODUCTO>();
        }
    
        public short ID_BODEGA { get; set; }
        public string NOM_BODEGA { get; set; }
        public short CAPACIDAD { get; set; }
        public string LOCAL_ID_LOCAL { get; set; }
        public short ID_BODEG { get; set; }
    
        public virtual BODEGUERO BODEGUERO { get; set; }
        public virtual LOCAL LOCAL { get; set; }
        public virtual ICollection<PRODUCTO> PRODUCTO { get; set; }
    }
}