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
    
    public partial class RECETA
    {
        public RECETA()
        {
            this.INGREDIENTE = new HashSet<INGREDIENTE>();
            this.INGREDIENTE1 = new HashSet<INGREDIENTE>();
        }
    
        public string ID_RECETA { get; set; }
        public string NOM_RECETA { get; set; }
        public string DESCRIP_RECETA { get; set; }
        public string PLATO_ID_PLATO { get; set; }
        public string INGREDIENTE_ID_INGREDIENTE { get; set; }
    
        public virtual ICollection<INGREDIENTE> INGREDIENTE { get; set; }
        public virtual ICollection<INGREDIENTE> INGREDIENTE1 { get; set; }
        public virtual INGREDIENTE INGREDIENTE2 { get; set; }
        public virtual PLATO PLATO { get; set; }
    }
}