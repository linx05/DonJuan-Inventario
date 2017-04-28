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
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void registrarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistarProveedor RP = new RegistarProveedor();
            RP.Show();
        }

        private void registrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarProducto RPR = new RegistrarProducto();
            RPR.Show();
        }

        private void registrarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPedidos CP = new ConsultarPedidos();
            CP.Show();
        }

        private void registrarCompraDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarCompra RC = new RegistrarCompra();
            RC.Show();
        }

        private void consultarComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCompras CC = new ConsultarCompras();
            CC.Show();
        }

        private void consultarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarInventario CI = new ConsultarInventario();
            CI.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
