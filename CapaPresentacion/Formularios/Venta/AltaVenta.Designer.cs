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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaVenta));
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
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
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.numpCantidad = new System.Windows.Forms.NumericUpDown();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.txbDetalle = new System.Windows.Forms.TextBox();
            this.lbproducto = new System.Windows.Forms.Label();
            this.lbcantidad = new System.Windows.Forms.Label();
            this.lbDetalle = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnSig = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbVender = new System.Windows.Forms.Label();
            this.lbSubTtoal = new System.Windows.Forms.Label();
            this.txbStock = new System.Windows.Forms.TextBox();
            this.lbStock = new System.Windows.Forms.Label();
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
            this.dgvDetalle.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDetalle_CellFormatting);
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
            // cboProductos
            // 
            this.cboProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(37, 144);
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
            // lbproducto
            // 
            this.lbproducto.AutoSize = true;
            this.lbproducto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbproducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbproducto.Location = new System.Drawing.Point(37, 116);
            this.lbproducto.Name = "lbproducto";
            this.lbproducto.Size = new System.Drawing.Size(93, 23);
            this.lbproducto.TabIndex = 32;
            this.lbproducto.Text = "Producto";
            // 
            // lbcantidad
            // 
            this.lbcantidad.AutoSize = true;
            this.lbcantidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbcantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbcantidad.Location = new System.Drawing.Point(250, 116);
            this.lbcantidad.Name = "lbcantidad";
            this.lbcantidad.Size = new System.Drawing.Size(99, 23);
            this.lbcantidad.TabIndex = 33;
            this.lbcantidad.Text = "Cantidad";
            // 
            // lbDetalle
            // 
            this.lbDetalle.AutoSize = true;
            this.lbDetalle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDetalle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDetalle.Location = new System.Drawing.Point(384, 117);
            this.lbDetalle.Name = "lbDetalle";
            this.lbDetalle.Size = new System.Drawing.Size(76, 23);
            this.lbDetalle.TabIndex = 34;
            this.lbDetalle.Text = "Detalle";
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
            this.pnlHeader.Controls.Add(this.lbVender);
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
            // lbVender
            // 
            this.lbVender.AutoSize = true;
            this.lbVender.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbVender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbVender.Location = new System.Drawing.Point(73, 9);
            this.lbVender.Name = "lbVender";
            this.lbVender.Size = new System.Drawing.Size(129, 38);
            this.lbVender.TabIndex = 21;
            this.lbVender.Text = "Vender";
            // 
            // lbSubTtoal
            // 
            this.lbSubTtoal.AutoSize = true;
            this.lbSubTtoal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSubTtoal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSubTtoal.Location = new System.Drawing.Point(774, 531);
            this.lbSubTtoal.Name = "lbSubTtoal";
            this.lbSubTtoal.Size = new System.Drawing.Size(88, 23);
            this.lbSubTtoal.TabIndex = 38;
            this.lbSubTtoal.Text = "SubTotal";
            // 
            // txbStock
            // 
            this.txbStock.Enabled = false;
            this.txbStock.Location = new System.Drawing.Point(868, 142);
            this.txbStock.Name = "txbStock";
            this.txbStock.Size = new System.Drawing.Size(78, 23);
            this.txbStock.TabIndex = 39;
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbStock.Location = new System.Drawing.Point(868, 116);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(61, 23);
            this.lbStock.TabIndex = 40;
            this.lbStock.Text = "Stock";
            // 
            // AltaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(998, 676);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.txbStock);
            this.Controls.Add(this.lbSubTtoal);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.BtnSig);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.lbDetalle);
            this.Controls.Add(this.lbcantidad);
            this.Controls.Add(this.lbproducto);
            this.Controls.Add(this.txbDetalle);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.numpCantidad);
            this.Controls.Add(this.cboProductos);
            this.Controls.Add(this.dgvDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private Label lbproducto;
        private Label lbcantidad;
        private Label lbDetalle;
        private Button BtnAgregar;
        private Button BtnSig;
        private Panel pnlHeader;
        private Label lbVender;
        private Label lbSubTtoal;
        private PictureBox pictureBox1;
        private TextBox txbStock;
        private Label lbStock;
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