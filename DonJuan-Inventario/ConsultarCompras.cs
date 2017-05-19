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
    public partial class ConsultarCompras : Form
    {
        List<COMPRA> compras;
        List<PRODUCTO_MOVIMIENTO> selectedProducts;

        public ConsultarCompras()
        {
            InitializeComponent();
        }

        private DataGridViewRow getSelectedRow()
        {
            List<DataGridViewRow> rowCollection = new List<DataGridViewRow>();

            foreach (DataGridViewCell cell in dtgCompras.SelectedCells)
            {
                rowCollection.Add(dtgCompras.Rows[cell.RowIndex]);
            }
            if (rowCollection.Count() > 0)
            {
                return rowCollection.FirstOrDefault();
            }
            else return null;

        }

        private void ConsultarCompras_Load(object sender, EventArgs e)
        {
            //dtgCompras.AutoGenerateColumns = false;
            listarCompras();
        }
        private void listarCompras()
        {
            using (var donJuan = new BD_DONJUANEntities())
            {
                compras = donJuan.COMPRAs.Include("PROVEEDOR").ToList();
                dtgCompras.DataSource = null;
                dtgCompras.DataSource = compras;
            }
        }

        private void listarProductos ()
        {
            dtgProducto.DataSource = null;
            dtgProducto.DataSource = selectedProducts;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedSale = getSelectedRow();
            if (selectedSale != null)
            {
                var item = compras.Where(x => x.COMPRA_ID == (int)selectedSale.Cells["COMPRA_ID"].Value).First();
                using (var donJuan = new BD_DONJUANEntities())
                {
                    selectedProducts = donJuan.PRODUCTO_MOVIMIENTO.Include("PRODUCTO").Where(x => x.COMPRA_ID == item.COMPRA_ID).ToList();
                }
                if (selectedProducts.Count() > 0) listarProductos();
            }
        }
    }
}
