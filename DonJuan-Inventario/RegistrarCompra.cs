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
    public partial class RegistrarCompra : BaseForm
    {
        List<PRODUCTO> todosProductos;
        List<PRODUCTO> productosDisponibles;
        List<PRODUCTO_MOVIMIENTO> productosCompra;
        SQLC con = new SQLC();
        Validaciones V = new Validaciones();
        string product= "";
        string provee = "";

        public RegistrarCompra()
        {
            InitializeComponent();
            init();
            //BindingSource source = new BindingSource();
            //source.DataSource = productosCompra;
            //dtgProducto.DataSource = source;
        }

        public void init ()
        {
            productosCompra = new List<PRODUCTO_MOVIMIENTO>();
            todosProductos = new List<PRODUCTO>();
            productosDisponibles = new List<PRODUCTO>();
            txtCompraID.Clear();
            txtFactura.Clear();
            txtSubTotal.Clear();
            txtTotal.Clear();
            cmbProducto.Focus();
            con.idcompra(txtCompraID);
            ListarProducto();
            ListarProveedores();
            assignDataGridProducts(productosCompra);
            assignCmbProducto(todosProductos);
        }

        private void RegistrarCompra_Load(object sender, EventArgs e)
        {
            init();
            con.idcompra(txtCompraID);
            product = cmbProducto.SelectedValue.ToString();
            provee = cmbProducto.SelectedValue.ToString();
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            var compra = new COMPRA();
            if (!(productosCompra.Count() > 0))
            {
                ShowErrorBox("No ha seleccionado productos!");
                return;
            }
            V.BRegistrarCompra(txtSubTotal, txtTotal, txtFactura, ErrorP1);
            if (V.VRegistrarCompra(txtSubTotal, txtTotal, txtFactura, ErrorP1))
            {
                compra.COMPRA_ID = Convert.ToInt32(txtCompraID.Text);
                compra.SUBTOTAL = Convert.ToDecimal(txtSubTotal.Text);
                compra.TOTAL = Convert.ToDecimal(txtTotal.Text);
                compra.FECHA = Convert.ToDateTime(dtpFecha.Text);
                compra.FACTURA = txtFactura.Text;
                compra.PROVEEDOR_ID = Convert.ToInt32(provee);
                compra.PRODUCTO_MOVIMIENTO = productosCompra;

                using (var donJuan = new BD_DONJUANEntities())
                {
                    foreach (var item in productosCompra)
                    {
                        donJuan.Entry(item.PRODUCTO).State = System.Data.Entity.EntityState.Modified;
                        donJuan.PRODUCTO_MOVIMIENTO.Add(item);
                    }
                    donJuan.COMPRAs.Add(compra);
                    donJuan.SaveChanges();
                    updateInventory(compra.PRODUCTO_MOVIMIENTO.ToList());
                    MessageBox.Show("Se agrego una Compra!");
                    init();
                }
            }
        }

        private void assignDataGridProducts (List<PRODUCTO_MOVIMIENTO> prodMovimientos)
        {
            dtgProducto.DataSource = null;
            dtgProducto.DataSource = prodMovimientos;
            dtgProducto.Columns["PRODUCTO_ID"].DisplayIndex = 0;
        }
        
        private void assignCmbProducto (List<PRODUCTO> productos)
        {
            cmbProducto.DataSource = null;
            cmbProducto.DataSource = productos;
            cmbProducto.DisplayMember = "NOMBRE";
            cmbProducto.ValueMember = "Producto_ID";
        }

        private DataGridViewRow getSelectedRow ()
        {
            List<DataGridViewRow> rowCollection = new List<DataGridViewRow>();

            foreach (DataGridViewCell cell in dtgProducto.SelectedCells)
            {
                rowCollection.Add(dtgProducto.Rows[cell.RowIndex]);
            }
            if (rowCollection.Count() > 0)
            {
                return rowCollection.FirstOrDefault();
            }
            else return null;

        }

        private void ListarProducto()
        {
            using (var donJuan = new BD_DONJUANEntities())
            {
                todosProductos = donJuan.PRODUCTOes.ToList();
                productosDisponibles = todosProductos;
                if (productosDisponibles.Count > 0)
                {
                    assignCmbProducto(productosDisponibles);
                }

            }
        }
        private void ListarProveedores()
        {
            using (var donJuan = new BD_DONJUANEntities())
            {
                var lista = donJuan.PROVEEDORs.ToList();
                if (lista.Count > 0)
                {
                    cmbProveedor.DataSource = lista;
                    cmbProveedor.DisplayMember = "NOMBRE";
                    cmbProveedor.ValueMember = "Proveedor_ID";
                    cmbProveedor.SelectedIndex = -1;
                }
            }
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //product = cmbProducto.SelectedValue.ToString();
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //provee = cmbProveedor.SelectedValue.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSubTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.PermitirNumeros(sender, e);
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.PermitirNumeros(sender, e);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (cmbProducto.SelectedIndex != -1)
            {
                try
                {
                    var selectedItem = todosProductos
                    .Where(x => x.PRODUCTO_ID == Int32.Parse(cmbProducto.SelectedValue.ToString()))
                    .First();
                    if(! (productosCompra.Where(x=> x.PRODUCTO.PRODUCTO_ID == selectedItem.PRODUCTO_ID).Count() > 0))
                    {
                        var prodMovimiento = new PRODUCTO_MOVIMIENTO();
                        prodMovimiento.TIPO = PRODUCTO_MOVIMIENTO.TiposMovimiento["COMPRA"];
                        prodMovimiento.PRODUCTO = selectedItem;
                        prodMovimiento.PRODUCTO_ID = selectedItem.PRODUCTO_ID;
                        prodMovimiento.CANTIDAD = decimal.ToInt32(txtCantidad.Value);

                        productosCompra.Add(prodMovimiento);
                    }
                    else
                    {
                        var prodMovimiento = productosCompra.Where(x => x.PRODUCTO.PRODUCTO_ID == selectedItem.PRODUCTO_ID).First();
                        prodMovimiento.CANTIDAD = decimal.ToInt32(txtCantidad.Value);
                    }
                    assignDataGridProducts(productosCompra);

                }
                catch(Exception)
                {

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var selectedProduct = getSelectedRow();
            if(selectedProduct != null)
            {
                var item = productosCompra.Where(x => x.PRODUCTO_ID == (int)selectedProduct.Cells["PRODUCTO_ID"].Value).First();
                productosCompra.Remove(item);
                assignDataGridProducts(productosCompra);
            }
        }

        private void dtgProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
