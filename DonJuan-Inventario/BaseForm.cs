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
    public class BaseForm : Form
    {
        public void ShowErrorBox (string mensaje, string titulo = "Error!")
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void updateInventory(List<PRODUCTO_MOVIMIENTO> productosMovimiento)
        {
            using (var donJuan = new BD_DONJUANEntities())
            {
                foreach (var producto in productosMovimiento)
                {
                    var multiplier = (producto.TIPO == PRODUCTO_MOVIMIENTO.TiposMovimiento["COMPRA"]) ? 1 : -1;
                    var cantidad = (producto.CANTIDAD ?? 0) * multiplier;
                    var element = donJuan.INVENTARIOs.ToList();
                    //var element = donJuan.INVENTARIOs.Where(x => x.PRODUCTO_ID == producto.PRODUCTO_ID).FirstOrDefault();
                    if (element != null)
                    {
                        //element.CANTIDAD += cantidad;
                    }
                }
                donJuan.SaveChanges();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ResumeLayout(false);

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
