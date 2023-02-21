namespace CapaPresentacion.Formularios.Combos
{
    partial class FormLocalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLocalidad));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picbajar = new System.Windows.Forms.PictureBox();
            this.lbclasi = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txbClasificacion = new System.Windows.Forms.TextBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbclasificacion = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvClasi = new System.Windows.Forms.DataGridView();
            this.Codigolocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.lbcodclasi = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.rbtTodos = new System.Windows.Forms.RadioButton();
            this.RbtNoActivo = new System.Windows.Forms.RadioButton();
            this.RbtActivo = new System.Windows.Forms.RadioButton();
            this.txbBusqeuda = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbajar)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasi)).BeginInit();
            this.pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.picbajar);
            this.panel1.Controls.Add(this.lbclasi);
            this.panel1.Controls.Add(this.chkActivo);
            this.panel1.Controls.Add(this.txbClasificacion);
            this.panel1.Location = new System.Drawing.Point(82, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 356);
            this.panel1.TabIndex = 55;
            this.panel1.Visible = false;
            // 
            // picbajar
            // 
            this.picbajar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbajar.Image = global::CapaPresentacion.Properties.Resources.abajo1;
            this.picbajar.Location = new System.Drawing.Point(507, 0);
            this.picbajar.Name = "picbajar";
            this.picbajar.Size = new System.Drawing.Size(47, 43);
            this.picbajar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbajar.TabIndex = 47;
            this.picbajar.TabStop = false;
            this.picbajar.Click += new System.EventHandler(this.picbajar_Click);
            // 
            // lbclasi
            // 
            this.lbclasi.AutoSize = true;
            this.lbclasi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbclasi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbclasi.Location = new System.Drawing.Point(52, 138);
            this.lbclasi.Name = "lbclasi";
            this.lbclasi.Size = new System.Drawing.Size(88, 19);
            this.lbclasi.TabIndex = 46;
            this.lbclasi.Text = "Localidad";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkActivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkActivo.Location = new System.Drawing.Point(321, 160);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(77, 23);
            this.chkActivo.TabIndex = 27;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txbClasificacion
            // 
            this.txbClasificacion.Location = new System.Drawing.Point(52, 160);
            this.txbClasificacion.Name = "txbClasificacion";
            this.txbClasificacion.Size = new System.Drawing.Size(204, 23);
            this.txbClasificacion.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlHeader.Controls.Add(this.lbclasificacion);
            this.pnlHeader.Location = new System.Drawing.Point(0, 35);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(193, 56);
            this.pnlHeader.TabIndex = 54;
            // 
            // lbclasificacion
            // 
            this.lbclasificacion.AutoSize = true;
            this.lbclasificacion.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbclasificacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbclasificacion.Location = new System.Drawing.Point(11, 8);
            this.lbclasificacion.Name = "lbclasificacion";
            this.lbclasificacion.Size = new System.Drawing.Size(171, 38);
            this.lbclasificacion.TabIndex = 21;
            this.lbclasificacion.Text = "Localidad";
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
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(526, 536);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(97, 42);
            this.BtnGuardar.TabIndex = 53;
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
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(372, 536);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(110, 42);
            this.BtnCancelar.TabIndex = 52;
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
            this.BtnEditar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(228, 536);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(112, 42);
            this.BtnEditar.TabIndex = 51;
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
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(81, 536);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(112, 42);
            this.btnNuevo.TabIndex = 50;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvClasi
            // 
            this.dgvClasi.AllowUserToAddRows = false;
            this.dgvClasi.AllowUserToDeleteRows = false;
            this.dgvClasi.AllowUserToResizeColumns = false;
            this.dgvClasi.AllowUserToResizeRows = false;
            this.dgvClasi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dgvClasi.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClasi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigolocalidad,
            this.Localidad,
            this.activo,
            this.Accion});
            this.dgvClasi.Location = new System.Drawing.Point(82, 199);
            this.dgvClasi.Name = "dgvClasi";
            this.dgvClasi.ReadOnly = true;
            this.dgvClasi.RowHeadersVisible = false;
            this.dgvClasi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvClasi.RowTemplate.Height = 25;
            this.dgvClasi.Size = new System.Drawing.Size(554, 305);
            this.dgvClasi.TabIndex = 49;
            this.dgvClasi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasi_CellContentClick);
            // 
            // Codigolocalidad
            // 
            this.Codigolocalidad.HeaderText = "Codigo Localidad";
            this.Codigolocalidad.Name = "Codigolocalidad";
            this.Codigolocalidad.ReadOnly = true;
            this.Codigolocalidad.Width = 150;
            // 
            // Localidad
            // 
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            this.Localidad.Width = 201;
            // 
            // activo
            // 
            this.activo.HeaderText = "Activo";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            this.Accion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Accion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Accion.Text = "Detalle";
            this.Accion.UseColumnTextForButtonValue = true;
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.Maroon;
            this.pnlBarra.Controls.Add(this.Salir);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(672, 35);
            this.pnlBarra.TabIndex = 48;
            // 
            // Salir
            // 
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.Dock = System.Windows.Forms.DockStyle.Right;
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(637, 0);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(35, 35);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Salir.TabIndex = 0;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // lbcodclasi
            // 
            this.lbcodclasi.AutoSize = true;
            this.lbcodclasi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbcodclasi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbcodclasi.Location = new System.Drawing.Point(81, 148);
            this.lbcodclasi.Name = "lbcodclasi";
            this.lbcodclasi.Size = new System.Drawing.Size(150, 19);
            this.lbcodclasi.TabIndex = 61;
            this.lbcodclasi.Text = "Codigo Localidad";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(215, 170);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(71, 23);
            this.BtnBuscar.TabIndex = 60;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // rbtTodos
            // 
            this.rbtTodos.AutoSize = true;
            this.rbtTodos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtTodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtTodos.Location = new System.Drawing.Point(563, 170);
            this.rbtTodos.Name = "rbtTodos";
            this.rbtTodos.Size = new System.Drawing.Size(73, 25);
            this.rbtTodos.TabIndex = 59;
            this.rbtTodos.Text = "Todos";
            this.rbtTodos.UseVisualStyleBackColor = true;
            this.rbtTodos.CheckedChanged += new System.EventHandler(this.rbtTodos_CheckedChanged);
            // 
            // RbtNoActivo
            // 
            this.RbtNoActivo.AutoSize = true;
            this.RbtNoActivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtNoActivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtNoActivo.Location = new System.Drawing.Point(450, 170);
            this.RbtNoActivo.Name = "RbtNoActivo";
            this.RbtNoActivo.Size = new System.Drawing.Size(107, 25);
            this.RbtNoActivo.TabIndex = 58;
            this.RbtNoActivo.Text = "No Activo";
            this.RbtNoActivo.UseVisualStyleBackColor = true;
            this.RbtNoActivo.CheckedChanged += new System.EventHandler(this.RbtNoActivo_CheckedChanged);
            // 
            // RbtActivo
            // 
            this.RbtActivo.AutoSize = true;
            this.RbtActivo.Checked = true;
            this.RbtActivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtActivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtActivo.Location = new System.Drawing.Point(354, 170);
            this.RbtActivo.Name = "RbtActivo";
            this.RbtActivo.Size = new System.Drawing.Size(81, 25);
            this.RbtActivo.TabIndex = 57;
            this.RbtActivo.TabStop = true;
            this.RbtActivo.Text = "Activo";
            this.RbtActivo.UseVisualStyleBackColor = true;
            this.RbtActivo.CheckedChanged += new System.EventHandler(this.RbtActivo_CheckedChanged);
            // 
            // txbBusqeuda
            // 
            this.txbBusqeuda.Location = new System.Drawing.Point(81, 170);
            this.txbBusqeuda.Name = "txbBusqeuda";
            this.txbBusqeuda.Size = new System.Drawing.Size(128, 23);
            this.txbBusqeuda.TabIndex = 56;
            // 
            // FormLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(672, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvClasi);
            this.Controls.Add(this.pnlBarra);
            this.Controls.Add(this.lbcodclasi);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.rbtTodos);
            this.Controls.Add(this.RbtNoActivo);
            this.Controls.Add(this.RbtActivo);
            this.Controls.Add(this.txbBusqeuda);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLocalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLocalidad";
            this.Load += new System.EventHandler(this.FormLocalidad_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbajar)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasi)).EndInit();
            this.pnlBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox picbajar;
        private Label lbclasi;
        private CheckBox chkActivo;
        private TextBox txbClasificacion;
        private Panel pnlHeader;
        private Label lbclasificacion;
        private Button BtnGuardar;
        private Button BtnCancelar;
        private Button BtnEditar;
        private Button btnNuevo;
        private DataGridView dgvClasi;
        private Panel pnlBarra;
        private PictureBox Salir;
        private Label lbcodclasi;
        private Button BtnBuscar;
        private RadioButton rbtTodos;
        private RadioButton RbtNoActivo;
        private RadioButton RbtActivo;
        private TextBox txbBusqeuda;
        private DataGridViewTextBoxColumn Codigolocalidad;
        private DataGridViewTextBoxColumn Localidad;
        private DataGridViewTextBoxColumn activo;
        private DataGridViewButtonColumn Accion;
    }
}