namespace CapaPresentacion.Formularios.Venta
{
    partial class AltaVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.numpCantidad = new System.Windows.Forms.NumericUpDown();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.txbDetalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnSig = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbProd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipoprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medidaprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpCantidad)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dgvDetalle.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.detalle,
            this.Tipoprod,
            this.Medidaprod,
            this.clasi,
            this.Cantidad,
            this.Precio,
            this.Tot,
            this.Accion});
            this.dgvDetalle.Location = new System.Drawing.Point(36, 181);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetalle.RowTemplate.Height = 25;
            this.dgvDetalle.Size = new System.Drawing.Size(932, 333);
            this.dgvDetalle.TabIndex = 21;
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Boton_Quitar);
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(37, 142);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(198, 23);
            this.cboProductos.TabIndex = 22;
            this.cboProductos.SelectionChangeCommitted += new System.EventHandler(this.cboProductos_SelectionChangeCommitted);
            this.cboProductos.SelectedValueChanged += new System.EventHandler(this.Producto_Cambia);
            // 
            // numpCantidad
            // 
            this.numpCantidad.Location = new System.Drawing.Point(250, 143);
            this.numpCantidad.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numpCantidad.Name = "numpCantidad";
            this.numpCantidad.Size = new System.Drawing.Size(99, 23);
            this.numpCantidad.TabIndex = 23;
            // 
            // txbTotal
            // 
            this.txbTotal.Enabled = false;
            this.txbTotal.Location = new System.Drawing.Point(868, 531);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(100, 23);
            this.txbTotal.TabIndex = 28;
            // 
            // txbDetalle
            // 
            this.txbDetalle.Location = new System.Drawing.Point(384, 143);
            this.txbDetalle.Name = "txbDetalle";
            this.txbDetalle.Size = new System.Drawing.Size(212, 23);
            this.txbDetalle.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(37, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(250, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(384, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Detalle";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.White;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(618, 137);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(78, 30);
            this.BtnAgregar.TabIndex = 35;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnSig
            // 
            this.BtnSig.BackColor = System.Drawing.Color.White;
            this.BtnSig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSig.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.BtnSig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSig.Location = new System.Drawing.Point(848, 571);
            this.BtnSig.Name = "BtnSig";
            this.BtnSig.Size = new System.Drawing.Size(120, 36);
            this.BtnSig.TabIndex = 36;
            this.BtnSig.Text = "Siguiente";
            this.BtnSig.UseVisualStyleBackColor = false;
            this.BtnSig.Click += new System.EventHandler(this.BtnSig_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.lbProd);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(202, 56);
            this.pnlHeader.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.compras__1_;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // lbProd
            // 
            this.lbProd.AutoSize = true;
            this.lbProd.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProd.Location = new System.Drawing.Point(73, 9);
            this.lbProd.Name = "lbProd";
            this.lbProd.Size = new System.Drawing.Size(129, 38);
            this.lbProd.TabIndex = 21;
            this.lbProd.Text = "Vender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(774, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "SubTotal";
            // 
            // txbStock
            // 
            this.txbStock.Enabled = false;
            this.txbStock.Location = new System.Drawing.Point(868, 142);
            this.txbStock.Name = "txbStock";
            this.txbStock.Size = new System.Drawing.Size(78, 23);
            this.txbStock.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(868, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Stock";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo Producto";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 70;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // detalle
            // 
            this.detalle.HeaderText = "Detalle";
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Width = 149;
            // 
            // Tipoprod
            // 
            this.Tipoprod.HeaderText = "Tipo Producto";
            this.Tipoprod.Name = "Tipoprod";
            this.Tipoprod.ReadOnly = true;
            // 
            // Medidaprod
            // 
            this.Medidaprod.HeaderText = "Unidad Medida";
            this.Medidaprod.Name = "Medidaprod";
            this.Medidaprod.ReadOnly = true;
            this.Medidaprod.Width = 70;
            // 
            // clasi
            // 
            this.clasi.HeaderText = "Clasificacion";
            this.clasi.Name = "clasi";
            this.clasi.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 70;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Tot
            // 
            this.Tot.HeaderText = "Total";
            this.Tot.Name = "Tot";
            this.Tot.ReadOnly = true;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            this.Accion.Text = "Quitar";
            this.Accion.UseColumnTextForButtonValue = true;
            this.Accion.Width = 70;
            // 
            // AltaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(998, 676);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.BtnSig);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbDetalle);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.numpCantidad);
            this.Controls.Add(this.cboProductos);
            this.Controls.Add(this.dgvDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaVenta";
            this.Text = "AltaVenta";
            this.Load += new System.EventHandler(this.AltaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpCantidad)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvDetalle;
        private ComboBox cboProductos;
        private NumericUpDown numpCantidad;
        private TextBox txbTotal;
        private TextBox txbDetalle;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnAgregar;
        private Button BtnSig;
        private Panel pnlHeader;
        private Label lbProd;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txbStock;
        private Label label5;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn detalle;
        private DataGridViewTextBoxColumn Tipoprod;
        private DataGridViewTextBoxColumn Medidaprod;
        private DataGridViewTextBoxColumn clasi;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Tot;
        private DataGridViewButtonColumn Accion;
    }
}