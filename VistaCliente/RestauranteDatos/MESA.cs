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
    
    public partial class MESA
    {
        public MESA()
        {
            this.CLIENTE = new HashSet<CLIENTE>();
        }
    
        public short ID_MESA { get; set; }
        public short CAPACIDAD_MESA { get; set; }
        public string LOCAL_ID_LOCAL { get; set; }
    
        public virtual ICollection<CLIENTE> CLIENTE { get; set; }
        public virtual LOCAL LOCAL { get; set; }
    }
}