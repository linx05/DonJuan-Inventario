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
    public partial class MenuPrincipal : Form
    {
        int idpuesto = 0;

        public MenuPrincipal(string s, int puesto)
        {            
            InitializeComponent();
            labelUsuario.Text = s;
            idpuesto = puesto;
        }
        private void registrarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPedidos CP = new ConsultarPedidos();
            CP.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea cerrar sesion?", "Salir", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                Form1 Log = new Form1();
                Log.Show();
                this.Close();
            }
            else
            {
                result = DialogResult.Cancel;
            }

        }

        private void registrarProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistrarProducto RPR = new RegistrarProducto();
            RPR.Show();
        }

        private void consultarInventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarInventario CI = new ConsultarInventario();
            CI.Show();
        }

        private void registrarProveedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistarProveedor RP = new RegistarProveedor();
            RP.Show();
        }

        private void listaDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaProveedores LP = new ListaProveedores();
            LP.Show();
        }

        private void registrarCompraDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarCompra RC = new RegistrarCompra();
            RC.Show();
        }

        private void consultarComprasDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCompras CC = new ConsultarCompras();
            CC.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            if (idpuesto == 1001)
            {
                modificarProductoToolStripMenuItem.Visible = false;
                modificarProveedoresToolStripMenuItem.Visible = false;
            }
            else if (idpuesto != 1002)
            {
                MessageBox.Show("Usted no pertenece a esta area");
                Form1 Log = new Form1();
                Log.Show();
                this.Close();
            }
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarProductocs MP = new ModificarProductocs();
            MP.Show();
        }

        private void modificarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarProveedor MP = new ModificarProveedor();
            MP.Show();
        }
    }
}
