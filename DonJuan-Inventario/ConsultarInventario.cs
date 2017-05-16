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
    public partial class ConsultarInventario : Form
    {
        private List<INVENTARIO> productos = new List<INVENTARIO>();

        public ConsultarInventario()
        {
            InitializeComponent();

            using (var donJuan = new DonJuan_Inventario.BD_DONJUANEntities())
            {
                productos = donJuan.INVENTARIOs.Include("PRODUCTO").ToList();
                dtginventario.DataSource = productos;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarInventario_Load(object sender, EventArgs e)
        {

        }
    }
}
