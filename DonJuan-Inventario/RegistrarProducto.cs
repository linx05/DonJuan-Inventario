﻿using System;
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
    public partial class RegistrarProducto : Form
    {
        BD_DONJUANEntities Conectar = new BD_DONJUANEntities();
        SQLC con = new SQLC();
        Validaciones V = new Validaciones();
        string categ = "";
        string provee = "";

        public RegistrarProducto()
        {
            InitializeComponent();
        }

        private void RegistrarProducto_Load(object sender, EventArgs e)
        {
            con.idproducto(txtProductoID);
            ListarCategoria();
            ListarProveedores();
            cmbUnidad.Text = "Kilogramos";
            categ = cmbCategoria.SelectedValue.ToString();
            provee = cmbProveedor.SelectedValue.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fmrCategoria FC = new fmrCategoria();
            FC.Show();
        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
                var producto = new PRODUCTO();




            V.BRegistrarProducto(txtNombreProducto, txtPrecio, txtCostoProducto, txtMarcaProducto, ErrorP1);
            if (V.VRegistrarProducto(txtNombreProducto, txtPrecio, txtCostoProducto, txtMarcaProducto, ErrorP1))
            {
                producto.PRODUCTO_ID = Convert.ToInt32(txtProductoID.Text);
                producto.NOMBRE = txtNombreProducto.Text;
                producto.PRECIO = Convert.ToDecimal(txtPrecio.Text);
                producto.COSTO = Convert.ToDecimal(txtCostoProducto.Text);
                producto.UNIDAD = cmbUnidad.Text;
                producto.MARCA = txtMarcaProducto.Text;
                producto.PROVEEDOR_ID = Convert.ToInt32(provee);
                producto.CATEGORIA_ID = Convert.ToInt32(categ);

                using (var donJuan = new DonJuan_Inventario.BD_DONJUANEntities())
                {
                    donJuan.PRODUCTOes.Add(producto);
                    donJuan.SaveChanges();
                    MessageBox.Show("Se agrego una Producto!");
                    txtProductoID.Clear();
                    txtNombreProducto.Clear();
                    txtPrecio.Clear();
                    txtMarcaProducto.Clear();
                    txtCostoProducto.Clear();
                    txtNombreProducto.Focus();
                    con.idproducto(txtProductoID);
                }
            }
        }
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            categ = cmbCategoria.SelectedValue.ToString();
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            provee = cmbProveedor.SelectedValue.ToString();
        }
        public void ListarCategoria()
        {
            var lista = Conectar.CATEGORIAs.ToList();
            if (lista.Count > 0)
            {
                cmbCategoria.DataSource = lista;
                cmbCategoria.DisplayMember = "NOMBRE";
                cmbCategoria.ValueMember = "Categoria_ID";
            }
        }
        private void ListarProveedores()
        {
            var lista = Conectar.PROVEEDORs.ToList();
            if (lista.Count > 0)
            {
                cmbProveedor.DataSource = lista;
                cmbProveedor.DisplayMember = "NOMBRE";
                cmbProveedor.ValueMember = "Proveedor_ID";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            ListarCategoria();
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.PermitirLetras(sender, e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.PermitirNumeros(sender, e);
        }

        private void txtCostoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.PermitirNumeros(sender, e);
        }

        private void txtMarcaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.PermitirLetras(sender, e);
        }
    }
}
