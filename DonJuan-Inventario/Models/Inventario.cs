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
        public int INVENTARIO_ID { get; }
        [DisplayName("ID Producto")]
        public int PRODUCTO_ID { get; }
        [DisplayName("Cantidad")]
        public int CANTIDAD { get; }
        [System.ComponentModel.Browsable(false)]
        public virtual PRODUCTO PRODUCTO { get;}
    }

}
