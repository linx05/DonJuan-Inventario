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
    public partial class fmrCategoria : Form
    {
        SQLC con = new SQLC();
        public fmrCategoria()
        {
            InitializeComponent();
        }

        private void fmrCategoria_Load(object sender, EventArgs e)
        {
            con.idcategoria(txtCategoriaID);
        }

        private void btnRegistrarCategoria_Click(object sender, EventArgs e)
        {
            var categoria = new CATEGORIA();
            categoria.CATEGORIA_ID = Convert.ToInt32(txtCategoriaID.Text);
            categoria.NOMBRE = txtNomCategoria.Text;
            using (var donJuan = new DonJuan_Inventario.BD_DONJUANEntities())
            {
                donJuan.CATEGORIAs.Add(categoria);
                donJuan.SaveChanges();
                MessageBox.Show("Se agrego una categoria!");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            RegistrarProducto RP = new RegistrarProducto();
            RP.Show();
        }
    }
}
