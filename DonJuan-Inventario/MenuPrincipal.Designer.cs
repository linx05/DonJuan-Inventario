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
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listadoProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProveedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProductoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarInventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCompraDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarComprasDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.listadoProveedoresToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(529, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DonJuan_Inventario.Properties.Resources.logotipo_don_juan;
            this.pictureBox1.Location = new System.Drawing.Point(12, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // listadoProveedoresToolStripMenuItem
            // 
            this.listadoProveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarProveedorToolStripMenuItem1,
            this.listaDeProveedoresToolStripMenuItem});
            this.listadoProveedoresToolStripMenuItem.Name = "listadoProveedoresToolStripMenuItem";
            this.listadoProveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.listadoProveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // registrarProveedorToolStripMenuItem1
            // 
            this.registrarProveedorToolStripMenuItem1.Name = "registrarProveedorToolStripMenuItem1";
            this.registrarProveedorToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.registrarProveedorToolStripMenuItem1.Text = "Registrar Proveedor";
            this.registrarProveedorToolStripMenuItem1.Click += new System.EventHandler(this.registrarProveedorToolStripMenuItem1_Click);
            // 
            // listaDeProveedoresToolStripMenuItem
            // 
            this.listaDeProveedoresToolStripMenuItem.Name = "listaDeProveedoresToolStripMenuItem";
            this.listaDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.listaDeProveedoresToolStripMenuItem.Text = "Lista de Proveedores";
            this.listaDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.listaDeProveedoresToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarProductoToolStripMenuItem1,
            this.consultarInventarioToolStripMenuItem1});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // registrarProductoToolStripMenuItem1
            // 
            this.registrarProductoToolStripMenuItem1.Name = "registrarProductoToolStripMenuItem1";
            this.registrarProductoToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.registrarProductoToolStripMenuItem1.Text = "Registrar Producto";
            this.registrarProductoToolStripMenuItem1.Click += new System.EventHandler(this.registrarProductoToolStripMenuItem1_Click);
            // 
            // consultarInventarioToolStripMenuItem1
            // 
            this.consultarInventarioToolStripMenuItem1.Name = "consultarInventarioToolStripMenuItem1";
            this.consultarInventarioToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.consultarInventarioToolStripMenuItem1.Text = "Consultar Inventario";
            this.consultarInventarioToolStripMenuItem1.Click += new System.EventHandler(this.consultarInventarioToolStripMenuItem1_Click);
            // 
            // registrarPedidoToolStripMenuItem
            // 
            this.registrarPedidoToolStripMenuItem.Name = "registrarPedidoToolStripMenuItem";
            this.registrarPedidoToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.registrarPedidoToolStripMenuItem.Text = "Registrar Pedido";
            this.registrarPedidoToolStripMenuItem.Visible = false;
            this.registrarPedidoToolStripMenuItem.Click += new System.EventHandler(this.registrarPedidoToolStripMenuItem_Click);
            // 
            // consultarPedidosToolStripMenuItem
            // 
            this.consultarPedidosToolStripMenuItem.Name = "consultarPedidosToolStripMenuItem";
            this.consultarPedidosToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.consultarPedidosToolStripMenuItem.Text = "Consultar Pedidos a Inventario";
            this.consultarPedidosToolStripMenuItem.Click += new System.EventHandler(this.consultarPedidosToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPedidoToolStripMenuItem,
            this.consultarPedidosToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCompraDeProductosToolStripMenuItem,
            this.consultarComprasDeProductosToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // registrarCompraDeProductosToolStripMenuItem
            // 
            this.registrarCompraDeProductosToolStripMenuItem.Name = "registrarCompraDeProductosToolStripMenuItem";
            this.registrarCompraDeProductosToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.registrarCompraDeProductosToolStripMenuItem.Text = "Registrar Compra de Productos";
            this.registrarCompraDeProductosToolStripMenuItem.Click += new System.EventHandler(this.registrarCompraDeProductosToolStripMenuItem_Click);
            // 
            // consultarComprasDeProductosToolStripMenuItem
            // 
            this.consultarComprasDeProductosToolStripMenuItem.Name = "consultarComprasDeProductosToolStripMenuItem";
            this.consultarComprasDeProductosToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.consultarComprasDeProductosToolStripMenuItem.Text = "Consultar Compras de Productos";
            this.consultarComprasDeProductosToolStripMenuItem.Click += new System.EventHandler(this.consultarComprasDeProductosToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 389);
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