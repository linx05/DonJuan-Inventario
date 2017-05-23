using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DonJuan_Inventario
{
    [MetadataType(typeof(INVENTARIOMetaData))]
    public partial class INVENTARIO : INVENTARIOMetaData
    {
        [DisplayName("Producto")]
        public string ProductName
        {
            get { return this.PRODUCTO.NOMBRE; }
        }
    }

    public class INVENTARIOMetaData
    {
        [DisplayName("ID Inventario")]
        public int INVENTARIO_ID { get; set; }
        [DisplayName("ID Producto")]
        public int PRODUCTO_ID { get; set; }
        [DisplayName("Cantidad")]
        public int CANTIDAD { get; set; }
        [System.ComponentModel.Browsable(false)]
        public virtual PRODUCTO PRODUCTO { get; set; }
    }

}
