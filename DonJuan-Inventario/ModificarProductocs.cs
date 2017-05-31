using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonJuan_Inventario
{
    public partial class ModificarProductocs : Form
    {
        SQLC C = new SQLC();
        List<PRODUCTO> producto;
        Validaciones V = new Validaciones();

        public ModificarProductocs()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            C.BuscarProducto(txtProductoID, txtNombreProducto, txtPrecio, txtCostoProducto, cmbUnidad, txtMarcaProducto, txtProductCode, cmbProductoB);
        }

        private void ModificarProductocs_Load(object sender, EventArgs e)
        {
            ListarProducto();
        }
        private void ListarProducto()
        {
            using (var Conectar = new BD_DONJUANEntities())
            {
                producto = Conectar.PRODUCTOes.ToList();
                if (producto.Count > 0)
                {
                    cmbProductoB.DataSource = producto;
                    cmbProductoB.DisplayMember = "NOMBRE";
                    cmbProductoB.ValueMember = "Producto_ID";
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text == "" || txtPrecio.Text == "" || txtCostoProducto.Text == "" || txtMarcaProducto.Text == "")
            {
                MessageBox.Show("Completa Datos");
            }
            else
            {
                C.ModificarProducto(txtProductoID, txtNombreProducto, txtPrecio, txtCostoProducto, cmbUnidad, txtMarcaProducto, txtProductCode);
                MessageBox.Show("Se Modifico Correctamente!");
                txtCostoProducto.Clear();
                txtMarcaProducto.Clear();
                txtNombreProducto.Clear();
                txtPrecio.Clear();
            }
            }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text == "" || txtPrecio.Text == "" || txtCostoProducto.Text == "" || txtMarcaProducto.Text == "")
            {
                MessageBox.Show("Completa Datos");
            }
            else
            {
                DialogResult result = MessageBox.Show("Seguro que desea Eliminarlo?", "Salir", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    C.EliminarProducto(txtProductoID);
                    MessageBox.Show("Se ha Eliminado Correctamente!");
                    txtCostoProducto.Clear();
                    txtMarcaProducto.Clear();
                    txtNombreProducto.Clear();
                    txtPrecio.Clear();
                }
                else
                {
                    result = DialogResult.Cancel;
                }
            }
            
        }

        private void cmbProductoB_MouseClick(object sender, MouseEventArgs e)
        {
            ListarProducto();
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.PermitirLetras(sender, e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.PermitirNumeros(sender, e);
        }

        private void txtCostoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.PermitirNumeros(sender, e);
        }

        private void txtMarcaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.PermitirLetras(sender, e);
        }
    }
}
