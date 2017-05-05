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
    public partial class ConsultarPedidos : Form
    {
        private List<PEDIDO> pedidos = new List<PEDIDO>();

        public ConsultarPedidos()
        {
            InitializeComponent();
            using (var donJuan = new DonJuan_Inventario.BD_DONJUANEntities())
            {
                pedidos = donJuan.PEDIDOes.Include("PEDIDO_RECIBIDO").Include("PRODUCTO_MOVIMIENTO").ToList();
            }
            dtgPedidos.DataSource = pedidos;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarPedidos_Load(object sender, EventArgs e)
        {

        }
    }
}
