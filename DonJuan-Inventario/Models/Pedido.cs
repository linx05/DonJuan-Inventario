using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DonJuan_Inventario
{
    [MetadataType(typeof(PEDIDOMetadata))]
    public partial class PEDIDO : PEDIDOMetadata
    {
        public static Dictionary<string,string> EstadosPedido
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    {"Aceptado","Aceptado" },
                    {"Rechazado","Rechazado" },
                    {"Activo","Activo" },
                    {"Entregado","Entregado" },
                    {"Cancelado","Cancelado" }
                };
            }
        }
    }

    public class PEDIDOMetadata
    {
        [DisplayName("ID de Pedido")]
        public int PEDIDO_ID { get; set; }
        [DisplayName("Estado")]
        public string ESTADO { get; set; }
        [DisplayName("Fecha")]
        public Nullable<System.DateTime> FECHA { get; set; }


        [System.ComponentModel.Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PEDIDO_RECIBIDO> PEDIDO_RECIBIDO { get; set; }

        [System.ComponentModel.Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTO_MOVIMIENTO> PRODUCTO_MOVIMIENTO { get; set; }
    }


}
