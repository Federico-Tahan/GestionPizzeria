namespace CapaPresentacion.Formularios
{
    partial class CrudProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudProductos));
            this.btnNuevo = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMEd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlCrud = new System.Windows.Forms.Panel();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lbNroProd = new System.Windows.Forms.Label();
            this.TxbCodigoProducto = new System.Windows.Forms.TextBox();
            this.nupStock = new System.Windows.Forms.NumericUpDown();
            this.lbstock = new System.Windows.Forms.Label();
            this.picLimpiar = new System.Windows.Forms.PictureBox();
            this.picbajar = new System.Windows.Forms.PictureBox();
            this.lbUnidad = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbClasificacion = new System.Windows.Forms.Label();
            this.lbTipoProd = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.cboUnidadMeidda = new System.Windows.Forms.ComboBox();
            this.cboTipoProd = new System.Windows.Forms.ComboBox();
            this.cboClasificacion = new System.Windows.Forms.ComboBox();
            this.txbDescripcion = new System.Windows.Forms.RichTextBox();
            this.numpPrecio = new System.Windows.Forms.NumericUpDown();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbProd = new System.Windows.Forms.Label();
            this.RbtActivos = new System.Windows.Forms.RadioButton();
            this.RbtEliminados = new System.Windows.Forms.RadioButton();
            this.rbtTodos = new System.Windows.Forms.RadioButton();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtNombre = new System.Windows.Forms.RadioButton();
            this.rbtCodigo = new System.Windows.Forms.RadioButton();
            this.txbbusqueda = new System.Windows.Forms.TextBox();
            this.btnUnidadMedida = new System.Windows.Forms.Button();
            this.BtnClasificacion = new System.Windows.Forms.Button();
            this.BtnTipoProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.pnlCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbajar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpPrecio)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnNuevo.Location = new System.Drawing.Point(144, 560);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(139, 42);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.BtnEditar.Location = new System.Drawing.Point(346, 560);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(139, 42);
            this.BtnEditar.TabIndex = 16;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
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
            this.BtnCancelar.Location = new System.Drawing.Point(538, 560);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(139, 42);
            this.BtnCancelar.TabIndex = 18;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
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
            this.BtnGuardar.Location = new System.Drawing.Point(717, 560);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(139, 42);
            this.BtnGuardar.TabIndex = 19;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
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
            this.IdProducto,
            this.nombreprod,
            this.descripcion,
            this.tipo_Prod,
            this.unidadMEd,
            this.Clasificacion,
            this.Stock,
            this.monto,
            this.Activo,
            this.accion});
            this.dgvProd.Location = new System.Drawing.Point(43, 149);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.RowHeadersVisible = false;
            this.dgvProd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProd.RowTemplate.Height = 25;
            this.dgvProd.Size = new System.Drawing.Size(932, 383);
            this.dgvProd.TabIndex = 20;
            this.dgvProd.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Click_Detalle);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "Nro Producto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Width = 80;
            // 
            // nombreprod
            // 
            this.nombreprod.HeaderText = "Nombre";
            this.nombreprod.Name = "nombreprod";
            this.nombreprod.ReadOnly = true;
            this.nombreprod.Width = 120;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 140;
            // 
            // tipo_Prod
            // 
            this.tipo_Prod.HeaderText = "Tipo Producto";
            this.tipo_Prod.Name = "tipo_Prod";
            this.tipo_Prod.ReadOnly = true;
            this.tipo_Prod.Width = 104;
            // 
            // unidadMEd
            // 
            this.unidadMEd.HeaderText = "Unidad Medida";
            this.unidadMEd.Name = "unidadMEd";
            this.unidadMEd.ReadOnly = true;
            this.unidadMEd.Width = 80;
            // 
            // Clasificacion
            // 
            this.Clasificacion.HeaderText = "Clasificacion";
            this.Clasificacion.Name = "Clasificacion";
            this.Clasificacion.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 80;
            // 
            // monto
            // 
            this.monto.HeaderText = "Precio";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activo.Width = 65;
            // 
            // accion
            // 
            this.accion.HeaderText = "Accion";
            this.accion.Name = "accion";
            this.accion.ReadOnly = true;
            this.accion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.accion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.accion.Text = "Detalle";
            this.accion.UseColumnTextForButtonValue = true;
            this.accion.Width = 60;
            // 
            // pnlCrud
            // 
            this.pnlCrud.BackColor = System.Drawing.Color.OliveDrab;
            this.pnlCrud.Controls.Add(this.chkActivo);
            this.pnlCrud.Controls.Add(this.lbNroProd);
            this.pnlCrud.Controls.Add(this.TxbCodigoProducto);
            this.pnlCrud.Controls.Add(this.nupStock);
            this.pnlCrud.Controls.Add(this.lbstock);
            this.pnlCrud.Controls.Add(this.picLimpiar);
            this.pnlCrud.Controls.Add(this.picbajar);
            this.pnlCrud.Controls.Add(this.lbUnidad);
            this.pnlCrud.Controls.Add(this.lbDesc);
            this.pnlCrud.Controls.Add(this.lbClasificacion);
            this.pnlCrud.Controls.Add(this.lbTipoProd);
            this.pnlCrud.Controls.Add(this.lbPrecio);
            this.pnlCrud.Controls.Add(this.lbNombre);
            this.pnlCrud.Controls.Add(this.cboUnidadMeidda);
            this.pnlCrud.Controls.Add(this.cboTipoProd);
            this.pnlCrud.Controls.Add(this.cboClasificacion);
            this.pnlCrud.Controls.Add(this.txbDescripcion);
            this.pnlCrud.Controls.Add(this.numpPrecio);
            this.pnlCrud.Controls.Add(this.txbNombre);
            this.pnlCrud.Location = new System.Drawing.Point(43, 102);
            this.pnlCrud.Name = "pnlCrud";
            this.pnlCrud.Size = new System.Drawing.Size(932, 443);
            this.pnlCrud.TabIndex = 21;
            this.pnlCrud.Visible = false;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkActivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkActivo.Location = new System.Drawing.Point(287, 331);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(77, 23);
            this.chkActivo.TabIndex = 26;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // lbNroProd
            // 
            this.lbNroProd.AutoSize = true;
            this.lbNroProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNroProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNroProd.Location = new System.Drawing.Point(603, 68);
            this.lbNroProd.Name = "lbNroProd";
            this.lbNroProd.Size = new System.Drawing.Size(140, 19);
            this.lbNroProd.TabIndex = 25;
            this.lbNroProd.Text = "Código Producto";
            this.lbNroProd.Visible = false;
            // 
            // TxbCodigoProducto
            // 
            this.TxbCodigoProducto.Enabled = false;
            this.TxbCodigoProducto.Location = new System.Drawing.Point(603, 100);
            this.TxbCodigoProducto.Name = "TxbCodigoProducto";
            this.TxbCodigoProducto.Size = new System.Drawing.Size(140, 23);
            this.TxbCodigoProducto.TabIndex = 24;
            this.TxbCodigoProducto.Visible = false;
            // 
            // nupStock
            // 
            this.nupStock.Location = new System.Drawing.Point(179, 331);
            this.nupStock.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nupStock.Name = "nupStock";
            this.nupStock.Size = new System.Drawing.Size(72, 23);
            this.nupStock.TabIndex = 23;
            // 
            // lbstock
            // 
            this.lbstock.AutoSize = true;
            this.lbstock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbstock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbstock.Location = new System.Drawing.Point(179, 300);
            this.lbstock.Name = "lbstock";
            this.lbstock.Size = new System.Drawing.Size(50, 19);
            this.lbstock.TabIndex = 22;
            this.lbstock.Text = "Stock";
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
            this.picLimpiar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picbajar
            // 
            this.picbajar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbajar.Image = global::CapaPresentacion.Properties.Resources.abajo1;
            this.picbajar.Location = new System.Drawing.Point(879, 5);
            this.picbajar.Name = "picbajar";
            this.picbajar.Size = new System.Drawing.Size(47, 43);
            this.picbajar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbajar.TabIndex = 19;
            this.picbajar.TabStop = false;
            this.picbajar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbUnidad
            // 
            this.lbUnidad.AutoSize = true;
            this.lbUnidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUnidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbUnidad.Location = new System.Drawing.Point(58, 195);
            this.lbUnidad.Name = "lbUnidad";
            this.lbUnidad.Size = new System.Drawing.Size(131, 19);
            this.lbUnidad.TabIndex = 18;
            this.lbUnidad.Text = "Unidad Medida";
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDesc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDesc.Location = new System.Drawing.Point(603, 195);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(100, 19);
            this.lbDesc.TabIndex = 17;
            this.lbDesc.Text = "Descripcion";
            // 
            // lbClasificacion
            // 
            this.lbClasificacion.AutoSize = true;
            this.lbClasificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbClasificacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbClasificacion.Location = new System.Drawing.Point(333, 67);
            this.lbClasificacion.Name = "lbClasificacion";
            this.lbClasificacion.Size = new System.Drawing.Size(109, 19);
            this.lbClasificacion.TabIndex = 16;
            this.lbClasificacion.Text = "Clasificacion";
            // 
            // lbTipoProd
            // 
            this.lbTipoProd.AutoSize = true;
            this.lbTipoProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTipoProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTipoProd.Location = new System.Drawing.Point(333, 195);
            this.lbTipoProd.Name = "lbTipoProd";
            this.lbTipoProd.Size = new System.Drawing.Size(139, 19);
            this.lbTipoProd.TabIndex = 15;
            this.lbTipoProd.Text = "Tipo de Producto";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPrecio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPrecio.Location = new System.Drawing.Point(58, 299);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(57, 19);
            this.lbPrecio.TabIndex = 14;
            this.lbPrecio.Text = "Precio";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNombre.Location = new System.Drawing.Point(58, 68);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(73, 19);
            this.lbNombre.TabIndex = 13;
            this.lbNombre.Text = "Nombre";
            // 
            // cboUnidadMeidda
            // 
            this.cboUnidadMeidda.FormattingEnabled = true;
            this.cboUnidadMeidda.Location = new System.Drawing.Point(58, 226);
            this.cboUnidadMeidda.Name = "cboUnidadMeidda";
            this.cboUnidadMeidda.Size = new System.Drawing.Size(215, 23);
            this.cboUnidadMeidda.TabIndex = 12;
            // 
            // cboTipoProd
            // 
            this.cboTipoProd.FormattingEnabled = true;
            this.cboTipoProd.Location = new System.Drawing.Point(333, 226);
            this.cboTipoProd.Name = "cboTipoProd";
            this.cboTipoProd.Size = new System.Drawing.Size(215, 23);
            this.cboTipoProd.TabIndex = 11;
            // 
            // cboClasificacion
            // 
            this.cboClasificacion.FormattingEnabled = true;
            this.cboClasificacion.Location = new System.Drawing.Point(333, 99);
            this.cboClasificacion.Name = "cboClasificacion";
            this.cboClasificacion.Size = new System.Drawing.Size(215, 23);
            this.cboClasificacion.TabIndex = 10;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(603, 226);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(265, 128);
            this.txbDescripcion.TabIndex = 9;
            this.txbDescripcion.Text = "";
            // 
            // numpPrecio
            // 
            this.numpPrecio.DecimalPlaces = 2;
            this.numpPrecio.Location = new System.Drawing.Point(58, 331);
            this.numpPrecio.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.numpPrecio.Name = "numpPrecio";
            this.numpPrecio.Size = new System.Drawing.Size(88, 23);
            this.numpPrecio.TabIndex = 8;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(58, 99);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(215, 23);
            this.txbNombre.TabIndex = 7;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.lbProd);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(230, 56);
            this.pnlHeader.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Producto;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lbProd
            // 
            this.lbProd.AutoSize = true;
            this.lbProd.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProd.Location = new System.Drawing.Point(63, 9);
            this.lbProd.Name = "lbProd";
            this.lbProd.Size = new System.Drawing.Size(169, 38);
            this.lbProd.TabIndex = 21;
            this.lbProd.Text = "Productos";
            // 
            // RbtActivos
            // 
            this.RbtActivos.AutoSize = true;
            this.RbtActivos.Checked = true;
            this.RbtActivos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtActivos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtActivos.Location = new System.Drawing.Point(694, 118);
            this.RbtActivos.Name = "RbtActivos";
            this.RbtActivos.Size = new System.Drawing.Size(87, 25);
            this.RbtActivos.TabIndex = 23;
            this.RbtActivos.TabStop = true;
            this.RbtActivos.Text = "Activos";
            this.RbtActivos.UseVisualStyleBackColor = true;
            this.RbtActivos.CheckedChanged += new System.EventHandler(this.RbtActivos_CheckedChanged);
            // 
            // RbtEliminados
            // 
            this.RbtEliminados.AutoSize = true;
            this.RbtEliminados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtEliminados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtEliminados.Location = new System.Drawing.Point(787, 118);
            this.RbtEliminados.Name = "RbtEliminados";
            this.RbtEliminados.Size = new System.Drawing.Size(109, 25);
            this.RbtEliminados.TabIndex = 24;
            this.RbtEliminados.Text = "Eliminados";
            this.RbtEliminados.UseVisualStyleBackColor = true;
            this.RbtEliminados.CheckedChanged += new System.EventHandler(this.RbtEliminados_CheckedChanged);
            // 
            // rbtTodos
            // 
            this.rbtTodos.AutoSize = true;
            this.rbtTodos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtTodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtTodos.Location = new System.Drawing.Point(902, 118);
            this.rbtTodos.Name = "rbtTodos";
            this.rbtTodos.Size = new System.Drawing.Size(73, 25);
            this.rbtTodos.TabIndex = 25;
            this.rbtTodos.Text = "Todos";
            this.rbtTodos.UseVisualStyleBackColor = true;
            this.rbtTodos.CheckedChanged += new System.EventHandler(this.rbtTodos_CheckedChanged);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.White;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Location = new System.Drawing.Point(395, 119);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(71, 23);
            this.BtnLogin.TabIndex = 28;
            this.BtnLogin.Text = "Buscar";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtNombre);
            this.panel1.Controls.Add(this.rbtCodigo);
            this.panel1.Location = new System.Drawing.Point(47, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 44);
            this.panel1.TabIndex = 32;
            // 
            // rbtNombre
            // 
            this.rbtNombre.AutoSize = true;
            this.rbtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtNombre.Location = new System.Drawing.Point(92, 14);
            this.rbtNombre.Name = "rbtNombre";
            this.rbtNombre.Size = new System.Drawing.Size(91, 25);
            this.rbtNombre.TabIndex = 26;
            this.rbtNombre.TabStop = true;
            this.rbtNombre.Text = "Nombre";
            this.rbtNombre.UseVisualStyleBackColor = true;
            // 
            // rbtCodigo
            // 
            this.rbtCodigo.AutoSize = true;
            this.rbtCodigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtCodigo.Location = new System.Drawing.Point(3, 14);
            this.rbtCodigo.Name = "rbtCodigo";
            this.rbtCodigo.Size = new System.Drawing.Size(86, 25);
            this.rbtCodigo.TabIndex = 25;
            this.rbtCodigo.TabStop = true;
            this.rbtCodigo.Text = "Codigo";
            this.rbtCodigo.UseVisualStyleBackColor = true;
            // 
            // txbbusqueda
            // 
            this.txbbusqueda.Location = new System.Drawing.Point(239, 118);
            this.txbbusqueda.Name = "txbbusqueda";
            this.txbbusqueda.Size = new System.Drawing.Size(149, 23);
            this.txbbusqueda.TabIndex = 33;
            // 
            // btnUnidadMedida
            // 
            this.btnUnidadMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnUnidadMedida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnidadMedida.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUnidadMedida.FlatAppearance.BorderSize = 0;
            this.btnUnidadMedida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnUnidadMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnidadMedida.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUnidadMedida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUnidadMedida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnidadMedida.Location = new System.Drawing.Point(864, 0);
            this.btnUnidadMedida.Name = "btnUnidadMedida";
            this.btnUnidadMedida.Size = new System.Drawing.Size(127, 28);
            this.btnUnidadMedida.TabIndex = 34;
            this.btnUnidadMedida.Text = "Unidad Medida";
            this.btnUnidadMedida.UseVisualStyleBackColor = false;
            this.btnUnidadMedida.Click += new System.EventHandler(this.btnUnidadMedida_Click);
            // 
            // BtnClasificacion
            // 
            this.BtnClasificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnClasificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClasificacion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnClasificacion.FlatAppearance.BorderSize = 0;
            this.BtnClasificacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.BtnClasificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClasificacion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClasificacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClasificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClasificacion.Location = new System.Drawing.Point(731, 0);
            this.BtnClasificacion.Name = "BtnClasificacion";
            this.BtnClasificacion.Size = new System.Drawing.Size(127, 28);
            this.BtnClasificacion.TabIndex = 35;
            this.BtnClasificacion.Text = "Clasificacion";
            this.BtnClasificacion.UseVisualStyleBackColor = false;
            this.BtnClasificacion.Click += new System.EventHandler(this.BtnClasificacion_Click);
            // 
            // BtnTipoProd
            // 
            this.BtnTipoProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnTipoProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTipoProd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnTipoProd.FlatAppearance.BorderSize = 0;
            this.BtnTipoProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.BtnTipoProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTipoProd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTipoProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnTipoProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTipoProd.Location = new System.Drawing.Point(598, 0);
            this.BtnTipoProd.Name = "BtnTipoProd";
            this.BtnTipoProd.Size = new System.Drawing.Size(127, 28);
            this.BtnTipoProd.TabIndex = 36;
            this.BtnTipoProd.Text = "Tipo Producto";
            this.BtnTipoProd.UseVisualStyleBackColor = false;
            this.BtnTipoProd.Click += new System.EventHandler(this.BtnTipoProd_Click);
            // 
            // CrudProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(998, 676);
            this.Controls.Add(this.BtnTipoProd);
            this.Controls.Add(this.BtnClasificacion);
            this.Controls.Add(this.btnUnidadMedida);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlCrud);
            this.Controls.Add(this.dgvProd);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.rbtTodos);
            this.Controls.Add(this.RbtEliminados);
            this.Controls.Add(this.RbtActivos);
            this.Controls.Add(this.txbbusqueda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrudProductos";
            this.Text = "CrudProductos";
            this.Load += new System.EventHandler(this.CrudProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.pnlCrud.ResumeLayout(false);
            this.pnlCrud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbajar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpPrecio)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNuevo;
        private Button BtnEditar;
        private Button BtnCancelar;
        private Button BtnGuardar;
        private DataGridView dgvProd;
        private Panel pnlCrud;
        private ComboBox cboUnidadMeidda;
        private ComboBox cboTipoProd;
        private ComboBox cboClasificacion;
        private RichTextBox txbDescripcion;
        private NumericUpDown numpPrecio;
        private TextBox txbNombre;
        private NumericUpDown nupStock;
        private Label lbstock;
        private PictureBox picLimpiar;
        private PictureBox picbajar;
        private Label lbUnidad;
        private Label lbDesc;
        private Label lbClasificacion;
        private Label lbTipoProd;
        private Label lbPrecio;
        private Label lbNombre;
        private Panel pnlHeader;
        private Label lbProd;
        private RadioButton RbtActivos;
        private RadioButton RbtEliminados;
        private RadioButton rbtTodos;
        private Button BtnLogin;
        private Label lbNroProd;
        private TextBox TxbCodigoProducto;
        private CheckBox chkActivo;
        private PictureBox pictureBox1;
        private Panel panel1;
        private RadioButton rbtNombre;
        private RadioButton rbtCodigo;
        private TextBox txbbusqueda;
        private Button btnUnidadMedida;
        private Button BtnClasificacion;
        private Button BtnTipoProd;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn nombreprod;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn tipo_Prod;
        private DataGridViewTextBoxColumn unidadMEd;
        private DataGridViewTextBoxColumn Clasificacion;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn monto;
        private DataGridViewTextBoxColumn Activo;
        private DataGridViewButtonColumn accion;
    }
}