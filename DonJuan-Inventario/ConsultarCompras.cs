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
        BD_DONJUANEntities Conectar = new BD_DONJUANEntities();
        

        public ConsultarCompras()
        {
            InitializeComponent();
        }

        private void ConsultarCompras_Load(object sender, EventArgs e)
        {
            dtgCompras.AutoGenerateColumns = false;
            listarCompras();
        }
        private void listarCompras()
        {
            //var lista1 = Conectar.PROVEEDORs.ToList();
            var lista = Conectar.COMPRAs.ToList();
            dtgCompras.DataSource = lista;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
