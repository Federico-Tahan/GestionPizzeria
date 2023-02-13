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
            this.txbDNI = new System.Windows.Forms.TextBox();
            this.lbDNI = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbProd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDescuento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSubtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbotipocompra = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTipodeEntrega = new System.Windows.Forms.Label();
            this.cbotipoentrega = new System.Windows.Forms.ComboBox();
            this.lbTCliente = new System.Windows.Forms.Label();
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.btnverificar = new System.Windows.Forms.Button();
            this.cbocliente = new System.Windows.Forms.ComboBox();
            this.pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbDNI
            // 
            this.txbDNI.Location = new System.Drawing.Point(289, 247);
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
            this.lbDNI.Location = new System.Drawing.Point(289, 221);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(42, 23);
            this.lbDNI.TabIndex = 33;
            this.lbDNI.Text = "DNI";
            this.lbDNI.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(72, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "Cliente";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.White;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Location = new System.Drawing.Point(573, 218);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(72, 28);
            this.BtnLogin.TabIndex = 36;
            this.BtnLogin.Text = "Buscar";
            this.BtnLogin.UseVisualStyleBackColor = false;
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.BackColor = System.Drawing.Color.White;
            this.btnConfirmarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarVenta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btnConfirmarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarVenta.Location = new System.Drawing.Point(216, 509);
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
            this.pnlBarra.Size = new System.Drawing.Size(555, 35);
            this.pnlBarra.TabIndex = 42;
            this.pnlBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_MouseDown);
            // 
            // Salir
            // 
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.Dock = System.Windows.Forms.DockStyle.Right;
            this.Salir.Image = global::CapaPresentacion.Properties.Resources.close;
            this.Salir.Location = new System.Drawing.Point(520, 0);
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
            this.pnlHeader.Controls.Add(this.lbProd);
            this.pnlHeader.Location = new System.Drawing.Point(0, 35);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(296, 56);
            this.pnlHeader.TabIndex = 43;
            // 
            // lbProd
            // 
            this.lbProd.AutoSize = true;
            this.lbProd.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProd.Location = new System.Drawing.Point(10, 9);
            this.lbProd.Name = "lbProd";
            this.lbProd.Size = new System.Drawing.Size(273, 38);
            this.lbProd.TabIndex = 21;
            this.lbProd.Text = "Concretar Venta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.LogPizza;
            this.pictureBox1.Location = new System.Drawing.Point(289, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // txbTotal
            // 
            this.txbTotal.Enabled = false;
            this.txbTotal.Location = new System.Drawing.Point(147, 461);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(69, 23);
            this.txbTotal.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(98, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 46;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(124, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "%";
            // 
            // txbDescuento
            // 
            this.txbDescuento.Enabled = false;
            this.txbDescuento.Location = new System.Drawing.Point(182, 426);
            this.txbDescuento.Name = "txbDescuento";
            this.txbDescuento.Size = new System.Drawing.Size(34, 23);
            this.txbDescuento.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(80, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "DTO";
            // 
            // txbSubtotal
            // 
            this.txbSubtotal.Enabled = false;
            this.txbSubtotal.Location = new System.Drawing.Point(147, 383);
            this.txbSubtotal.Name = "txbSubtotal";
            this.txbSubtotal.Size = new System.Drawing.Size(69, 23);
            this.txbSubtotal.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(71, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "SubTotal";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(72, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 23);
            this.label4.TabIndex = 54;
            this.label4.Text = "Tipo de compra";
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
            this.lbTCliente.Location = new System.Drawing.Point(67, 221);
            this.lbTCliente.Name = "lbTCliente";
            this.lbTCliente.Size = new System.Drawing.Size(149, 23);
            this.lbTCliente.TabIndex = 58;
            this.lbTCliente.Text = "Tipo de Cliente";
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Location = new System.Drawing.Point(72, 247);
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
            this.btnverificar.Location = new System.Drawing.Point(407, 247);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(67, 22);
            this.btnverificar.TabIndex = 59;
            this.btnverificar.Text = "Verificar";
            this.btnverificar.UseVisualStyleBackColor = false;
            this.btnverificar.Visible = false;
            this.btnverificar.Click += new System.EventHandler(this.btnverificar_Click);
            // 
            // cbocliente
            // 
            this.cbocliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbocliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbocliente.FormattingEnabled = true;
            this.cbocliente.Location = new System.Drawing.Point(72, 333);
            this.cbocliente.Name = "cbocliente";
            this.cbocliente.Size = new System.Drawing.Size(194, 23);
            this.cbocliente.TabIndex = 60;
            this.cbocliente.SelectedIndexChanged += new System.EventHandler(this.cbocliente_SelectedIndexChanged);
            this.cbocliente.SelectedValueChanged += new System.EventHandler(this.cbocliente_SelectedValueChanged);
            // 
            // ConfirmacionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(555, 570);
            this.Controls.Add(this.cbocliente);
            this.Controls.Add(this.btnverificar);
            this.Controls.Add(this.lbTCliente);
            this.Controls.Add(this.cboTipoCliente);
            this.Controls.Add(this.lbTipodeEntrega);
            this.Controls.Add(this.cbotipoentrega);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbotipocompra);
            this.Controls.Add(this.txbSubtotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbDescuento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlBarra);
            this.Controls.Add(this.btnConfirmarVenta);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDNI);
            this.Controls.Add(this.txbDNI);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmacionVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmacionVenta";
            this.Load += new System.EventHandler(this.ConfirmacionVenta_Load);
            this.pnlBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbDNI;
        private Label lbDNI;
        private Label label1;
        private Button BtnLogin;
        private Button btnConfirmarVenta;
        private Panel pnlBarra;
        private PictureBox Salir;
        private Panel pnlHeader;
        private Label lbProd;
        private PictureBox pictureBox1;
        private TextBox txbTotal;
        private Label label6;
        private Label label5;
        private TextBox txbDescuento;
        private Label label3;
        private TextBox txbSubtotal;
        private Label label7;
        private ComboBox cbotipocompra;
        private Label label4;
        private Label lbTipodeEntrega;
        private ComboBox cbotipoentrega;
        private Label lbTCliente;
        private ComboBox cboTipoCliente;
        private Button btnverificar;
        private ComboBox cbocliente;
    }
}