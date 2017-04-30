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
    public partial class RegistrarCompra : Form
    {
        BD_DONJUANEntities Conectar = new BD_DONJUANEntities();
        SQLC con = new SQLC();
        string product= "";
        string provee = "";

        public RegistrarCompra()
        {
            InitializeComponent();
        }

        private void RegistrarCompra_Load(object sender, EventArgs e)
        {
            con.idcompra(txtCompraID);
            ListarProducto();
            ListarProveedores();
            product = cmbProducto.SelectedValue.ToString();
            provee = cmbProducto.SelectedValue.ToString();
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            var compra = new COMPRA();

            compra.COMPRA_ID = Convert.ToInt32(txtCompraID.Text);
            compra.SUBTOTAL = Convert.ToDecimal(txtSubTotal.Text);
            compra.TOTAL = Convert.ToDecimal(txtTotal.Text);
            compra.FECHA = Convert.ToDateTime(dtpFecha.Text);
            compra.ESTADO = txtEstado.Text;
            compra.PROVEEDOR_ID = Convert.ToInt32(provee);

            using (var donJuan = new DonJuan_Inventario.BD_DONJUANEntities())
            {
                donJuan.COMPRAs.Add(compra);
                donJuan.SaveChanges();
                MessageBox.Show("Se agrego una Compra!");
                txtCompraID.Clear();
                txtEstado.Clear();
                txtSubTotal.Clear();
                txtTotal.Clear();
                cmbProducto.Focus();
                con.idcompra(txtCompraID);
            }
        }
        private void ListarProducto()
        {
            var lista = Conectar.PRODUCTOes.ToList();
            if (lista.Count > 0)
            {
                cmbProducto.DataSource = lista;
                cmbProducto.DisplayMember = "NOMBRE";
                cmbProducto.ValueMember = "Producto_ID";
            }
        }
        private void ListarProveedores()
        {
            var lista = Conectar.PROVEEDORs.ToList();
            if (lista.Count > 0)
            {
                cmbProveedor.DataSource = lista;
                cmbProveedor.DisplayMember = "NOMBRE";
                cmbProveedor.ValueMember = "Proveedor_ID";
            }
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            product = cmbProducto.SelectedValue.ToString();
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            provee = cmbProducto.SelectedValue.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
