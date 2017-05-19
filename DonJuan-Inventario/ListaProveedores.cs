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
    public partial class ListaProveedores : Form
    {
        private List<PROVEEDOR> prove = new List<PROVEEDOR>();

        public ListaProveedores()
        {
            InitializeComponent();
        }

        private void ListaProveedores_Load(object sender, EventArgs e)
        {
            ListarProveedores();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ListarProveedores()
        {
            using (var donJuan = new DonJuan_Inventario.BD_DONJUANEntities())
            {
                var proveedor = new PROVEEDOR();
                dataGridView1.DataSource = proveedor;

                //prove = donJuan.PROVEEDORs.ToList();
                //dtgProveedores2.Columns[1].DataPropertyName = "Proveedor_ID";
            }
        }
    }
}
