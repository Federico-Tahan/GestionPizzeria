namespace CapaPresentacion.Formularios.Venta
{
    partial class ConsultaEdicionBajaVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.Nroventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formapedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbProd = new System.Windows.Forms.Label();
            this.rbtTodos = new System.Windows.Forms.RadioButton();
            this.RbtEliminados = new System.Windows.Forms.RadioButton();
            this.RbtActivos = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSig = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToAddRows = false;
            this.dgvProd.AllowUserToDeleteRows = false;
            this.dgvProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dgvProd.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nroventa,
            this.Cliente,
            this.fecha,
            this.Formapedido,
            this.Descuento,
            this.Total,
            this.Estado,
            this.Accion});
            this.dgvProd.Location = new System.Drawing.Point(73, 163);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.RowHeadersVisible = false;
            this.dgvProd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProd.RowTemplate.Height = 25;
            this.dgvProd.Size = new System.Drawing.Size(870, 399);
            this.dgvProd.TabIndex = 26;
            // 
            // Nroventa
            // 
            this.Nroventa.HeaderText = "Nro Venta";
            this.Nroventa.Name = "Nroventa";
            this.Nroventa.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Nombre Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 140;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 110;
            // 
            // Formapedido
            // 
            this.Formapedido.HeaderText = "Forma de pedido";
            this.Formapedido.Name = "Formapedido";
            this.Formapedido.ReadOnly = true;
            this.Formapedido.Width = 110;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 107;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlHeader.Controls.Add(this.lbProd);
            this.pnlHeader.Location = new System.Drawing.Point(0, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(202, 56);
            this.pnlHeader.TabIndex = 38;
            // 
            // lbProd
            // 
            this.lbProd.AutoSize = true;
            this.lbProd.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProd.Location = new System.Drawing.Point(73, 9);
            this.lbProd.Name = "lbProd";
            this.lbProd.Size = new System.Drawing.Size(123, 38);
            this.lbProd.TabIndex = 21;
            this.lbProd.Text = "Ventas";
            // 
            // rbtTodos
            // 
            this.rbtTodos.AutoSize = true;
            this.rbtTodos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtTodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtTodos.Location = new System.Drawing.Point(869, 132);
            this.rbtTodos.Name = "rbtTodos";
            this.rbtTodos.Size = new System.Drawing.Size(73, 25);
            this.rbtTodos.TabIndex = 41;
            this.rbtTodos.TabStop = true;
            this.rbtTodos.Text = "Todos";
            this.rbtTodos.UseVisualStyleBackColor = true;
            // 
            // RbtEliminados
            // 
            this.RbtEliminados.AutoSize = true;
            this.RbtEliminados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtEliminados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtEliminados.Location = new System.Drawing.Point(754, 132);
            this.RbtEliminados.Name = "RbtEliminados";
            this.RbtEliminados.Size = new System.Drawing.Size(109, 25);
            this.RbtEliminados.TabIndex = 40;
            this.RbtEliminados.TabStop = true;
            this.RbtEliminados.Text = "Eliminados";
            this.RbtEliminados.UseVisualStyleBackColor = true;
            // 
            // RbtActivos
            // 
            this.RbtActivos.AutoSize = true;
            this.RbtActivos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtActivos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtActivos.Location = new System.Drawing.Point(661, 132);
            this.RbtActivos.Name = "RbtActivos";
            this.RbtActivos.Size = new System.Drawing.Size(87, 25);
            this.RbtActivos.TabIndex = 39;
            this.RbtActivos.TabStop = true;
            this.RbtActivos.Text = "Activos";
            this.RbtActivos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnSig);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 678);
            this.panel1.TabIndex = 42;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(800, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 49;
            this.label1.Text = "Total";
            // 
            // BtnSig
            // 
            this.BtnSig.BackColor = System.Drawing.Color.White;
            this.BtnSig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSig.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.BtnSig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSig.Location = new System.Drawing.Point(851, 601);
            this.BtnSig.Name = "BtnSig";
            this.BtnSig.Size = new System.Drawing.Size(120, 36);
            this.BtnSig.TabIndex = 48;
            this.BtnSig.Text = "Siguiente";
            this.BtnSig.UseVisualStyleBackColor = false;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.White;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Location = new System.Drawing.Point(637, 166);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(78, 30);
            this.BtnLogin.TabIndex = 47;
            this.BtnLogin.Text = "Agregar";
            this.BtnLogin.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(396, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 46;
            this.label4.Text = "Detalle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(258, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 45;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(40, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "Producto";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(396, 172);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 23);
            this.textBox4.TabIndex = 43;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(871, 561);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 42;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(258, 172);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(99, 23);
            this.numericUpDown1.TabIndex = 41;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 23);
            this.comboBox1.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.Location = new System.Drawing.Point(39, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(932, 333);
            this.dataGridView1.TabIndex = 39;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 56);
            this.panel2.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(73, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 38);
            this.label5.TabIndex = 21;
            this.label5.Text = "Modificar Venta";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(512, 582);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 42);
            this.button4.TabIndex = 44;
            this.button4.Text = "Bajar Venta";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(328, 582);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 42);
            this.button3.TabIndex = 43;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // ConsultaEdicionBajaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(998, 676);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbtTodos);
            this.Controls.Add(this.RbtEliminados);
            this.Controls.Add(this.RbtActivos);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaEdicionBajaVentas";
            this.Text = "ConsultaEdicionBajaVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvProd;
        private DataGridViewTextBoxColumn Nroventa;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn Formapedido;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Accion;
        private Panel pnlHeader;
        private Label lbProd;
        private RadioButton rbtTodos;
        private RadioButton RbtEliminados;
        private RadioButton RbtActivos;
        private Panel panel1;
        private Label label1;
        private Button BtnSig;
        private Button BtnLogin;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox3;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
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
        private Panel panel2;
        private Label label5;
        private Button button4;
        private Button button3;
    }
}