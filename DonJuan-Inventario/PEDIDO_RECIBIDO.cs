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
    
    public partial class PEDIDO_RECIBIDO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PEDIDO_RECIBIDO()
        {
            this.PEDIDO_RECIBIDO_PRODUCTO = new HashSet<PEDIDO_RECIBIDO_PRODUCTO>();
        }
    
        public int PEDIDO_REC_ID { get; set; }
        public int PEDIDO_ID { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
    
        public virtual PEDIDO PEDIDO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PEDIDO_RECIBIDO_PRODUCTO> PEDIDO_RECIBIDO_PRODUCTO { get; set; }
    }
}
