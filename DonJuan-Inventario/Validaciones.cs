using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonJuan_Inventario
{
    class Validaciones
    {
        public bool VRegistrarProvedor(TextBox NombreProveedor, TextBox Direccion, TextBox Telefono, TextBox RFC, TextBox Correo, ErrorProvider ErrorP)
        {
            bool ok = true;
            if (NombreProveedor.Text == "")
            {
                ok = false;
                ErrorP.SetError(NombreProveedor, "Ingresar Nombre");
            }
            if (Direccion.Text == "")
            {
                ok = false;
                ErrorP.SetError(Direccion, "Ingresar Direccion");
            }
            if (Telefono.Text == "")
            {
                ok = false;
                ErrorP.SetError(Telefono, "Ingresar Telefono");
            }
            if (RFC.Text == "")
            {
                ok = false;
                ErrorP.SetError(RFC, "Ingresar RFC");
            }
            if (Correo.Text == "")
            {
                ok = false;
                ErrorP.SetError(Correo, "Ingresar Correo");
            }
            return ok;
        }
        public void BRegistrarProovedor(TextBox NombreProveedor, TextBox Direccion, TextBox Telefono, TextBox RFC, TextBox Correo, ErrorProvider ErrorP)
        {
            ErrorP.SetError(NombreProveedor, "");
            ErrorP.SetError(Direccion, "");
            ErrorP.SetError(Telefono, "");
            ErrorP.SetError(RFC, "");
            ErrorP.SetError(Correo, "");
        }
        public bool VRegistrarProducto(TextBox NombreProducto, TextBox Precio, TextBox Costo, TextBox Marca, ErrorProvider ErrorP)
        {
            bool ok = true;
            if (NombreProducto.Text == "")
            {
                ok = false;
                ErrorP.SetError(NombreProducto, "Ingresar Nombre");
            }
            if (Precio.Text == "")
            {
                ok = false;
                ErrorP.SetError(Precio, "Ingresar precio");
            }
            if (Costo.Text == "")
            {
                ok = false;
                ErrorP.SetError(Costo, "Ingresar Costo");
            }
            if (Marca.Text == "")
            {
                ok = false;
                ErrorP.SetError(Marca, "Ingresar Marca");
            }
            return ok;
        }
        public void BRegistrarProducto(TextBox NombreProducto, TextBox Precio, TextBox Costo, TextBox Marca, ErrorProvider ErrorP)
        {
            ErrorP.SetError(NombreProducto, "");
            ErrorP.SetError(Precio, "");
            ErrorP.SetError(Costo, "");
            ErrorP.SetError(Marca, "");
        }
        public bool VRegistrarCompra(TextBox Subtotal, TextBox Total, TextBox Estado, ErrorProvider ErrorP)
        {
            bool ok = true;
            if (Subtotal.Text == "")
            {
                ok = false;
                ErrorP.SetError(Subtotal, "Ingresar SubTotal");
            }
            if (Total.Text == "")
            {
                ok = false;
                ErrorP.SetError(Total, "Ingresar Total");
            }
            if (Estado.Text == "")
            {
                ok = false;
                ErrorP.SetError(Estado, "Ingresar No. Factura");
            }


            return ok;
        }
        public void BRegistrarCompra(TextBox Subtotal, TextBox Total, TextBox Estado, ErrorProvider ErrorP)
        {
            ErrorP.SetError(Subtotal, "");
            ErrorP.SetError(Total, "");
            ErrorP.SetError(Estado, "");
        }
        public bool VRegistrarCategoria(TextBox Nombre, ErrorProvider ErrorP)
        {
            bool ok = true;
            if (Nombre.Text == "")
            {
                ok = false;
                ErrorP.SetError(Nombre, "Ingresar Nombre");
            }
            return ok;
        }
        public void BRegistrarCategoria(TextBox Nombre, ErrorProvider ErrorP)
        {
            ErrorP.SetError(Nombre, "");
        }
        public void PermitirLetras(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;
                return;
            }
        }
        public void PermitirNumeros(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '-') && (e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            }
        }
    }
}