using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace DonJuan_Inventario
{
    class SQLC
    {
        SqlConnection Conexion = new SqlConnection("data source = ithdesarrollo.database.windows.net; initial catalog = BD_DONJUAN; persist security info=True;user id = ServerAdmin; password=wF8x9!!H");
        //SqlConnection Conexion = new SqlConnection("Data Source= Servidor-mada; Initial Catalog=BD_DONJUAN; User Id= sa; Password= Servidor2017");
        int Proveedor_ID, Proveedor_ID1;
        int Compra_ID, Compra_ID1;
        int Producto_ID, Producto_ID1;
        int Categoria_ID, Categoria_ID1;
        public string User = "";
        public string password = "";
        ArrayList Cantidades = new ArrayList();
       public  bool CantidadesD = false; 
        int Puntero = 0;

        int x = 0;
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
        public void Validacion(TextBox Usuario, TextBox Contraseña)
        {
            Conexion.Open();
            SqlDataReader sqldr;

            string cadena = "SELECT NOMBRE, Contraseña FROM EMPLEADO WHERE NOMBRE = '" + Usuario.Text + "'" + "AND Contraseña ='" + Contraseña.Text + "'";
            SqlCommand comando = new SqlCommand(cadena, Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                User = sqldr["NOMBRE"].ToString();
                password = sqldr["Contraseña"].ToString();
            }
            Conexion.Close();
        }
        //Modificar Proveedor
        public void BuscarProveedor(TextBox IdProveedor, TextBox NombreProveedor, TextBox Direccion, TextBox Telefono, TextBox RFC, TextBox Correo, ComboBox ProveedorB)
        {
            Conexion.Open();
            SqlDataReader sqldr;
            string cadena = "Select Proveedor_ID, Nombre, Direccion, Telefono, RFC, Email from proveedor where Nombre = '" + ProveedorB.Text + "'";
            SqlCommand comando = new SqlCommand(cadena, Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                IdProveedor.Text = sqldr["Proveedor_ID"].ToString();
                NombreProveedor.Text = sqldr["Nombre"].ToString();
                Direccion.Text = sqldr["Direccion"].ToString();
                Telefono.Text = sqldr["Telefono"].ToString();
                RFC.Text = sqldr["RFC"].ToString();
                Correo.Text = sqldr["Email"].ToString();
            }
            Conexion.Close();
        }
        public void ModificarProveedor(TextBox IdProveedor, TextBox NombreProveedor, TextBox Direccion, TextBox Telefono, TextBox RFC, TextBox Correo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String query = "UPDATE Proveedor SET Nombre = @Nom, Direccion = @Dir, Telefono = @Tel, RFC = @RFC, Email = @Email WHERE Proveedor_ID = @ProID";
            cmd.Parameters.AddWithValue("@Nom", NombreProveedor.Text);
            cmd.Parameters.AddWithValue("@Dir", Direccion.Text);
            cmd.Parameters.AddWithValue("@Tel", Telefono.Text);
            cmd.Parameters.AddWithValue("@RFC", RFC.Text);
            cmd.Parameters.AddWithValue("@Email", Correo.Text);
            cmd.Parameters.AddWithValue("@ProID", IdProveedor.Text);
            cmd.CommandText = query;
            cmd.Connection = Conexion;
            Conexion.Open();
            cmd.ExecuteReader();
            Conexion.Close();
        }
        public void EliminarProveedor(TextBox IdProveedor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String query = "DELETE FROM proveedor WHERE Proveedor_ID = '" + IdProveedor.Text + "'";
            cmd.CommandText = query;
            cmd.Connection = Conexion;
            Conexion.Open();
            cmd.ExecuteNonQuery();
            Conexion.Close();
        }
        //Modificar Producto
        public void BuscarProducto(TextBox IdProducto, TextBox NombreProducto, TextBox Precio, TextBox Costo, ComboBox Unidad, TextBox Marca, ComboBox ProductoB)
        {
            Conexion.Open();
            SqlDataReader sqldr;
            string cadena = "Select  Producto_id, Nombre, Precio, Costo, Unidad, Marca from producto where Nombre = '" + ProductoB.Text + "'";
            SqlCommand comando = new SqlCommand(cadena, Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                IdProducto.Text = sqldr["Producto_ID"].ToString();
                NombreProducto.Text = sqldr["Nombre"].ToString();
                Precio.Text = sqldr["Precio"].ToString();
                Costo.Text = sqldr["Costo"].ToString();
                Unidad.Text = sqldr["Unidad"].ToString();
                Marca.Text = sqldr["Marca"].ToString();
            }
            Conexion.Close();
        }
        public void ModificarProducto(TextBox IdProducto, TextBox NombreProducto, TextBox Precio, TextBox Costo, ComboBox Unidad, TextBox Marca)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String query = "UPDATE Producto SET Nombre = @Nom, Precio = @Precio, Costo = @Costo, Unidad = @Unidad, Marca = @Marca WHERE Producto_ID = @ProID";
            cmd.Parameters.AddWithValue("@Nom", NombreProducto.Text);
            cmd.Parameters.AddWithValue("@Precio", Precio.Text);
            cmd.Parameters.AddWithValue("@Costo", Costo.Text);
            cmd.Parameters.AddWithValue("@Unidad", Unidad.Text);
            cmd.Parameters.AddWithValue("@Marca", Marca.Text);
            cmd.Parameters.AddWithValue("@ProID", IdProducto.Text);
            cmd.CommandText = query;
            cmd.Connection = Conexion;
            Conexion.Open();
            cmd.ExecuteReader();
            Conexion.Close();
        }
        public void EliminarProducto(TextBox IdProducto)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String query = "DELETE FROM Producto WHERE Producto_ID = '" + IdProducto.Text + "'";
            cmd.CommandText = query;
            cmd.Connection = Conexion;
            Conexion.Open();
            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void ConsultarCantidad(DataGridView DgvPedidos)
        {
            
            foreach (DataGridViewRow row in DgvPedidos.Rows)
            {

              Consultas(Convert.ToInt32(row.Cells[1].Value) , Convert.ToInt32(row.Cells[2].Value));
   
            } 
            /* int x = 0;
             
           */
            
           
        }

        public void Consultas(int ID, int CantidadRow)
        {
            Conexion.Open();
            
            string cadena = "SELECT * FROM INVENTARIO  WHERE PRODUCTO_ID = '" + ID + "'";

            SqlCommand comando = new SqlCommand(cadena, Conexion);
            SqlDataReader sqldr;
            
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                
               Cantidades.Add( Convert.ToInt32(sqldr["CANTIDAD"]));

                if (Convert.ToInt32(sqldr["CANTIDAD"]) < CantidadRow)
                {
                    MessageBox.Show("Cantidad No Disponible Del Producto Con ID : " + ID + " Cantidad En Almacen: " + sqldr["CANTIDAD"]);
                }
                else
                {
                    CantidadesD = true;
                }
                Puntero++;
            }
            Conexion.Close();

        }
    }
}