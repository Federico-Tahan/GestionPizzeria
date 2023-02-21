namespace CapaPresentacion.Formularios.Venta
{
    partial class ConfirmacionVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmacionVenta));
            this.txbDNI = new System.Windows.Forms.TextBox();
            this.lbDNI = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbconcretar = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.lbtotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDescuento = new System.Windows.Forms.TextBox();
            this.lbdto = new System.Windows.Forms.Label();
            this.txbSubtotal = new System.Windows.Forms.TextBox();
            this.lbsubtotal = new System.Windows.Forms.Label();
            this.cbotipocompra = new System.Windows.Forms.ComboBox();
            this.lbtipocompra = new System.Windows.Forms.Label();
            this.lbTipodeEntrega = new System.Windows.Forms.Label();
            this.cbotipoentrega = new System.Windows.Forms.ComboBox();
            this.lbTCliente = new System.Windows.Forms.Label();
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.btnverificar = new System.Windows.Forms.Button();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbApelldio = new System.Windows.Forms.TextBox();
            this.lbapellido = new System.Windows.Forms.Label();
            this.txbCalle = new System.Windows.Forms.TextBox();
            this.lbcalle = new System.Windows.Forms.Label();
            this.nupAltura = new System.Windows.Forms.NumericUpDown();
            this.txDepto = new System.Windows.Forms.TextBox();
            this.lbdepartamento = new System.Windows.Forms.Label();
            this.nupPiso = new System.Windows.Forms.NumericUpDown();
            this.lbaltura = new System.Windows.Forms.Label();
            this.lbpiso = new System.Windows.Forms.Label();
            this.lblocalidad = new System.Windows.Forms.Label();
            this.cboLocalidad = new System.Windows.Forms.ComboBox();
            this.pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPiso)).BeginInit();
            this.SuspendLayout();
            // 
            // txbDNI
            // 
            this.txbDNI.Location = new System.Drawing.Point(72, 249);
            this.txbDNI.Name = "txbDNI";
            this.txbDNI.Size = new System.Drawing.Size(108, 23);
            this.txbDNI.TabIndex = 0;
            this.txbDNI.Visible = false;
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDNI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDNI.Location = new System.Drawing.Point(72, 223);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(42, 23);
            this.lbDNI.TabIndex = 33;
            this.lbDNI.Text = "DNI";
            this.lbDNI.Visible = false;
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbnombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbnombre.Location = new System.Drawing.Point(72, 308);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(85, 23);
            this.lbnombre.TabIndex = 34;
            this.lbnombre.Text = "Nombre";
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.BackColor = System.Drawing.Color.White;
            this.btnConfirmarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarVenta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnConfirmarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarVenta.Location = new System.Drawing.Point(328, 482);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(115, 39);
            this.btnConfirmarVenta.TabIndex = 41;
            this.btnConfirmarVenta.Text = "Confirmar Venta";
            this.btnConfirmarVenta.UseVisualStyleBackColor = false;
            this.btnConfirmarVenta.Click += new System.EventHandler(this.btnConfirmarVenta_Click);
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.Maroon;
            this.pnlBarra.Controls.Add(this.Salir);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(769, 35);
            this.pnlBarra.TabIndex = 42;
            this.pnlBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_MouseDown);
            // 
            // Salir
            // 
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.Dock = System.Windows.Forms.DockStyle.Right;
            this.Salir.Image = global::CapaPresentacion.Properties.Resources.close;
            this.Salir.Location = new System.Drawing.Point(734, 0);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(35, 35);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Salir.TabIndex = 0;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlHeader.Controls.Add(this.lbconcretar);
            this.pnlHeader.Location = new System.Drawing.Point(0, 35);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(296, 56);
            this.pnlHeader.TabIndex = 43;
            // 
            // lbconcretar
            // 
            this.lbconcretar.AutoSize = true;
            this.lbconcretar.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbconcretar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbconcretar.Location = new System.Drawing.Point(10, 9);
            this.lbconcretar.Name = "lbconcretar";
            this.lbconcretar.Size = new System.Drawing.Size(273, 38);
            this.lbconcretar.TabIndex = 21;
            this.lbconcretar.Text = "Concretar Venta";
            // 
            // txbTotal
            // 
            this.txbTotal.Enabled = false;
            this.txbTotal.Location = new System.Drawing.Point(671, 408);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(69, 23);
            this.txbTotal.TabIndex = 47;
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbtotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbtotal.Location = new System.Drawing.Point(622, 408);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(42, 18);
            this.lbtotal.TabIndex = 46;
            this.lbtotal.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(648, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "%";
            // 
            // txbDescuento
            // 
            this.txbDescuento.Enabled = false;
            this.txbDescuento.Location = new System.Drawing.Point(706, 373);
            this.txbDescuento.Name = "txbDescuento";
            this.txbDescuento.Size = new System.Drawing.Size(34, 23);
            this.txbDescuento.TabIndex = 49;
            // 
            // lbdto
            // 
            this.lbdto.AutoSize = true;
            this.lbdto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbdto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbdto.Location = new System.Drawing.Point(604, 373);
            this.lbdto.Name = "lbdto";
            this.lbdto.Size = new System.Drawing.Size(38, 18);
            this.lbdto.TabIndex = 48;
            this.lbdto.Text = "DTO";
            // 
            // txbSubtotal
            // 
            this.txbSubtotal.Enabled = false;
            this.txbSubtotal.Location = new System.Drawing.Point(671, 330);
            this.txbSubtotal.Name = "txbSubtotal";
            this.txbSubtotal.Size = new System.Drawing.Size(69, 23);
            this.txbSubtotal.TabIndex = 52;
            // 
            // lbsubtotal
            // 
            this.lbsubtotal.AutoSize = true;
            this.lbsubtotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbsubtotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbsubtotal.Location = new System.Drawing.Point(595, 335);
            this.lbsubtotal.Name = "lbsubtotal";
            this.lbsubtotal.Size = new System.Drawing.Size(69, 18);
            this.lbsubtotal.TabIndex = 51;
            this.lbsubtotal.Text = "SubTotal";
            // 
            // cbotipocompra
            // 
            this.cbotipocompra.FormattingEnabled = true;
            this.cbotipocompra.Location = new System.Drawing.Point(72, 174);
            this.cbotipocompra.Name = "cbotipocompra";
            this.cbotipocompra.Size = new System.Drawing.Size(194, 23);
            this.cbotipocompra.TabIndex = 53;
            this.cbotipocompra.SelectionChangeCommitted += new System.EventHandler(this.cbotipocompra_SelectionChangeCommitted);
            // 
            // lbtipocompra
            // 
            this.lbtipocompra.AutoSize = true;
            this.lbtipocompra.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbtipocompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbtipocompra.Location = new System.Drawing.Point(72, 139);
            this.lbtipocompra.Name = "lbtipocompra";
            this.lbtipocompra.Size = new System.Drawing.Size(157, 23);
            this.lbtipocompra.TabIndex = 54;
            this.lbtipocompra.Text = "Tipo de compra";
            // 
            // lbTipodeEntrega
            // 
            this.lbTipodeEntrega.AutoSize = true;
            this.lbTipodeEntrega.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTipodeEntrega.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTipodeEntrega.Location = new System.Drawing.Point(289, 139);
            this.lbTipodeEntrega.Name = "lbTipodeEntrega";
            this.lbTipodeEntrega.Size = new System.Drawing.Size(154, 23);
            this.lbTipodeEntrega.TabIndex = 56;
            this.lbTipodeEntrega.Text = "Tipo de Entrega";
            // 
            // cbotipoentrega
            // 
            this.cbotipoentrega.FormattingEnabled = true;
            this.cbotipoentrega.Location = new System.Drawing.Point(289, 174);
            this.cbotipoentrega.Name = "cbotipoentrega";
            this.cbotipoentrega.Size = new System.Drawing.Size(194, 23);
            this.cbotipoentrega.TabIndex = 55;
            this.cbotipoentrega.SelectionChangeCommitted += new System.EventHandler(this.cbotipoentrega_SelectionChangeCommitted);
            // 
            // lbTCliente
            // 
            this.lbTCliente.AutoSize = true;
            this.lbTCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTCliente.Location = new System.Drawing.Point(521, 148);
            this.lbTCliente.Name = "lbTCliente";
            this.lbTCliente.Size = new System.Drawing.Size(149, 23);
            this.lbTCliente.TabIndex = 58;
            this.lbTCliente.Text = "Tipo de Cliente";
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Location = new System.Drawing.Point(526, 174);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(194, 23);
            this.cboTipoCliente.TabIndex = 57;
            this.cboTipoCliente.SelectedIndexChanged += new System.EventHandler(this.cboTipoCliente_SelectedIndexChanged);
            this.cboTipoCliente.SelectionChangeCommitted += new System.EventHandler(this.cboTipoCliente_SelectionChangeCommitted);
            // 
            // btnverificar
            // 
            this.btnverificar.BackColor = System.Drawing.Color.White;
            this.btnverificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnverificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnverificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnverificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverificar.Location = new System.Drawing.Point(199, 250);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(67, 22);
            this.btnverificar.TabIndex = 59;
            this.btnverificar.Text = "Verificar";
            this.btnverificar.UseVisualStyleBackColor = false;
            this.btnverificar.Visible = false;
            this.btnverificar.Click += new System.EventHandler(this.btnverificar_Click);
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(72, 334);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(124, 23);
            this.txbNombre.TabIndex = 60;
            // 
            // txbApelldio
            // 
            this.txbApelldio.Location = new System.Drawing.Point(220, 334);
            this.txbApelldio.Name = "txbApelldio";
            this.txbApelldio.Size = new System.Drawing.Size(128, 23);
            this.txbApelldio.TabIndex = 62;
            // 
            // lbapellido
            // 
            this.lbapellido.AutoSize = true;
            this.lbapellido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbapellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbapellido.Location = new System.Drawing.Point(220, 308);
            this.lbapellido.Name = "lbapellido";
            this.lbapellido.Size = new System.Drawing.Size(89, 23);
            this.lbapellido.TabIndex = 61;
            this.lbapellido.Text = "Apellido";
            // 
            // txbCalle
            // 
            this.txbCalle.Location = new System.Drawing.Point(72, 408);
            this.txbCalle.Name = "txbCalle";
            this.txbCalle.Size = new System.Drawing.Size(124, 23);
            this.txbCalle.TabIndex = 64;
            // 
            // lbcalle
            // 
            this.lbcalle.AutoSize = true;
            this.lbcalle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbcalle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbcalle.Location = new System.Drawing.Point(72, 382);
            this.lbcalle.Name = "lbcalle";
            this.lbcalle.Size = new System.Drawing.Size(60, 23);
            this.lbcalle.TabIndex = 63;
            this.lbcalle.Text = "Calle";
            // 
            // nupAltura
            // 
            this.nupAltura.Location = new System.Drawing.Point(220, 409);
            this.nupAltura.Name = "nupAltura";
            this.nupAltura.Size = new System.Drawing.Size(59, 23);
            this.nupAltura.TabIndex = 65;
            // 
            // txDepto
            // 
            this.txDepto.Location = new System.Drawing.Point(401, 408);
            this.txDepto.Name = "txDepto";
            this.txDepto.Size = new System.Drawing.Size(145, 23);
            this.txDepto.TabIndex = 67;
            // 
            // lbdepartamento
            // 
            this.lbdepartamento.AutoSize = true;
            this.lbdepartamento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbdepartamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbdepartamento.Location = new System.Drawing.Point(401, 382);
            this.lbdepartamento.Name = "lbdepartamento";
            this.lbdepartamento.Size = new System.Drawing.Size(145, 23);
            this.lbdepartamento.TabIndex = 66;
            this.lbdepartamento.Text = "Departamento";
            // 
            // nupPiso
            // 
            this.nupPiso.Location = new System.Drawing.Point(309, 409);
            this.nupPiso.Name = "nupPiso";
            this.nupPiso.Size = new System.Drawing.Size(59, 23);
            this.nupPiso.TabIndex = 68;
            // 
            // lbaltura
            // 
            this.lbaltura.AutoSize = true;
            this.lbaltura.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbaltura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbaltura.Location = new System.Drawing.Point(214, 382);
            this.lbaltura.Name = "lbaltura";
            this.lbaltura.Size = new System.Drawing.Size(65, 23);
            this.lbaltura.TabIndex = 69;
            this.lbaltura.Text = "Altura";
            // 
            // lbpiso
            // 
            this.lbpiso.AutoSize = true;
            this.lbpiso.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbpiso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbpiso.Location = new System.Drawing.Point(308, 382);
            this.lbpiso.Name = "lbpiso";
            this.lbpiso.Size = new System.Drawing.Size(46, 23);
            this.lbpiso.TabIndex = 70;
            this.lbpiso.Text = "Piso";
            // 
            // lblocalidad
            // 
            this.lblocalidad.AutoSize = true;
            this.lblocalidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblocalidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblocalidad.Location = new System.Drawing.Point(401, 299);
            this.lblocalidad.Name = "lblocalidad";
            this.lblocalidad.Size = new System.Drawing.Size(104, 23);
            this.lblocalidad.TabIndex = 72;
            this.lblocalidad.Text = "Localidad";
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.FormattingEnabled = true;
            this.cboLocalidad.Location = new System.Drawing.Point(401, 334);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(145, 23);
            this.cboLocalidad.TabIndex = 71;
            // 
            // ConfirmacionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(769, 537);
            this.Controls.Add(this.lblocalidad);
            this.Controls.Add(this.cboLocalidad);
            this.Controls.Add(this.lbpiso);
            this.Controls.Add(this.lbaltura);
            this.Controls.Add(this.nupPiso);
            this.Controls.Add(this.txDepto);
            this.Controls.Add(this.lbdepartamento);
            this.Controls.Add(this.nupAltura);
            this.Controls.Add(this.txbCalle);
            this.Controls.Add(this.lbcalle);
            this.Controls.Add(this.txbApelldio);
            this.Controls.Add(this.lbapellido);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.btnverificar);
            this.Controls.Add(this.lbTCliente);
            this.Controls.Add(this.cboTipoCliente);
            this.Controls.Add(this.lbTipodeEntrega);
            this.Controls.Add(this.cbotipoentrega);
            this.Controls.Add(this.lbtipocompra);
            this.Controls.Add(this.cbotipocompra);
            this.Controls.Add(this.txbSubtotal);
            this.Controls.Add(this.lbsubtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbDescuento);
            this.Controls.Add(this.lbdto);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlBarra);
            this.Controls.Add(this.btnConfirmarVenta);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.lbDNI);
            this.Controls.Add(this.txbDNI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfirmacionVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmacionVenta";
            this.Load += new System.EventHandler(this.ConfirmacionVenta_Load);
            this.pnlBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPiso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbDNI;
        private Label lbDNI;
        private Label lbnombre;
        private Button btnConfirmarVenta;
        private Panel pnlBarra;
        private PictureBox Salir;
        private Panel pnlHeader;
        private Label lbconcretar;
        private TextBox txbTotal;
        private Label lbtotal;
        private Label label5;
        private TextBox txbDescuento;
        private Label lbdto;
        private TextBox txbSubtotal;
        private Label lbsubtotal;
        private ComboBox cbotipocompra;
        private Label lbtipocompra;
        private Label lbTipodeEntrega;
        private ComboBox cbotipoentrega;
        private Label lbTCliente;
        private ComboBox cboTipoCliente;
        private Button btnverificar;
        private TextBox txbNombre;
        private TextBox txbApelldio;
        private Label lbapellido;
        private TextBox txbCalle;
        private Label lbcalle;
        private NumericUpDown nupAltura;
        private TextBox txDepto;
        private Label lbdepartamento;
        private NumericUpDown nupPiso;
        private Label lbaltura;
        private Label lbpiso;
        private Label lblocalidad;
        private ComboBox cboLocalidad;
    }
}