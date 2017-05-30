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
    public partial class ConsultarPedidos : BaseForm
    {
        private List<PEDIDO> pedidos;
        private List<PRODUCTO_MOVIMIENTO> selectedProducts;
        private PEDIDO selectedPedido;

        public ConsultarPedidos()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            pedidos = new List<PEDIDO>();

            using (var donJuan = new BD_DONJUANEntities())
            {
                pedidos = donJuan.PEDIDOes.Include("PEDIDO_RECIBIDO").Include("PRODUCTO_MOVIMIENTO.PRODUCTO").ToList();
            }
            dtgPedidos.DataSource = pedidos;
            populateCmbEstados();
        }

        private void listarProductos()
        {
            dtgProductos.DataSource = null;
            dtgProductos.DataSource = selectedProducts;
        }

        private void populateCmbEstados ()
        {
            cmbState.DataSource = null;
            cmbState.DataSource = new BindingSource(PEDIDO.EstadosPedido, null);
            cmbState.DisplayMember = "Key";
            cmbState.ValueMember = "Value";
        }

        private void processStateSelected (PEDIDO pedido)
        {
            cmbState.Enabled = true;
            btnCambiar.Enabled = true;
            cmbState.SelectedValue = pedido.ESTADO;
            if (pedido.ESTADO == PEDIDO.EstadosPedido["Entregado"] || pedido.ESTADO == PEDIDO.EstadosPedido["Cancelado"])
            {
                cmbState.Enabled = false;
                btnCambiar.Enabled = false;
            }
        }

        private void processSelected ()
        {
            processStateSelected(selectedPedido);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarPedidos_Load(object sender, EventArgs e)
        {

        }

        private void dtgPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            SQLC Sql = new SQLC();
            Sql.ConsultarCantidad(dtgProductos);
            if (Sql.CantidadesD == true)
            {
               
            }
            else
            {
                var selectedState = cmbState.SelectedValue;

                using (var donJuan = new BD_DONJUANEntities())
                {
                    if ((string)selectedState == PEDIDO.EstadosPedido["Entregado"])
                    {
                        if (selectedPedido != null)
                        {
                            var productos = donJuan.PRODUCTO_MOVIMIENTO.Include("PRODUCTO").Where(x => x.PEDIDO_ID == selectedPedido.PEDIDO_ID).ToList();
                            updateInventory(productos);
                        }
                    }
                    var pedido = donJuan.PEDIDOes.Where(x => x.PEDIDO_ID == selectedPedido.PEDIDO_ID).FirstOrDefault();
                    if (pedido != null)
                    {
                        pedido.ESTADO = (string)selectedState;
                    }
                    donJuan.SaveChanges();
                    MessageBox.Show("Se actualizo el estado del pedido!");
                    init();
                }
            }
        }

        private void dtgPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedSale = getSelectedRow(dtgPedidos);
            if (selectedSale != null)
            {
                selectedPedido = pedidos.Where(x => x.PEDIDO_ID == (int)selectedSale.Cells["PEDIDO_ID"].Value).First();
                selectedProducts = selectedPedido.PRODUCTO_MOVIMIENTO.ToList();
                if (selectedProducts.Count() > 0) listarProductos();
                processSelected();
            }
        }

        private void dtgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
