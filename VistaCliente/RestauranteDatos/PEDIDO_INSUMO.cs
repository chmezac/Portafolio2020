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
    
    public partial class PEDIDO_INSUMO
    {
        public int ID_PEDIDO_INSUMO { get; set; }
        public short CANTIDAD_PEDIDO_INSUMO { get; set; }
        public string UNIDAD { get; set; }
        public short INSUMO_ID_INSUMO { get; set; }
    
        public virtual INSUMO INSUMO { get; set; }
    }
}