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
    
    public partial class PRODUCTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCTO()
        {
            this.INVENTARIOs = new HashSet<INVENTARIO>();
            this.PRODUCTO_MOVIMIENTO = new HashSet<PRODUCTO_MOVIMIENTO>();
            this.STOCKs = new HashSet<STOCK>();
            this.VENTA_PRODUCTO = new HashSet<VENTA_PRODUCTO>();
        }
    
        public int PRODUCTO_ID { get; set; }
        public int CATEGORIA_ID { get; set; }
        public Nullable<int> PROVEEDOR_ID { get; set; }
        public string NOMBRE { get; set; }
        public Nullable<decimal> PRECIO { get; set; }
        public Nullable<decimal> COSTO { get; set; }
        public string UNIDAD { get; set; }
        public string MARCA { get; set; }
    
        public virtual CATEGORIA CATEGORIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTARIO> INVENTARIOs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTO_MOVIMIENTO> PRODUCTO_MOVIMIENTO { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STOCK> STOCKs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENTA_PRODUCTO> VENTA_PRODUCTO { get; set; }
    }
}
