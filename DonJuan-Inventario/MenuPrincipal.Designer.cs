namespace DonJuan_Inventario
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProductoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarInventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProveedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCompraDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarComprasDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Orange;
            this.menuStrip1.Font = new System.Drawing.Font("AR BERKLEY", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.listadoProveedoresToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 39);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarProductoToolStripMenuItem1,
            this.consultarInventarioToolStripMenuItem1});
            this.productosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.productosToolStripMenuItem.Image = global::DonJuan_Inventario.Properties.Resources.icono_9;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(129, 35);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // registrarProductoToolStripMenuItem1
            // 
            this.registrarProductoToolStripMenuItem1.BackColor = System.Drawing.Color.Orange;
            this.registrarProductoToolStripMenuItem1.Name = "registrarProductoToolStripMenuItem1";
            this.registrarProductoToolStripMenuItem1.Size = new System.Drawing.Size(284, 36);
            this.registrarProductoToolStripMenuItem1.Text = "Registrar Producto";
            this.registrarProductoToolStripMenuItem1.Click += new System.EventHandler(this.registrarProductoToolStripMenuItem1_Click);
            // 
            // consultarInventarioToolStripMenuItem1
            // 
            this.consultarInventarioToolStripMenuItem1.BackColor = System.Drawing.Color.Orange;
            this.consultarInventarioToolStripMenuItem1.Name = "consultarInventarioToolStripMenuItem1";
            this.consultarInventarioToolStripMenuItem1.Size = new System.Drawing.Size(284, 36);
            this.consultarInventarioToolStripMenuItem1.Text = "Consultar Inventario";
            this.consultarInventarioToolStripMenuItem1.Click += new System.EventHandler(this.consultarInventarioToolStripMenuItem1_Click);
            // 
            // listadoProveedoresToolStripMenuItem
            // 
            this.listadoProveedoresToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.listadoProveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarProveedorToolStripMenuItem1,
            this.listaDeProveedoresToolStripMenuItem});
            this.listadoProveedoresToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listadoProveedoresToolStripMenuItem.Image = global::DonJuan_Inventario.Properties.Resources.icono_3;
            this.listadoProveedoresToolStripMenuItem.Name = "listadoProveedoresToolStripMenuItem";
            this.listadoProveedoresToolStripMenuItem.Size = new System.Drawing.Size(147, 35);
            this.listadoProveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // registrarProveedorToolStripMenuItem1
            // 
            this.registrarProveedorToolStripMenuItem1.BackColor = System.Drawing.Color.Orange;
            this.registrarProveedorToolStripMenuItem1.Name = "registrarProveedorToolStripMenuItem1";
            this.registrarProveedorToolStripMenuItem1.Size = new System.Drawing.Size(275, 36);
            this.registrarProveedorToolStripMenuItem1.Text = "Registrar Proveedor";
            this.registrarProveedorToolStripMenuItem1.Click += new System.EventHandler(this.registrarProveedorToolStripMenuItem1_Click);
            // 
            // listaDeProveedoresToolStripMenuItem
            // 
            this.listaDeProveedoresToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.listaDeProveedoresToolStripMenuItem.Name = "listaDeProveedoresToolStripMenuItem";
            this.listaDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(275, 36);
            this.listaDeProveedoresToolStripMenuItem.Text = "Lista de Proveedores";
            this.listaDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.listaDeProveedoresToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCompraDeProductosToolStripMenuItem,
            this.consultarComprasDeProductosToolStripMenuItem});
            this.comprasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comprasToolStripMenuItem.Image = global::DonJuan_Inventario.Properties.Resources.icono_5;
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(123, 35);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // registrarCompraDeProductosToolStripMenuItem
            // 
            this.registrarCompraDeProductosToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.registrarCompraDeProductosToolStripMenuItem.Name = "registrarCompraDeProductosToolStripMenuItem";
            this.registrarCompraDeProductosToolStripMenuItem.Size = new System.Drawing.Size(388, 36);
            this.registrarCompraDeProductosToolStripMenuItem.Text = "Registrar Compra de Productos";
            this.registrarCompraDeProductosToolStripMenuItem.Click += new System.EventHandler(this.registrarCompraDeProductosToolStripMenuItem_Click);
            // 
            // consultarComprasDeProductosToolStripMenuItem
            // 
            this.consultarComprasDeProductosToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.consultarComprasDeProductosToolStripMenuItem.Name = "consultarComprasDeProductosToolStripMenuItem";
            this.consultarComprasDeProductosToolStripMenuItem.Size = new System.Drawing.Size(388, 36);
            this.consultarComprasDeProductosToolStripMenuItem.Text = "Consultar Compras de Productos";
            this.consultarComprasDeProductosToolStripMenuItem.Click += new System.EventHandler(this.consultarComprasDeProductosToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPedidoToolStripMenuItem,
            this.consultarPedidosToolStripMenuItem});
            this.pedidosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pedidosToolStripMenuItem.Image = global::DonJuan_Inventario.Properties.Resources.icono_8;
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(110, 35);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // registrarPedidoToolStripMenuItem
            // 
            this.registrarPedidoToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.registrarPedidoToolStripMenuItem.Name = "registrarPedidoToolStripMenuItem";
            this.registrarPedidoToolStripMenuItem.Size = new System.Drawing.Size(381, 36);
            this.registrarPedidoToolStripMenuItem.Text = "Registrar Pedido";
            this.registrarPedidoToolStripMenuItem.Visible = false;
            this.registrarPedidoToolStripMenuItem.Click += new System.EventHandler(this.registrarPedidoToolStripMenuItem_Click);
            // 
            // consultarPedidosToolStripMenuItem
            // 
            this.consultarPedidosToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.consultarPedidosToolStripMenuItem.Name = "consultarPedidosToolStripMenuItem";
            this.consultarPedidosToolStripMenuItem.Size = new System.Drawing.Size(381, 36);
            this.consultarPedidosToolStripMenuItem.Text = "Consultar Pedidos a Inventario";
            this.consultarPedidosToolStripMenuItem.Click += new System.EventHandler(this.consultarPedidosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.salirToolStripMenuItem.Image = global::DonJuan_Inventario.Properties.Resources.icono_1;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 35);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DonJuan_Inventario.Properties.Resources.Logo_con_sombra_2;
            this.pictureBox1.Location = new System.Drawing.Point(54, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(677, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::DonJuan_Inventario.Properties.Resources.Fondo_Azul;
            this.ClientSize = new System.Drawing.Size(796, 509);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProductoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarInventarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listadoProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProveedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCompraDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarComprasDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPedidosToolStripMenuItem;
    }
}