    namespace CapaPresentacion.Formularios.Venta
{
    partial class ConsultaVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.Nroventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formapedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbProd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnVovler = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Det = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMEd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picreset = new System.Windows.Forms.PictureBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txbbusqueda = new System.Windows.Forms.TextBox();
            this.RbtCodigo = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picreset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToAddRows = false;
            this.dgvProd.AllowUserToDeleteRows = false;
            this.dgvProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dgvProd.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nroventa,
            this.Cliente,
            this.fecha,
            this.Formapedido,
            this.Descuento,
            this.Total,
            this.Ticket,
            this.Accion});
            this.dgvProd.Location = new System.Drawing.Point(73, 163);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.RowHeadersVisible = false;
            this.dgvProd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProd.RowTemplate.Height = 25;
            this.dgvProd.Size = new System.Drawing.Size(870, 399);
            this.dgvProd.TabIndex = 26;
            this.dgvProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellContentClick);
            // 
            // Nroventa
            // 
            this.Nroventa.HeaderText = "Nro Factura";
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
            // Ticket
            // 
            this.Ticket.HeaderText = "Ticket";
            this.Ticket.Name = "Ticket";
            this.Ticket.ReadOnly = true;
            this.Ticket.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ticket.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ticket.Text = "Imprimir";
            this.Ticket.UseColumnTextForButtonValue = true;
            this.Ticket.Width = 107;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            this.Accion.Text = "Detalle";
            this.Accion.UseColumnTextForButtonValue = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.lbProd);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnVovler);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvDetalle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 675);
            this.panel1.TabIndex = 39;
            this.panel1.Visible = false;
            // 
            // BtnVovler
            // 
            this.BtnVovler.BackColor = System.Drawing.Color.White;
            this.BtnVovler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVovler.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnVovler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.BtnVovler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVovler.Location = new System.Drawing.Point(890, 551);
            this.BtnVovler.Name = "BtnVovler";
            this.BtnVovler.Size = new System.Drawing.Size(86, 39);
            this.BtnVovler.TabIndex = 42;
            this.BtnVovler.Text = "Volver";
            this.BtnVovler.UseVisualStyleBackColor = false;
            this.BtnVovler.Click += new System.EventHandler(this.BtnVovler_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.Det);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 56);
            this.panel2.TabIndex = 39;
            // 
            // Det
            // 
            this.Det.AutoSize = true;
            this.Det.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Det.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Det.Location = new System.Drawing.Point(12, 9);
            this.Det.Name = "Det";
            this.Det.Size = new System.Drawing.Size(307, 38);
            this.Det.TabIndex = 21;
            this.Det.Text = "Detalla Factura N°:";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dgvDetalle.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.nombreprod,
            this.descripcion,
            this.tipo_Prod,
            this.unidadMEd,
            this.Clasificacion,
            this.Stock,
            this.monto,
            this.dataGridViewButtonColumn1});
            this.dgvDetalle.Location = new System.Drawing.Point(44, 138);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetalle.RowTemplate.Height = 25;
            this.dgvDetalle.Size = new System.Drawing.Size(932, 383);
            this.dgvDetalle.TabIndex = 21;
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
            this.descripcion.HeaderText = "Detalle";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 185;
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
            this.Stock.HeaderText = "Cantidad";
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
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Importe";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.Width = 80;
            // 
            // picreset
            // 
            this.picreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picreset.Image = global::CapaPresentacion.Properties.Resources.reset;
            this.picreset.Location = new System.Drawing.Point(421, 124);
            this.picreset.Name = "picreset";
            this.picreset.Size = new System.Drawing.Size(38, 33);
            this.picreset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picreset.TabIndex = 62;
            this.picreset.TabStop = false;
            this.picreset.Click += new System.EventHandler(this.picreset_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(335, 134);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(71, 23);
            this.BtnBuscar.TabIndex = 60;
            this.BtnBuscar.Text = "Aplicar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txbbusqueda
            // 
            this.txbbusqueda.Location = new System.Drawing.Point(197, 133);
            this.txbbusqueda.Name = "txbbusqueda";
            this.txbbusqueda.Size = new System.Drawing.Size(121, 23);
            this.txbbusqueda.TabIndex = 59;
            // 
            // RbtCodigo
            // 
            this.RbtCodigo.AutoSize = true;
            this.RbtCodigo.Checked = true;
            this.RbtCodigo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbtCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RbtCodigo.Location = new System.Drawing.Point(73, 133);
            this.RbtCodigo.Name = "RbtCodigo";
            this.RbtCodigo.Size = new System.Drawing.Size(113, 24);
            this.RbtCodigo.TabIndex = 61;
            this.RbtCodigo.TabStop = true;
            this.RbtCodigo.Text = "Nro Factura";
            this.RbtCodigo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.compras__1_2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // ConsultaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(998, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvProd);
            this.Controls.Add(this.picreset);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txbbusqueda);
            this.Controls.Add(this.RbtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaVentas";
            this.Text = "ConsultaEdicionBajaVentas";
            this.Load += new System.EventHandler(this.ConsultaVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picreset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvProd;
        private Panel pnlHeader;
        private Label lbProd;
        private Panel panel1;
        private Panel panel2;
        private Label Det;
        private DataGridView dgvDetalle;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn nombreprod;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn tipo_Prod;
        private DataGridViewTextBoxColumn unidadMEd;
        private DataGridViewTextBoxColumn Clasificacion;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn monto;
        private DataGridViewTextBoxColumn dataGridViewButtonColumn1;
        private Button BtnVovler;
        private DataGridViewTextBoxColumn Nroventa;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn Formapedido;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewButtonColumn Ticket;
        private DataGridViewButtonColumn Accion;
        private PictureBox picreset;
        private Button BtnBuscar;
        private TextBox txbbusqueda;
        private RadioButton RbtCodigo;
        private PictureBox pictureBox1;
    }
}