//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EXFIN
{
    using System;
    using System.Collections.Generic;
    
    public partial class VENTA
    {
        public int ID { get; set; }
        public Nullable<int> ID_PRODUCTO { get; set; }
        public Nullable<int> ID_PROVEEDOR { get; set; }
        public Nullable<int> PRECIO { get; set; }
        public Nullable<int> CANTIDAD { get; set; }
        public Nullable<int> TOTAL { get; set; }
    
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
    }
}
