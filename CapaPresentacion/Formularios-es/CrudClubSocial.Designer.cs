namespace CapaPresentacion.Formularios
{
    partial class CrudClubSocial
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
            this.CodigoSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbProd = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlCrud = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxbDni = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbtTodos = new System.Windows.Forms.RadioButton();
            this.RbtEliminados = new System.Windows.Forms.RadioButton();
            this.RbtActivos = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.CodigoSocio,
            this.dni,
            this.NombreCompleto,
            this.Fecha,
            this.Email,
            this.Activo,
            this.Acciones});
            this.dgvProd.Location = new System.Drawing.Point(79, 184);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.RowHeadersVisible = false;
            this.dgvProd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProd.RowTemplate.Height = 25;
            this.dgvProd.Size = new System.Drawing.Size(870, 352);
            this.dgvProd.TabIndex = 25;
            // 
            // CodigoSocio
            // 
            this.CodigoSocio.HeaderText = "Codigo Socio";
            this.CodigoSocio.Name = "CodigoSocio";
            this.CodigoSocio.ReadOnly = true;
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 170;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha Adhesion";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 140;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 190;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Width = 82;
            // 
            // Acciones
            // 
            this.Acciones.HeaderText = "Acciones";
            this.Acciones.Name = "Acciones";
            this.Acciones.ReadOnly = true;
            this.Acciones.Width = 85;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlHeader.Controls.Add(this.lbProd);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(259, 56);
            this.pnlHeader.TabIndex = 26;
            // 
            // lbProd
            // 
            this.lbProd.AutoSize = true;
            this.lbProd.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProd.Location = new System.Drawing.Point(61, 9);
            this.lbProd.Name = "lbProd";
            this.lbProd.Size = new System.Drawing.Size(198, 38);
            this.lbProd.TabIndex = 21;
            this.lbProd.Text = "Club Socios";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(82, 574);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(139, 42);
            this.btnNuevo.TabIndex = 27;
            this.btnNuevo.Text = "Adherir";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(636, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 42);
            this.button1.TabIndex = 28;
            this.button1.Text = "Desligar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pnlCrud
            // 
            this.pnlCrud.BackColor = System.Drawing.Color.OliveDrab;
            this.pnlCrud.Controls.Add(this.label5);
            this.pnlCrud.Controls.Add(this.comboBox1);
            this.pnlCrud.Controls.Add(this.label1);
            this.pnlCrud.Controls.Add(this.textBox3);
            this.pnlCrud.Controls.Add(this.label2);
            this.pnlCrud.Controls.Add(this.textBox2);
            this.pnlCrud.Controls.Add(this.lbApellido);
            this.pnlCrud.Controls.Add(this.textBox1);
            this.pnlCrud.Controls.Add(this.lbNombre);
            this.pnlCrud.Controls.Add(this.txbNombre);
            this.pnlCrud.Controls.Add(this.label4);
            this.pnlCrud.Controls.Add(this.TxbDni);
            this.pnlCrud.Controls.Add(this.pictureBox2);
            this.pnlCrud.Controls.Add(this.pictureBox1);
            this.pnlCrud.Location = new System.Drawing.Point(79, 124);
            this.pnlCrud.Name = "pnlCrud";
            this.pnlCrud.Size = new System.Drawing.Size(870, 412);
            this.pnlCrud.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(275, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Codigo Socio";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(275, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 23);
            this.textBox3.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(47, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Email";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(47, 314);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 23);
            this.textBox2.TabIndex = 38;
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbApellido.Location = new System.Drawing.Point(275, 181);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(75, 19);
            this.lbApellido.TabIndex = 37;
            this.lbApellido.Text = "Apellido";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 23);
            this.textBox1.TabIndex = 36;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNombre.Location = new System.Drawing.Point(47, 181);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(73, 19);
            this.lbNombre.TabIndex = 35;
            this.lbNombre.Text = "Nombre";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(47, 212);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(174, 23);
            this.txbNombre.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(47, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "DNI";
            // 
            // TxbDni
            // 
            this.TxbDni.Location = new System.Drawing.Point(47, 103);
            this.TxbDni.Name = "TxbDni";
            this.TxbDni.Size = new System.Drawing.Size(174, 23);
            this.TxbDni.TabIndex = 31;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.limpieza_de_datos;
            this.pictureBox2.Location = new System.Drawing.Point(755, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.abajo1;
            this.pictureBox1.Location = new System.Drawing.Point(820, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // rbtTodos
            // 
            this.rbtTodos.AutoSize = true;
            this.rbtTodos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtTodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtTodos.Location = new System.Drawing.Point(876, 152);
            this.rbtTodos.Name = "rbtTodos";
            this.rbtTodos.Size = new System.Drawing.Size(73, 25);
            this.rbtTodos.TabIndex = 36;
            this.rbtTodos.TabStop = true;
            this.rbtTodos.Text = "Todos";
            this.rbtTodos.UseVisualStyleBackColor = true;
            // 
            // RbtEliminados
            // 
            this.RbtEliminados.AutoSize = true;
            this.RbtEliminados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtEliminados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtEliminados.Location = new System.Drawing.Point(761, 152);
            this.RbtEliminados.Name = "RbtEliminados";
            this.RbtEliminados.Size = new System.Drawing.Size(109, 25);
            this.RbtEliminados.TabIndex = 35;
            this.RbtEliminados.TabStop = true;
            this.RbtEliminados.Text = "Eliminados";
            this.RbtEliminados.UseVisualStyleBackColor = true;
            // 
            // RbtActivos
            // 
            this.RbtActivos.AutoSize = true;
            this.RbtActivos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtActivos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtActivos.Location = new System.Drawing.Point(668, 152);
            this.RbtActivos.Name = "RbtActivos";
            this.RbtActivos.Size = new System.Drawing.Size(87, 25);
            this.RbtActivos.TabIndex = 34;
            this.RbtActivos.TabStop = true;
            this.RbtActivos.Text = "Activos";
            this.RbtActivos.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(326, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(84, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "DNI";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(84, 155);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(174, 23);
            this.textBox4.TabIndex = 37;
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
            this.button3.Location = new System.Drawing.Point(274, 574);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 42);
            this.button3.TabIndex = 40;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = false;
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
            this.button4.Location = new System.Drawing.Point(458, 574);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 42);
            this.button4.TabIndex = 41;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(810, 574);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 42);
            this.button5.TabIndex = 42;
            this.button5.Text = "Guardar";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(275, 314);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 23);
            this.comboBox1.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(275, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 19);
            this.label5.TabIndex = 43;
            this.label5.Text = "Tipo de Clientes";
            // 
            // CrudClubSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(998, 676);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pnlCrud);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvProd);
            this.Controls.Add(this.rbtTodos);
            this.Controls.Add(this.RbtEliminados);
            this.Controls.Add(this.RbtActivos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrudClubSocial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrudClubSocial";
            this.Load += new System.EventHandler(this.CrudClubSocial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCrud.ResumeLayout(false);
            this.pnlCrud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvProd;
        private DataGridViewTextBoxColumn CodigoSocio;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Activo;
        private DataGridViewButtonColumn Acciones;
        private Panel pnlHeader;
        private Label lbProd;
        private Button btnNuevo;
        private Button button1;
        private Panel pnlCrud;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox TxbDni;
        private Label label1;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label lbApellido;
        private TextBox textBox1;
        private Label lbNombre;
        private TextBox txbNombre;
        private RadioButton rbtTodos;
        private RadioButton RbtEliminados;
        private RadioButton RbtActivos;
        private Button button2;
        private Label label3;
        private TextBox textBox4;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label5;
        private ComboBox comboBox1;
    }
}