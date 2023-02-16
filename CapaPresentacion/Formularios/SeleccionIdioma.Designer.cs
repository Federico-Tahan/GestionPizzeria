namespace CapaPresentacion.Formularios
{
    partial class SeleccionIdioma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionIdioma));
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.picIngles = new System.Windows.Forms.PictureBox();
            this.picEspaña = new System.Windows.Forms.PictureBox();
            this.lbselect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIngles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEspaña)).BeginInit();
            this.SuspendLayout();
            // 
            // piclogo
            // 
            this.piclogo.Image = global::CapaPresentacion.Properties.Resources.pizzaGrandeLogo1;
            this.piclogo.Location = new System.Drawing.Point(259, 114);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(317, 233);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogo.TabIndex = 0;
            this.piclogo.TabStop = false;
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.Maroon;
            this.pnlBarra.Controls.Add(this.Minimizar);
            this.pnlBarra.Controls.Add(this.Salir);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(835, 35);
            this.pnlBarra.TabIndex = 2;
            this.pnlBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_MouseDown);
            // 
            // Minimizar
            // 
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimizar.Image = global::CapaPresentacion.Properties.Resources.minimize_sign;
            this.Minimizar.Location = new System.Drawing.Point(765, 0);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(35, 35);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 2;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Salir
            // 
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.Dock = System.Windows.Forms.DockStyle.Right;
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(800, 0);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(35, 35);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Salir.TabIndex = 0;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // picIngles
            // 
            this.picIngles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIngles.Image = global::CapaPresentacion.Properties.Resources.united_kingdom1;
            this.picIngles.Location = new System.Drawing.Point(604, 159);
            this.picIngles.Name = "picIngles";
            this.picIngles.Size = new System.Drawing.Size(213, 178);
            this.picIngles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIngles.TabIndex = 3;
            this.picIngles.TabStop = false;
            this.picIngles.Click += new System.EventHandler(this.picIngles_Click);
            // 
            // picEspaña
            // 
            this.picEspaña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEspaña.Image = global::CapaPresentacion.Properties.Resources.espana__2_1;
            this.picEspaña.Location = new System.Drawing.Point(17, 159);
            this.picEspaña.Name = "picEspaña";
            this.picEspaña.Size = new System.Drawing.Size(213, 178);
            this.picEspaña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEspaña.TabIndex = 4;
            this.picEspaña.TabStop = false;
            this.picEspaña.Click += new System.EventHandler(this.picEspaña_Click);
            // 
            // lbselect
            // 
            this.lbselect.AutoSize = true;
            this.lbselect.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbselect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbselect.Location = new System.Drawing.Point(595, 127);
            this.lbselect.Name = "lbselect";
            this.lbselect.Size = new System.Drawing.Size(231, 24);
            this.lbselect.TabIndex = 9;
            this.lbselect.Text = "Select your language";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selecciona tu idioma";
            // 
            // SeleccionIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(835, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbselect);
            this.Controls.Add(this.picEspaña);
            this.Controls.Add(this.picIngles);
            this.Controls.Add(this.pnlBarra);
            this.Controls.Add(this.piclogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeleccionIdioma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionIdioma";
            this.Load += new System.EventHandler(this.SeleccionIdioma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.pnlBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIngles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEspaña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox piclogo;
        private Panel pnlBarra;
        private PictureBox Minimizar;
        private PictureBox Salir;
        private PictureBox picIngles;
        private PictureBox picEspaña;
        private Label lbselect;
        private Label label1;
    }
}