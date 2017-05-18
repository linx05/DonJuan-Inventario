using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DonJuan_Inventario
{
    [Serializable]
    [MetadataType(typeof(PRODUCTO_MOVIMIENTOMetaData))]
    public partial class PRODUCTO_MOVIMIENTO : PRODUCTO_MOVIMIENTOMetaData
    {
        [DisplayName("Producto")]
        public string ProductName
        {
            get { return this.PRODUCTO.NOMBRE; }
        }

        public static T DeepClone<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T) formatter.Deserialize(ms);
            }
        }

        public static Dictionary<string,string> TiposMovimiento
        {
            get {
                return new Dictionary<string, string>()
                {
                    { "ENTRADA","Entrada" },
                    {"SALIDA","Salida" },
                    {"COMPRA","Compra" },
                    {"VENTA","Venta" }
                };
            }
        }
    }

    public class PRODUCTO_MOVIMIENTOMetaData
    {
        [DisplayName("ID de Producto")]
        public Nullable<int> PRODUCTO_ID { get; set; }
        [System.ComponentModel.Browsable(false)]
        public int PRODUCTO_MOVIMIENTO_ID { get; set; }
        [System.ComponentModel.Browsable(false)]
        public Nullable<int> PROVEEDOR_ID { get; set; }
        [System.ComponentModel.Browsable(false)]
        public Nullable<int> COMPRA_ID { get; set; }
        [System.ComponentModel.Browsable(false)]
        public Nullable<int> PEDIDO_ID { get; set; }
        [DisplayName("Cantidad")]
        public Nullable<int> CANTIDAD { get; set; }
        [System.ComponentModel.Browsable(false)]
        public string TIPO { get; set; }
        [System.ComponentModel.Browsable(false)]
        public virtual COMPRA COMPRA { get; set; }
        [System.ComponentModel.Browsable(false)]
        public virtual PEDIDO PEDIDO { get; set; }
        [System.ComponentModel.Browsable(false)]
        public virtual PRODUCTO PRODUCTO { get; set; }
        [System.ComponentModel.Browsable(false)]
        public virtual PROVEEDOR PROVEEDOR { get; set; }

    }


}
