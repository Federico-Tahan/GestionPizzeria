namespace CapaPresentacion
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncambiaridioma = new System.Windows.Forms.Button();
            this.picpass = new System.Windows.Forms.PictureBox();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.Maroon;
            this.pnlBarra.Controls.Add(this.Minimizar);
            this.pnlBarra.Controls.Add(this.Salir);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(600, 35);
            this.pnlBarra.TabIndex = 0;
            this.pnlBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_MouseDown);
            // 
            // Minimizar
            // 
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Image = global::CapaPresentacion.Properties.Resources.minimize_sign;
            this.Minimizar.Location = new System.Drawing.Point(524, 0);
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
            this.Salir.Image = global::CapaPresentacion.Properties.Resources.close;
            this.Salir.Location = new System.Drawing.Point(565, 0);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(35, 35);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Salir.TabIndex = 0;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.btncambiaridioma);
            this.panel2.Controls.Add(this.picpass);
            this.panel2.Controls.Add(this.lbContraseña);
            this.panel2.Controls.Add(this.lbUsuario);
            this.panel2.Controls.Add(this.BtnLogin);
            this.panel2.Controls.Add(this.txbUsuario);
            this.panel2.Controls.Add(this.txbContraseña);
            this.panel2.Controls.Add(this.picLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 506);
            this.panel2.TabIndex = 0;
            // 
            // btncambiaridioma
            // 
            this.btncambiaridioma.BackColor = System.Drawing.Color.White;
            this.btncambiaridioma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncambiaridioma.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncambiaridioma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btncambiaridioma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncambiaridioma.Location = new System.Drawing.Point(9, 469);
            this.btncambiaridioma.Name = "btncambiaridioma";
            this.btncambiaridioma.Size = new System.Drawing.Size(100, 27);
            this.btncambiaridioma.TabIndex = 42;
            this.btncambiaridioma.Text = "Cambiar Idioma";
            this.btncambiaridioma.UseVisualStyleBackColor = false;
            this.btncambiaridioma.Click += new System.EventHandler(this.btncambiaridioma_Click);
            // 
            // picpass
            // 
            this.picpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picpass.Image = global::CapaPresentacion.Properties.Resources.mostrar1;
            this.picpass.Location = new System.Drawing.Point(423, 348);
            this.picpass.Name = "picpass";
            this.picpass.Size = new System.Drawing.Size(33, 30);
            this.picpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picpass.TabIndex = 41;
            this.picpass.TabStop = false;
            this.picpass.Tag = "activar";
            this.picpass.Click += new System.EventHandler(this.picpass_Click);
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbContraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbContraseña.Location = new System.Drawing.Point(209, 330);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(98, 19);
            this.lbContraseña.TabIndex = 0;
            this.lbContraseña.Text = "Contraseña";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbUsuario.Location = new System.Drawing.Point(209, 258);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(65, 19);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuario";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.White;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Location = new System.Drawing.Point(249, 408);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(120, 36);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Iniciar Sesion";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txbUsuario
            // 
            this.txbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUsuario.Location = new System.Drawing.Point(209, 280);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(208, 23);
            this.txbUsuario.TabIndex = 1;
            // 
            // txbContraseña
            // 
            this.txbContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbContraseña.Location = new System.Drawing.Point(209, 352);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.Size = new System.Drawing.Size(208, 23);
            this.txbContraseña.TabIndex = 2;
            this.txbContraseña.UseSystemPasswordChar = true;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::CapaPresentacion.Properties.Resources.LogoLogin;
            this.picLogo.Location = new System.Drawing.Point(175, 15);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(291, 224);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.pnlBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlBarra;
        private Panel panel2;
        private TextBox txbUsuario;
        private TextBox txbContraseña;
        private PictureBox picLogo;
        private Button BtnLogin;
        private Label lbUsuario;
        private PictureBox Minimizar;
        private PictureBox Salir;
        private Label lbContraseña;
        private PictureBox picpass;
        private Button btncambiaridioma;
    }
}