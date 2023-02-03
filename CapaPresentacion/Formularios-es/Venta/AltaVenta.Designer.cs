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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipoprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medidaprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accionm = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnSig = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbProd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToAddRows = false;
            this.dgvProd.AllowUserToDeleteRows = false;
            this.dgvProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dgvProd.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.detalle,
            this.Tipoprod,
            this.Medidaprod,
            this.clasi,
            this.Cantidad,
            this.Precio,
            this.Tot,
            this.Accionm});
            this.dgvProd.Location = new System.Drawing.Point(36, 181);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.RowHeadersVisible = false;
            this.dgvProd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProd.RowTemplate.Height = 25;
            this.dgvProd.Size = new System.Drawing.Size(932, 333);
            this.dgvProd.TabIndex = 21;
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
            // Accionm
            // 
            this.Accionm.HeaderText = "Accion";
            this.Accionm.Name = "Accionm";
            this.Accionm.ReadOnly = true;
            this.Accionm.Width = 70;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(37, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 23);
            this.comboBox1.TabIndex = 22;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(255, 142);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(99, 23);
            this.numericUpDown1.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(868, 531);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 28;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(393, 142);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 23);
            this.textBox4.TabIndex = 30;
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
            this.label3.Location = new System.Drawing.Point(255, 116);
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
            this.label4.Location = new System.Drawing.Point(393, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Detalle";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.White;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Location = new System.Drawing.Point(634, 136);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(78, 30);
            this.BtnLogin.TabIndex = 35;
            this.BtnLogin.Text = "Agregar";
            this.BtnLogin.UseVisualStyleBackColor = false;
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
            this.pnlHeader.Controls.Add(this.lbProd);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(202, 56);
            this.pnlHeader.TabIndex = 37;
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
            this.label1.Location = new System.Drawing.Point(797, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "Total";
            // 
            // AltaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(998, 676);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.BtnSig);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaVenta";
            this.Text = "AltaVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvProd;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn detalle;
        private DataGridViewTextBoxColumn Tipoprod;
        private DataGridViewTextBoxColumn Medidaprod;
        private DataGridViewTextBoxColumn clasi;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Tot;
        private DataGridViewButtonColumn Accionm;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnLogin;
        private Button BtnSig;
        private Panel pnlHeader;
        private Label lbProd;
        private Label label1;
    }
}