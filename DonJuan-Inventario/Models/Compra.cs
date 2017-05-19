using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DonJuan_Inventario
{
    [MetadataType(typeof(COMPRAMetadata))]
    public partial class COMPRA : COMPRAMetadata
    {
        [DisplayName("Proveedor")]
        public string ProveedorName
        {
            get { return this.PROVEEDOR.NOMBRE; }
        }
    }

    public class COMPRAMetadata
    {
        [DisplayName("ID Compra")]
        public int COMPRA_ID { get; set; }
        [Browsable(false)]
        public int PROVEEDOR_ID { get; set; }
        [DisplayName("Subtotal")]
        public Nullable<decimal> SUBTOTAL { get; set; }
        [DisplayName("Total")]
        public Nullable<decimal> TOTAL { get; set; }
        [Browsable(false)]
        public string ESTADO { get; set; }
        [DisplayName("Fecha")]
        public Nullable<System.DateTime> FECHA { get; set; }
        [DisplayName("No. de Factura")]
        public string FACTURA { get; set; }

        [Browsable(false)]
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTO_MOVIMIENTO> PRODUCTO_MOVIMIENTO { get; set; }
    }
}
