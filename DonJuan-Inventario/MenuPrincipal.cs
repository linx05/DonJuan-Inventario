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
            Application.Exit();
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
    }
}
