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
    
    public partial class ENCARGO
    {
        public string COD_ENCARGO { get; set; }
        public System.DateTime FECHA_ENCARGO { get; set; }
        public string DESCRIP_ENCARGO { get; set; }
        public int ADMINISTRADOR_RUT_ADMIN { get; set; }
        public int PROVEEDOR_RUT_PROVEEDOR { get; set; }
        public decimal ADMINISTRADORV1_RUT_ADMIN { get; set; }
    
        public virtual ADMINISTRADOR ADMINISTRADOR { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
    }
}