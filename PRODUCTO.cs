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
    
    public partial class PRODUCTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCTO()
        {
            this.COMPRA = new HashSet<COMPRA>();
        }
    
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public Nullable<int> CANTIDAD { get; set; }
        public Nullable<int> STOCK { get; set; }
        public Nullable<int> ID_PROVEEDOR { get; set; }
        public string ESTADO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA> COMPRA { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        public virtual VENTA VENTA { get; set; }
    }
}
