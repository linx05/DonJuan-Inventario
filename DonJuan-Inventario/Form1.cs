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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var client = new CLIENTE();

            var PEDIDO = new PEDIDO();

            client.CIUDAD = "HMO";
            //using (var donJuan = new DonJuan_Inventario.BD_DONJUANEntities())
            //{
            //    donJuan.CLIENTEs.Add(client);
            //    var primerCLiente = donJuan.CLIENTEs.FirstOrDefault();

            //    var pedido = donJuan.PEDIDOes.First();
            //    pedido.PRODUCTO_MOVIMIENTO.Add(new PRODUCTO_MOVIMIENTO());

            //    donJuan.CLIENTEs.Remove(primerCLiente);
            //    //donJuan.SaveChanges();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var categoria = new CATEGORIA();

            var PEDIDO = new PEDIDO();
            categoria.CATEGORIA_ID = 2;
            categoria.NOMBRE = "Categora Prueba";
            using (var donJuan = new DonJuan_Inventario.BD_DONJUANEntities())
            {
                donJuan.CATEGORIAs.Add(categoria);
                donJuan.SaveChanges();
                MessageBox.Show("Se agrego una categoria!");
            }
        }
    }
}
