//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DonJuan_Inventario
{
    using System;
    using System.Collections.Generic;
    
    public partial class COMPRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPRA()
        {
            this.PRODUCTO_MOVIMIENTO = new HashSet<PRODUCTO_MOVIMIENTO>();
        }
    
        public int COMPRA_ID { get; set; }
        public int PROVEEDOR_ID { get; set; }
        public Nullable<decimal> SUBTOTAL { get; set; }
        public Nullable<decimal> TOTAL { get; set; }
        public string ESTADO { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public string FACTURA { get; set; }
    
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTO_MOVIMIENTO> PRODUCTO_MOVIMIENTO { get; set; }
    }
}
