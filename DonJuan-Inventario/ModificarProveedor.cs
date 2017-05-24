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
    public partial class ModificarProveedor : Form
    {
        SQLC C = new SQLC();
        List<PROVEEDOR> provee;
        Validaciones V = new Validaciones();
    
        public ModificarProveedor()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombreProveedor.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtRFC.Text == "" || txtCorreo.Text == "")
            {
                MessageBox.Show("Completa Datos");
            }
            else
            {
                C.ModificarProveedor(txtProveedorID, txtNombreProveedor, txtDireccion, txtTelefono, txtRFC, txtCorreo);
                MessageBox.Show("Se Modifico Correctamente!");
                txtCorreo.Clear();
                txtDireccion.Clear();
                txtNombreProveedor.Clear();
                txtRFC.Clear();
                txtCorreo.Clear();
            }
        }

        private void cmbProveedorB_SelectedIndexChanged(object sender, EventArgs e)
        {
            C.BuscarProveedor(txtProveedorID, txtNombreProveedor, txtDireccion, txtTelefono, txtRFC, txtCorreo, cmbProveedorB);
        }
        private void ListarProveedor()
        {
            using (var Conectar = new BD_DONJUANEntities())
            {
                provee = Conectar.PROVEEDORs.ToList();
                if (provee.Count > 0)
                {
                    cmbProveedorB.DataSource = provee;
                    cmbProveedorB.DisplayMember = "NOMBRE";
                    cmbProveedorB.ValueMember = "PROVEEDOR_ID";
                }
            }
        }

        private void ModificarProveedor_Load(object sender, EventArgs e)
        {
            ListarProveedor();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombreProveedor.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtRFC.Text == "" || txtCorreo.Text == "")
            {
                MessageBox.Show("Completa Datos");
            }
            else
            {
                DialogResult result = MessageBox.Show("Seguro que desea Eliminarlo?", "Salir", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    C.EliminarProveedor(txtProveedorID);
                    MessageBox.Show("Se ha Eliminado Correctamente!");
                    txtCorreo.Clear();
                    txtDireccion.Clear();
                    txtNombreProveedor.Clear();
                    txtRFC.Clear();
                    txtCorreo.Clear();
                }
                else
                {
                    result = DialogResult.Cancel;
                }
            }
        }

        private void cmbProveedorB_MouseClick(object sender, MouseEventArgs e)
        {
            ListarProveedor();
        }

        private void txtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.PermitirLetras(sender , e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.PermitirNumeros(sender, e);
        }
    }
}
