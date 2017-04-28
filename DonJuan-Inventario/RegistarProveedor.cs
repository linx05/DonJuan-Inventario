using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonJuan_Inventario
{
    public partial class RegistarProveedor : Form
    { 
        SQLC con = new SQLC();

        public RegistarProveedor()
        {
            InitializeComponent();
        }

        private void RegistarProveedor_Load(object sender, EventArgs e)
        {
            con.idproveedor(txtProveedorID);
        }

        private void btnRegistrarProveedor_Click(object sender, EventArgs e)
        {
            var proveedor = new PROVEEDOR();

            proveedor.PROVEEDOR_ID = Convert.ToInt32(txtProveedorID.Text);
            proveedor.NOMBRE = txtNombreProveedor.Text;
            proveedor.DIRECCION = txtDireccion.Text;
            proveedor.TELEFONO = txtTelefono.Text;
            proveedor.RFC = txtRFC.Text;
            proveedor.EMAIL = txtCorreo.Text;
            
            using (var donJuan = new DonJuan_Inventario.BD_DONJUANEntities())
            {
                donJuan.PROVEEDORs.Add(proveedor);
                donJuan.SaveChanges();
                MessageBox.Show("Se agrego una Proveedor!");
                txtCorreo.Clear();
                txtDireccion.Clear();
                txtNombreProveedor.Clear();
                txtProveedorID.Clear();
                txtRFC.Clear();
                txtTelefono.Clear();
                txtNombreProveedor.Focus();
                con.idproveedor(txtProveedorID);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
