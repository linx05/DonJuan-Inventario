namespace DonJuan_Inventario
{
    partial class ConsultarPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarPedidos));
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtgPedidos = new System.Windows.Forms.DataGridView();
            this.IDPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(367, 401);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(133, 45);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtgPedidos
            // 
            this.dtgPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPedido,
            this.Producto,
            this.CantidadPedido,
            this.FechaPedido,
            this.EstadoPedido});
            this.dtgPedidos.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgPedidos.EnableHeadersVisualStyles = false;
            this.dtgPedidos.Location = new System.Drawing.Point(10, 96);
            this.dtgPedidos.Name = "dtgPedidos";
            this.dtgPedidos.ReadOnly = true;
            this.dtgPedidos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtgPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgPedidos.RowHeadersVisible = false;
            this.dtgPedidos.Size = new System.Drawing.Size(810, 290);
            this.dtgPedidos.StandardTab = true;
            this.dtgPedidos.TabIndex = 19;
            // 
            // IDPedido
            // 
            this.IDPedido.HeaderText = "ID Pedido";
            this.IDPedido.Name = "IDPedido";
            this.IDPedido.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // CantidadPedido
            // 
            this.CantidadPedido.HeaderText = "Cantidad";
            this.CantidadPedido.Name = "CantidadPedido";
            this.CantidadPedido.ReadOnly = true;
            // 
            // FechaPedido
            // 
            this.FechaPedido.HeaderText = "Fecha";
            this.FechaPedido.Name = "FechaPedido";
            this.FechaPedido.ReadOnly = true;
            // 
            // EstadoPedido
            // 
            this.EstadoPedido.HeaderText = "Estado";
            this.EstadoPedido.Name = "EstadoPedido";
            this.EstadoPedido.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(227, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(341, 42);
            this.label7.TabIndex = 18;
            this.label7.Text = "Consultar Pedidos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DonJuan_Inventario.Properties.Resources.logotipo_don_juan;
            this.pictureBox1.Location = new System.Drawing.Point(574, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // ConsultarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 473);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgPedidos);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultarPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dtgPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoPedido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}