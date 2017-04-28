using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonJuan_Inventario
{
    class SQLC
    {
       SqlConnection Conexion = new SqlConnection("data source=ithdesarrollo.database.windows.net;initial catalog=BD_DONJUAN;persist security info=True;user id=ServerAdmin;password=wF8x9!!H;");
        int Proveedor_ID, Proveedor_ID1;
        int Compra_ID, Compra_ID1;
        int Producto_ID, Producto_ID1;
        int Categoria_ID, Categoria_ID1;

        public void idproveedor(TextBox TxtIDProveedor)
        {
            Conexion.Open();
            SqlDataReader sqldr;
            string cadena = "SELECT Proveedor_ID FROM Proveedor";
            SqlCommand comando = new SqlCommand(cadena, Conexion);
            sqldr = comando.ExecuteReader();

            while (sqldr.Read())
            {
                Proveedor_ID = Convert.ToInt32(sqldr["Proveedor_ID"]);

                if (Proveedor_ID >= Proveedor_ID1)
                {
                    Proveedor_ID1 = Proveedor_ID;
                }
            }
            Conexion.Close();
            TxtIDProveedor.Text = (Proveedor_ID1 + 1).ToString();
        }

        public void idcompra(TextBox TxtComprasID)
        {
            Conexion.Open();
            SqlDataReader sqldr;
            string cadena = "SELECT Compra_ID FROM Compra";
            SqlCommand comando = new SqlCommand(cadena, Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                Compra_ID = Convert.ToInt32(sqldr["Compra_ID"]);

                if (Compra_ID >= Compra_ID1)
                {
                    Compra_ID1 = Compra_ID;
                }
            }
            Conexion.Close();
            TxtComprasID.Text = (Compra_ID1 + 1).ToString();
        }

        public void idproducto(TextBox TxtProductoID)
        {
            Conexion.Open();
            SqlDataReader sqldr;
            string cadena = "SELECT Producto_ID FROM Producto";
            SqlCommand comando = new SqlCommand(cadena, Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                Producto_ID = Convert.ToInt32(sqldr["Producto_ID"]);

                if (Producto_ID >= Producto_ID1)
                {
                    Producto_ID1 = Producto_ID;
                }
            }
            Conexion.Close();
            TxtProductoID.Text = (Producto_ID1 + 1).ToString();
        }

        public void idcategoria(TextBox TxtCategoriaID)
        {
            Conexion.Open();
            SqlDataReader sqldr;
            string cadena = "SELECT Categoria_ID FROM Categoria";
            SqlCommand comando = new SqlCommand(cadena, Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
               Categoria_ID1 = Convert.ToInt32(sqldr["Categoria_ID"]);

                if (Categoria_ID >= Categoria_ID1)
                {
                    Categoria_ID1 = Categoria_ID;
                }
            }
            Conexion.Close();
            TxtCategoriaID.Text = (Categoria_ID1 + 1).ToString();
        }
    }
}
