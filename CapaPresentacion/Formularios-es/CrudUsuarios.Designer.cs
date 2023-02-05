namespace CapaPresentacion.Formularios
{
    partial class CrudUsuarios
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbProd = new System.Windows.Forms.Label();
            this.pnlCrud = new System.Windows.Forms.Panel();
            this.txbIDEmpleado = new System.Windows.Forms.TextBox();
            this.lbFechaNac = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.picContraseña = new System.Windows.Forms.PictureBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxbAlias = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxbContraseña = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CboRoles = new System.Windows.Forms.ComboBox();
            this.lbCOD = new System.Windows.Forms.Label();
            this.txbCod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxbDni = new System.Windows.Forms.TextBox();
            this.lbTel = new System.Windows.Forms.Label();
            this.TxbTelefono = new System.Windows.Forms.TextBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.picLimpiar = new System.Windows.Forms.PictureBox();
            this.picBajar = new System.Windows.Forms.PictureBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.codigoUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.rbtTodos = new System.Windows.Forms.RadioButton();
            this.RbtEliminados = new System.Windows.Forms.RadioButton();
            this.RbtActivos = new System.Windows.Forms.RadioButton();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txbbusqueda = new System.Windows.Forms.TextBox();
            this.RbtNombre = new System.Windows.Forms.RadioButton();
            this.RbtCodigo = new System.Windows.Forms.RadioButton();
            this.RbtDNI = new System.Windows.Forms.RadioButton();
            this.RbtAlias = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picreset = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBajar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picreset)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.lbProd);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(215, 56);
            this.pnlHeader.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Usuarios;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // lbProd
            // 
            this.lbProd.AutoSize = true;
            this.lbProd.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProd.Location = new System.Drawing.Point(72, 9);
            this.lbProd.Name = "lbProd";
            this.lbProd.Size = new System.Drawing.Size(143, 38);
            this.lbProd.TabIndex = 21;
            this.lbProd.Text = "Usuarios";
            // 
            // pnlCrud
            // 
            this.pnlCrud.BackColor = System.Drawing.Color.OliveDrab;
            this.pnlCrud.Controls.Add(this.txbIDEmpleado);
            this.pnlCrud.Controls.Add(this.lbFechaNac);
            this.pnlCrud.Controls.Add(this.dateTimePicker1);
            this.pnlCrud.Controls.Add(this.lbDireccion);
            this.pnlCrud.Controls.Add(this.txbDireccion);
            this.pnlCrud.Controls.Add(this.picContraseña);
            this.pnlCrud.Controls.Add(this.chkActivo);
            this.pnlCrud.Controls.Add(this.label7);
            this.pnlCrud.Controls.Add(this.TxbAlias);
            this.pnlCrud.Controls.Add(this.label8);
            this.pnlCrud.Controls.Add(this.TxbContraseña);
            this.pnlCrud.Controls.Add(this.label6);
            this.pnlCrud.Controls.Add(this.CboRoles);
            this.pnlCrud.Controls.Add(this.lbCOD);
            this.pnlCrud.Controls.Add(this.txbCod);
            this.pnlCrud.Controls.Add(this.label4);
            this.pnlCrud.Controls.Add(this.TxbDni);
            this.pnlCrud.Controls.Add(this.lbTel);
            this.pnlCrud.Controls.Add(this.TxbTelefono);
            this.pnlCrud.Controls.Add(this.lbApellido);
            this.pnlCrud.Controls.Add(this.txbApellido);
            this.pnlCrud.Controls.Add(this.lbNombre);
            this.pnlCrud.Controls.Add(this.txbNombre);
            this.pnlCrud.Controls.Add(this.picLimpiar);
            this.pnlCrud.Controls.Add(this.picBajar);
            this.pnlCrud.Location = new System.Drawing.Point(39, 107);
            this.pnlCrud.Name = "pnlCrud";
            this.pnlCrud.Size = new System.Drawing.Size(935, 448);
            this.pnlCrud.TabIndex = 25;
            this.pnlCrud.Visible = false;
            // 
            // txbIDEmpleado
            // 
            this.txbIDEmpleado.Enabled = false;
            this.txbIDEmpleado.Location = new System.Drawing.Point(838, 96);
            this.txbIDEmpleado.Name = "txbIDEmpleado";
            this.txbIDEmpleado.Size = new System.Drawing.Size(88, 23);
            this.txbIDEmpleado.TabIndex = 45;
            this.txbIDEmpleado.Visible = false;
            // 
            // lbFechaNac
            // 
            this.lbFechaNac.AutoSize = true;
            this.lbFechaNac.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFechaNac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbFechaNac.Location = new System.Drawing.Point(519, 171);
            this.lbFechaNac.Name = "lbFechaNac";
            this.lbFechaNac.Size = new System.Drawing.Size(178, 19);
            this.lbFechaNac.TabIndex = 44;
            this.lbFechaNac.Text = "Fecha de Nacimiento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(519, 202);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(119, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDireccion.Location = new System.Drawing.Point(44, 171);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(83, 19);
            this.lbDireccion.TabIndex = 42;
            this.lbDireccion.Text = "Direccion";
            // 
            // txbDireccion
            // 
            this.txbDireccion.Enabled = false;
            this.txbDireccion.Location = new System.Drawing.Point(44, 202);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(174, 23);
            this.txbDireccion.TabIndex = 3;
            // 
            // picContraseña
            // 
            this.picContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picContraseña.Image = global::CapaPresentacion.Properties.Resources.mostrar;
            this.picContraseña.Location = new System.Drawing.Point(452, 309);
            this.picContraseña.Name = "picContraseña";
            this.picContraseña.Size = new System.Drawing.Size(33, 30);
            this.picContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picContraseña.TabIndex = 40;
            this.picContraseña.TabStop = false;
            this.picContraseña.Tag = "activar";
            this.picContraseña.Click += new System.EventHandler(this.picContraseña_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Enabled = false;
            this.chkActivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkActivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkActivo.Location = new System.Drawing.Point(744, 310);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(77, 23);
            this.chkActivo.TabIndex = 9;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(44, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "Alias";
            // 
            // TxbAlias
            // 
            this.TxbAlias.Enabled = false;
            this.TxbAlias.Location = new System.Drawing.Point(44, 312);
            this.TxbAlias.Name = "TxbAlias";
            this.TxbAlias.Size = new System.Drawing.Size(174, 23);
            this.TxbAlias.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(272, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 36;
            this.label8.Text = "Contraseña";
            // 
            // TxbContraseña
            // 
            this.TxbContraseña.Enabled = false;
            this.TxbContraseña.Location = new System.Drawing.Point(272, 312);
            this.TxbContraseña.Name = "TxbContraseña";
            this.TxbContraseña.Size = new System.Drawing.Size(174, 23);
            this.TxbContraseña.TabIndex = 7;
            this.TxbContraseña.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(519, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Roles";
            // 
            // CboRoles
            // 
            this.CboRoles.Enabled = false;
            this.CboRoles.FormattingEnabled = true;
            this.CboRoles.Location = new System.Drawing.Point(519, 312);
            this.CboRoles.Name = "CboRoles";
            this.CboRoles.Size = new System.Drawing.Size(174, 23);
            this.CboRoles.TabIndex = 8;
            // 
            // lbCOD
            // 
            this.lbCOD.AutoSize = true;
            this.lbCOD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCOD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCOD.Location = new System.Drawing.Point(733, 65);
            this.lbCOD.Name = "lbCOD";
            this.lbCOD.Size = new System.Drawing.Size(67, 19);
            this.lbCOD.TabIndex = 32;
            this.lbCOD.Text = "Código";
            // 
            // txbCod
            // 
            this.txbCod.Enabled = false;
            this.txbCod.Location = new System.Drawing.Point(733, 96);
            this.txbCod.Name = "txbCod";
            this.txbCod.Size = new System.Drawing.Size(88, 23);
            this.txbCod.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(519, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "DNI";
            // 
            // TxbDni
            // 
            this.TxbDni.Enabled = false;
            this.TxbDni.Location = new System.Drawing.Point(519, 96);
            this.TxbDni.Name = "TxbDni";
            this.TxbDni.Size = new System.Drawing.Size(174, 23);
            this.TxbDni.TabIndex = 2;
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTel.Location = new System.Drawing.Point(272, 171);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(74, 19);
            this.lbTel.TabIndex = 28;
            this.lbTel.Text = "Telefono";
            // 
            // TxbTelefono
            // 
            this.TxbTelefono.Enabled = false;
            this.TxbTelefono.Location = new System.Drawing.Point(272, 202);
            this.TxbTelefono.Name = "TxbTelefono";
            this.TxbTelefono.Size = new System.Drawing.Size(174, 23);
            this.TxbTelefono.TabIndex = 4;
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbApellido.Location = new System.Drawing.Point(272, 65);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(75, 19);
            this.lbApellido.TabIndex = 24;
            this.lbApellido.Text = "Apellido";
            // 
            // txbApellido
            // 
            this.txbApellido.Enabled = false;
            this.txbApellido.Location = new System.Drawing.Point(273, 96);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(174, 23);
            this.txbApellido.TabIndex = 1;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNombre.Location = new System.Drawing.Point(44, 65);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(73, 19);
            this.lbNombre.TabIndex = 22;
            this.lbNombre.Text = "Nombre";
            // 
            // txbNombre
            // 
            this.txbNombre.Enabled = false;
            this.txbNombre.Location = new System.Drawing.Point(44, 96);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(174, 23);
            this.txbNombre.TabIndex = 0;
            // 
            // picLimpiar
            // 
            this.picLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLimpiar.Image = global::CapaPresentacion.Properties.Resources.limpieza_de_datos;
            this.picLimpiar.Location = new System.Drawing.Point(821, 5);
            this.picLimpiar.Name = "picLimpiar";
            this.picLimpiar.Size = new System.Drawing.Size(47, 43);
            this.picLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLimpiar.TabIndex = 20;
            this.picLimpiar.TabStop = false;
            this.picLimpiar.Click += new System.EventHandler(this.picLimpiar_Click);
            // 
            // picBajar
            // 
            this.picBajar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBajar.Image = global::CapaPresentacion.Properties.Resources.abajo1;
            this.picBajar.Location = new System.Drawing.Point(879, 5);
            this.picBajar.Name = "picBajar";
            this.picBajar.Size = new System.Drawing.Size(47, 43);
            this.picBajar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBajar.TabIndex = 19;
            this.picBajar.TabStop = false;
            this.picBajar.Click += new System.EventHandler(this.picBajar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dgvUsuarios.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoUser,
            this.dni,
            this.nombre,
            this.Alias,
            this.Rol,
            this.activo,
            this.accion});
            this.dgvUsuarios.Location = new System.Drawing.Point(42, 149);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsuarios.RowTemplate.Height = 25;
            this.dgvUsuarios.Size = new System.Drawing.Size(932, 406);
            this.dgvUsuarios.TabIndex = 24;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Click_Detalle);
            // 
            // codigoUser
            // 
            this.codigoUser.HeaderText = "Código Usuario";
            this.codigoUser.Name = "codigoUser";
            this.codigoUser.ReadOnly = true;
            this.codigoUser.Width = 120;
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.Width = 130;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre Completo";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 220;
            // 
            // Alias
            // 
            this.Alias.HeaderText = "Alias";
            this.Alias.Name = "Alias";
            this.Alias.ReadOnly = true;
            this.Alias.Width = 120;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 140;
            // 
            // activo
            // 
            this.activo.HeaderText = "Activo";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            // 
            // accion
            // 
            this.accion.HeaderText = "Accion";
            this.accion.Name = "accion";
            this.accion.ReadOnly = true;
            this.accion.Text = "Detalle";
            this.accion.ToolTipText = "Detalle";
            this.accion.UseColumnTextForButtonValue = true;
            this.accion.Width = 99;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.Enabled = false;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(766, 570);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(139, 42);
            this.BtnGuardar.TabIndex = 3;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.Enabled = false;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(567, 570);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(139, 42);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.Enabled = false;
            this.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(344, 570);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(139, 42);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
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
            this.btnNuevo.Location = new System.Drawing.Point(118, 570);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(139, 42);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // rbtTodos
            // 
            this.rbtTodos.AutoSize = true;
            this.rbtTodos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtTodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtTodos.Location = new System.Drawing.Point(210, 8);
            this.rbtTodos.Name = "rbtTodos";
            this.rbtTodos.Size = new System.Drawing.Size(73, 25);
            this.rbtTodos.TabIndex = 33;
            this.rbtTodos.Text = "Todos";
            this.rbtTodos.UseVisualStyleBackColor = true;
            this.rbtTodos.CheckedChanged += new System.EventHandler(this.rbtTodos_CheckedChanged);
            // 
            // RbtEliminados
            // 
            this.RbtEliminados.AutoSize = true;
            this.RbtEliminados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtEliminados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtEliminados.Location = new System.Drawing.Point(95, 8);
            this.RbtEliminados.Name = "RbtEliminados";
            this.RbtEliminados.Size = new System.Drawing.Size(109, 25);
            this.RbtEliminados.TabIndex = 32;
            this.RbtEliminados.Text = "Eliminados";
            this.RbtEliminados.UseVisualStyleBackColor = true;
            this.RbtEliminados.CheckedChanged += new System.EventHandler(this.RbtEliminados_CheckedChanged);
            // 
            // RbtActivos
            // 
            this.RbtActivos.AutoSize = true;
            this.RbtActivos.Checked = true;
            this.RbtActivos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtActivos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtActivos.Location = new System.Drawing.Point(3, 8);
            this.RbtActivos.Name = "RbtActivos";
            this.RbtActivos.Size = new System.Drawing.Size(87, 25);
            this.RbtActivos.TabIndex = 31;
            this.RbtActivos.TabStop = true;
            this.RbtActivos.Text = "Activos";
            this.RbtActivos.UseVisualStyleBackColor = true;
            this.RbtActivos.CheckedChanged += new System.EventHandler(this.RbtActivos_CheckedChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(530, 113);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(71, 23);
            this.BtnBuscar.TabIndex = 35;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txbbusqueda
            // 
            this.txbbusqueda.Location = new System.Drawing.Point(356, 113);
            this.txbbusqueda.Name = "txbbusqueda";
            this.txbbusqueda.Size = new System.Drawing.Size(153, 23);
            this.txbbusqueda.TabIndex = 34;
            // 
            // RbtNombre
            // 
            this.RbtNombre.AutoSize = true;
            this.RbtNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtNombre.Location = new System.Drawing.Point(135, 110);
            this.RbtNombre.Name = "RbtNombre";
            this.RbtNombre.Size = new System.Drawing.Size(86, 24);
            this.RbtNombre.TabIndex = 46;
            this.RbtNombre.Text = "Nombre";
            this.RbtNombre.UseVisualStyleBackColor = true;
            // 
            // RbtCodigo
            // 
            this.RbtCodigo.AutoSize = true;
            this.RbtCodigo.Checked = true;
            this.RbtCodigo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtCodigo.Location = new System.Drawing.Point(47, 110);
            this.RbtCodigo.Name = "RbtCodigo";
            this.RbtCodigo.Size = new System.Drawing.Size(82, 24);
            this.RbtCodigo.TabIndex = 45;
            this.RbtCodigo.TabStop = true;
            this.RbtCodigo.Text = "Codigo";
            this.RbtCodigo.UseVisualStyleBackColor = true;
            // 
            // RbtDNI
            // 
            this.RbtDNI.AutoSize = true;
            this.RbtDNI.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtDNI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtDNI.Location = new System.Drawing.Point(227, 111);
            this.RbtDNI.Name = "RbtDNI";
            this.RbtDNI.Size = new System.Drawing.Size(54, 24);
            this.RbtDNI.TabIndex = 48;
            this.RbtDNI.Text = "DNI";
            this.RbtDNI.UseVisualStyleBackColor = true;
            // 
            // RbtAlias
            // 
            this.RbtAlias.AutoSize = true;
            this.RbtAlias.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtAlias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtAlias.Location = new System.Drawing.Point(287, 110);
            this.RbtAlias.Name = "RbtAlias";
            this.RbtAlias.Size = new System.Drawing.Size(60, 24);
            this.RbtAlias.TabIndex = 49;
            this.RbtAlias.Text = "Alias";
            this.RbtAlias.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RbtActivos);
            this.panel1.Controls.Add(this.rbtTodos);
            this.panel1.Controls.Add(this.RbtEliminados);
            this.panel1.Location = new System.Drawing.Point(672, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 36);
            this.panel1.TabIndex = 50;
            // 
            // picreset
            // 
            this.picreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picreset.Image = global::CapaPresentacion.Properties.Resources.reset;
            this.picreset.Location = new System.Drawing.Point(617, 107);
            this.picreset.Name = "picreset";
            this.picreset.Size = new System.Drawing.Size(38, 33);
            this.picreset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picreset.TabIndex = 51;
            this.picreset.TabStop = false;
            this.picreset.Click += new System.EventHandler(this.picreset_Click);
            // 
            // CrudUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(998, 676);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pnlCrud);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txbbusqueda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picreset);
            this.Controls.Add(this.RbtAlias);
            this.Controls.Add(this.RbtDNI);
            this.Controls.Add(this.RbtNombre);
            this.Controls.Add(this.RbtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrudUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrudEmpleado";
            this.Load += new System.EventHandler(this.CrudUsuarios_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCrud.ResumeLayout(false);
            this.pnlCrud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBajar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picreset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlHeader;
        private Label lbProd;
        private Panel pnlCrud;
        private PictureBox picLimpiar;
        private PictureBox picBajar;
        private DataGridView dgvUsuarios;
        private Button BtnGuardar;
        private Button BtnCancelar;
        private Button BtnEditar;
        private Button btnNuevo;
        private RadioButton rbtTodos;
        private RadioButton RbtEliminados;
        private RadioButton RbtActivos;
        private Label label7;
        private TextBox TxbAlias;
        private Label label8;
        private TextBox TxbContraseña;
        private Label label6;
        private ComboBox CboRoles;
        private Label lbCOD;
        private TextBox txbCod;
        private Label label4;
        private TextBox TxbDni;
        private Label lbTel;
        private TextBox TxbTelefono;
        private Label lbApellido;
        private TextBox txbApellido;
        private Label lbNombre;
        private TextBox txbNombre;
        private PictureBox picContraseña;
        private Button BtnBuscar;
        private TextBox txbbusqueda;
        private RadioButton RbtNombre;
        private RadioButton RbtCodigo;
        private RadioButton RbtDNI;
        private RadioButton RbtAlias;
        private Label lbFechaNac;
        private DateTimePicker dateTimePicker1;
        private Label lbDireccion;
        private TextBox txbDireccion;
        private CheckBox chkActivo;
        private Panel panel1;
        private DataGridViewTextBoxColumn codigoUser;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn Alias;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn activo;
        private DataGridViewButtonColumn accion;
        private TextBox txbIDEmpleado;
        private PictureBox pictureBox1;
        private PictureBox picreset;
    }
}