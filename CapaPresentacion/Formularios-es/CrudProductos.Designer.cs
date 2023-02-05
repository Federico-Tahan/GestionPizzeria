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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
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
            this.ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Activo = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlCrud = new System.Windows.Forms.Panel();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lbNroProd = new System.Windows.Forms.Label();
            this.TxbCodigoProducto = new System.Windows.Forms.TextBox();
            this.nupStock = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
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
            this.txbCodProd = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.CodProducto = new System.Windows.Forms.Label();
            this.lbNombreprod = new System.Windows.Forms.Label();
            this.txbNombreProd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.pnlCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbajar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpPrecio)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btnNuevo.Location = new System.Drawing.Point(69, 579);
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
            this.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(257, 579);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(139, 42);
            this.BtnEditar.TabIndex = 16;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBorrar.FlatAppearance.BorderSize = 0;
            this.BtnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBorrar.Location = new System.Drawing.Point(444, 579);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(139, 42);
            this.BtnBorrar.TabIndex = 17;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(630, 579);
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
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(801, 579);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(139, 42);
            this.BtnGuardar.TabIndex = 19;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
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
            this.ver,
            this.Activo});
            this.dgvProd.Location = new System.Drawing.Point(41, 168);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.RowHeadersVisible = false;
            this.dgvProd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProd.RowTemplate.Height = 25;
            this.dgvProd.Size = new System.Drawing.Size(932, 383);
            this.dgvProd.TabIndex = 20;
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
            // ver
            // 
            this.ver.HeaderText = "Accion";
            this.ver.Name = "ver";
            this.ver.ReadOnly = true;
            this.ver.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ver.Width = 60;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Activo.Width = 65;
            // 
            // pnlCrud
            // 
            this.pnlCrud.BackColor = System.Drawing.Color.OliveDrab;
            this.pnlCrud.Controls.Add(this.chkActivo);
            this.pnlCrud.Controls.Add(this.lbNroProd);
            this.pnlCrud.Controls.Add(this.TxbCodigoProducto);
            this.pnlCrud.Controls.Add(this.nupStock);
            this.pnlCrud.Controls.Add(this.label1);
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
            this.pnlCrud.Location = new System.Drawing.Point(41, 113);
            this.pnlCrud.Name = "pnlCrud";
            this.pnlCrud.Size = new System.Drawing.Size(932, 451);
            this.pnlCrud.TabIndex = 21;
            this.pnlCrud.Visible = false;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkActivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkActivo.Location = new System.Drawing.Point(423, 331);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(67, 20);
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
            // 
            // TxbCodigoProducto
            // 
            this.TxbCodigoProducto.Enabled = false;
            this.TxbCodigoProducto.Location = new System.Drawing.Point(603, 100);
            this.TxbCodigoProducto.Name = "TxbCodigoProducto";
            this.TxbCodigoProducto.Size = new System.Drawing.Size(140, 23);
            this.TxbCodigoProducto.TabIndex = 24;
            // 
            // nupStock
            // 
            this.nupStock.Location = new System.Drawing.Point(248, 331);
            this.nupStock.Name = "nupStock";
            this.nupStock.Size = new System.Drawing.Size(131, 23);
            this.nupStock.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(248, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Stock";
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
            this.txbDescripcion.Size = new System.Drawing.Size(265, 194);
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
            this.numpPrecio.Size = new System.Drawing.Size(149, 23);
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
            this.pnlHeader.Size = new System.Drawing.Size(221, 56);
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
            this.lbProd.Size = new System.Drawing.Size(155, 38);
            this.lbProd.TabIndex = 21;
            this.lbProd.Text = "Producto";
            // 
            // RbtActivos
            // 
            this.RbtActivos.AutoSize = true;
            this.RbtActivos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtActivos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtActivos.Location = new System.Drawing.Point(692, 137);
            this.RbtActivos.Name = "RbtActivos";
            this.RbtActivos.Size = new System.Drawing.Size(87, 25);
            this.RbtActivos.TabIndex = 23;
            this.RbtActivos.TabStop = true;
            this.RbtActivos.Text = "Activos";
            this.RbtActivos.UseVisualStyleBackColor = true;
            // 
            // RbtEliminados
            // 
            this.RbtEliminados.AutoSize = true;
            this.RbtEliminados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtEliminados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtEliminados.Location = new System.Drawing.Point(785, 137);
            this.RbtEliminados.Name = "RbtEliminados";
            this.RbtEliminados.Size = new System.Drawing.Size(109, 25);
            this.RbtEliminados.TabIndex = 24;
            this.RbtEliminados.TabStop = true;
            this.RbtEliminados.Text = "Eliminados";
            this.RbtEliminados.UseVisualStyleBackColor = true;
            // 
            // rbtTodos
            // 
            this.rbtTodos.AutoSize = true;
            this.rbtTodos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtTodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtTodos.Location = new System.Drawing.Point(900, 137);
            this.rbtTodos.Name = "rbtTodos";
            this.rbtTodos.Size = new System.Drawing.Size(73, 25);
            this.rbtTodos.TabIndex = 25;
            this.rbtTodos.TabStop = true;
            this.rbtTodos.Text = "Todos";
            this.rbtTodos.UseVisualStyleBackColor = true;
            // 
            // txbCodProd
            // 
            this.txbCodProd.Location = new System.Drawing.Point(41, 135);
            this.txbCodProd.Name = "txbCodProd";
            this.txbCodProd.Size = new System.Drawing.Size(180, 23);
            this.txbCodProd.TabIndex = 26;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.White;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Location = new System.Drawing.Point(464, 134);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(71, 23);
            this.BtnLogin.TabIndex = 28;
            this.BtnLogin.Text = "Buscar";
            this.BtnLogin.UseVisualStyleBackColor = false;
            // 
            // CodProducto
            // 
            this.CodProducto.AutoSize = true;
            this.CodProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CodProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CodProducto.Location = new System.Drawing.Point(41, 113);
            this.CodProducto.Name = "CodProducto";
            this.CodProducto.Size = new System.Drawing.Size(67, 19);
            this.CodProducto.TabIndex = 29;
            this.CodProducto.Text = "Codigo";
            // 
            // lbNombreprod
            // 
            this.lbNombreprod.AutoSize = true;
            this.lbNombreprod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNombreprod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNombreprod.Location = new System.Drawing.Point(251, 113);
            this.lbNombreprod.Name = "lbNombreprod";
            this.lbNombreprod.Size = new System.Drawing.Size(73, 19);
            this.lbNombreprod.TabIndex = 31;
            this.lbNombreprod.Text = "Nombre";
            // 
            // txbNombreProd
            // 
            this.txbNombreProd.Location = new System.Drawing.Point(251, 135);
            this.txbNombreProd.Name = "txbNombreProd";
            this.txbNombreProd.Size = new System.Drawing.Size(180, 23);
            this.txbNombreProd.TabIndex = 30;
            // 
            // CrudProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(998, 676);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlCrud);
            this.Controls.Add(this.dgvProd);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lbNombreprod);
            this.Controls.Add(this.txbNombreProd);
            this.Controls.Add(this.CodProducto);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.txbCodProd);
            this.Controls.Add(this.rbtTodos);
            this.Controls.Add(this.RbtEliminados);
            this.Controls.Add(this.RbtActivos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrudProductos";
            this.Text = "CrudProductos";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNuevo;
        private Button BtnEditar;
        private Button BtnBorrar;
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
        private Label label1;
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
        private TextBox txbCodProd;
        private Button BtnLogin;
        private Label CodProducto;
        private Label lbNombreprod;
        private TextBox txbNombreProd;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn nombreprod;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn tipo_Prod;
        private DataGridViewTextBoxColumn unidadMEd;
        private DataGridViewTextBoxColumn Clasificacion;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn monto;
        private DataGridViewButtonColumn ver;
        private DataGridViewImageColumn Activo;
        private Label lbNroProd;
        private TextBox TxbCodigoProducto;
        private CheckBox chkActivo;
        private PictureBox pictureBox1;
    }
}