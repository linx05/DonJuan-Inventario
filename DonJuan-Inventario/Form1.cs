using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonJuan_Inventario
{
    public partial class Form1 : Form
    {      
        SQLC C = new SQLC();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "" || txtUsuario.Text == "")
            {
                MessageBox.Show("Datos Incompletos");
            }
            else
            {
                C.Validacion(txtUsuario, txtContraseña);
                if (txtUsuario.Text == C.User && txtContraseña.Text == C.password)
                {
                    var MP = new MenuPrincipal(C.User);
                    RegistrarCompra RC = new RegistrarCompra();
                    MP.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

