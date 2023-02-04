namespace CapaPresentacion.Formularios
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.submenu2 = new System.Windows.Forms.Panel();
            this.btnDescuentos = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.pnlSubmenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picConfig = new System.Windows.Forms.PictureBox();
            this.lbCierre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlNoti = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.PicCampana = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbfecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.submenu2.SuspendLayout();
            this.pnlSubmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlNoti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCampana)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
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
            this.pnlBarra.Size = new System.Drawing.Size(1216, 35);
            this.pnlBarra.TabIndex = 1;
            this.pnlBarra.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarra_Paint);
            this.pnlBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_MouseDown);
            // 
            // Minimizar
            // 
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimizar.Image = global::CapaPresentacion.Properties.Resources.minimize_sign;
            this.Minimizar.Location = new System.Drawing.Point(1146, 0);
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
            this.Salir.Location = new System.Drawing.Point(1181, 0);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(35, 35);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Salir.TabIndex = 0;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlMenu.Controls.Add(this.submenu2);
            this.pnlMenu.Controls.Add(this.btnGestion);
            this.pnlMenu.Controls.Add(this.pnlSubmenu);
            this.pnlMenu.Controls.Add(this.btnAdmin);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Controls.Add(this.BtnCliente);
            this.pnlMenu.Controls.Add(this.picMain);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 35);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(218, 641);
            this.pnlMenu.TabIndex = 2;
            // 
            // submenu2
            // 
            this.submenu2.AutoScroll = true;
            this.submenu2.Controls.Add(this.btnDescuentos);
            this.submenu2.Controls.Add(this.BtnProductos);
            this.submenu2.Controls.Add(this.BtnUsuarios);
            this.submenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.submenu2.Location = new System.Drawing.Point(0, 400);
            this.submenu2.Name = "submenu2";
            this.submenu2.Size = new System.Drawing.Size(218, 142);
            this.submenu2.TabIndex = 22;
            this.submenu2.Visible = false;
            // 
            // btnDescuentos
            // 
            this.btnDescuentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnDescuentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescuentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDescuentos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDescuentos.FlatAppearance.BorderSize = 0;
            this.btnDescuentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnDescuentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescuentos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDescuentos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDescuentos.Image = global::CapaPresentacion.Properties.Resources.cajero;
            this.btnDescuentos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescuentos.Location = new System.Drawing.Point(0, 96);
            this.btnDescuentos.Name = "btnDescuentos";
            this.btnDescuentos.Size = new System.Drawing.Size(218, 46);
            this.btnDescuentos.TabIndex = 16;
            this.btnDescuentos.Text = "Descuentos";
            this.btnDescuentos.UseVisualStyleBackColor = false;
            this.btnDescuentos.Click += new System.EventHandler(this.btnDescuentos_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProductos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnProductos.FlatAppearance.BorderSize = 0;
            this.BtnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnProductos.Image = global::CapaPresentacion.Properties.Resources.cajero;
            this.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProductos.Location = new System.Drawing.Point(0, 48);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(218, 48);
            this.BtnProductos.TabIndex = 15;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.UseVisualStyleBackColor = false;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnUsuarios.FlatAppearance.BorderSize = 0;
            this.BtnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUsuarios.Image = global::CapaPresentacion.Properties.Resources.cajero;
            this.BtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUsuarios.Location = new System.Drawing.Point(0, 0);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(218, 48);
            this.BtnUsuarios.TabIndex = 14;
            this.BtnUsuarios.Text = "Usuarios";
            this.BtnUsuarios.UseVisualStyleBackColor = false;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // btnGestion
            // 
            this.btnGestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnGestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGestion.FlatAppearance.BorderSize = 0;
            this.btnGestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestion.Image = global::CapaPresentacion.Properties.Resources.cajero;
            this.btnGestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestion.Location = new System.Drawing.Point(0, 353);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(218, 47);
            this.btnGestion.TabIndex = 21;
            this.btnGestion.Text = "Gestión";
            this.btnGestion.UseVisualStyleBackColor = false;
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            // 
            // pnlSubmenu
            // 
            this.pnlSubmenu.Controls.Add(this.button2);
            this.pnlSubmenu.Controls.Add(this.btnProd);
            this.pnlSubmenu.Controls.Add(this.btnVender);
            this.pnlSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenu.Location = new System.Drawing.Point(0, 223);
            this.pnlSubmenu.Name = "pnlSubmenu";
            this.pnlSubmenu.Size = new System.Drawing.Size(218, 130);
            this.pnlSubmenu.TabIndex = 16;
            this.pnlSubmenu.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::CapaPresentacion.Properties.Resources.cajero;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(0, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 44);
            this.button2.TabIndex = 16;
            this.button2.Text = "Reporte";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnProd
            // 
            this.btnProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProd.FlatAppearance.BorderSize = 0;
            this.btnProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProd.Image = global::CapaPresentacion.Properties.Resources.cajero;
            this.btnProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProd.Location = new System.Drawing.Point(0, 46);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(218, 40);
            this.btnProd.TabIndex = 15;
            this.btnProd.Text = "Consultar";
            this.btnProd.UseVisualStyleBackColor = false;
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVender.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVender.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVender.Image = global::CapaPresentacion.Properties.Resources.cajero;
            this.btnVender.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVender.Location = new System.Drawing.Point(0, 0);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(218, 46);
            this.btnVender.TabIndex = 14;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdmin.Image = global::CapaPresentacion.Properties.Resources.cajero;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 170);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(218, 53);
            this.btnAdmin.TabIndex = 15;
            this.btnAdmin.Text = "Ventas";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picConfig);
            this.panel1.Controls.Add(this.lbCierre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 543);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 98);
            this.panel1.TabIndex = 10;
            // 
            // picConfig
            // 
            this.picConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picConfig.Image = global::CapaPresentacion.Properties.Resources.configuraciones;
            this.picConfig.Location = new System.Drawing.Point(184, 65);
            this.picConfig.Name = "picConfig";
            this.picConfig.Size = new System.Drawing.Size(28, 24);
            this.picConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConfig.TabIndex = 13;
            this.picConfig.TabStop = false;
            this.picConfig.Visible = false;
            this.picConfig.Click += new System.EventHandler(this.picConfig_Click);
            // 
            // lbCierre
            // 
            this.lbCierre.AutoSize = true;
            this.lbCierre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCierre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCierre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCierre.Location = new System.Drawing.Point(97, 45);
            this.lbCierre.Name = "lbCierre";
            this.lbCierre.Size = new System.Drawing.Size(84, 16);
            this.lbCierre.TabIndex = 11;
            this.lbCierre.Text = "Cerrar Sesión";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(82, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.perfilhom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCliente
            // 
            this.BtnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCliente.FlatAppearance.BorderSize = 0;
            this.BtnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCliente.Image = global::CapaPresentacion.Properties.Resources.Client;
            this.BtnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCliente.Location = new System.Drawing.Point(0, 117);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(218, 53);
            this.BtnCliente.TabIndex = 5;
            this.BtnCliente.Text = "Clientes";
            this.BtnCliente.UseVisualStyleBackColor = false;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // picMain
            // 
            this.picMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.picMain.Image = global::CapaPresentacion.Properties.Resources.pizzaGrandeLogo;
            this.picMain.Location = new System.Drawing.Point(0, 0);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(218, 117);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMain.TabIndex = 0;
            this.picMain.TabStop = false;
            this.picMain.Click += new System.EventHandler(this.picMain_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlMain.Controls.Add(this.pnlNoti);
            this.pnlMain.Controls.Add(this.PicCampana);
            this.pnlMain.Controls.Add(this.panel5);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.panel6);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.lbfecha);
            this.pnlMain.Controls.Add(this.lbHora);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(218, 35);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(998, 641);
            this.pnlMain.TabIndex = 3;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlNoti
            // 
            this.pnlNoti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlNoti.Controls.Add(this.label5);
            this.pnlNoti.Location = new System.Drawing.Point(757, 53);
            this.pnlNoti.Name = "pnlNoti";
            this.pnlNoti.Size = new System.Drawing.Size(219, 75);
            this.pnlNoti.TabIndex = 11;
            this.pnlNoti.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(22, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 50);
            this.label5.TabIndex = 1;
            this.label5.Text = "Productos bajos \r\n       en stock!";
            // 
            // PicCampana
            // 
            this.PicCampana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicCampana.Image = global::CapaPresentacion.Properties.Resources.campana1;
            this.PicCampana.Location = new System.Drawing.Point(935, 14);
            this.PicCampana.Name = "PicCampana";
            this.PicCampana.Size = new System.Drawing.Size(41, 44);
            this.PicCampana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicCampana.TabIndex = 12;
            this.PicCampana.TabStop = false;
            this.PicCampana.Tag = "vacio";
            this.PicCampana.Click += new System.EventHandler(this.PicCampana_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(757, 275);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(167, 34);
            this.panel5.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(22, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ventas del Dia";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(757, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 34);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(22, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Recaudo Diario";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(757, 463);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(167, 164);
            this.panel6.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(-1, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(167, 34);
            this.panel7.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(22, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ventas del Mes";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(757, 273);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(167, 170);
            this.panel4.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(757, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 162);
            this.panel2.TabIndex = 9;
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbfecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbfecha.Location = new System.Drawing.Point(111, 342);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(208, 58);
            this.lbfecha.TabIndex = 8;
            this.lbfecha.Text = "lbfecha";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbHora.Location = new System.Drawing.Point(158, 227);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(358, 115);
            this.lbHora.TabIndex = 7;
            this.lbHora.Text = "lbHora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 676);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.submenu2.ResumeLayout(false);
            this.pnlSubmenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlNoti.ResumeLayout(false);
            this.pnlNoti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCampana)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlBarra;
        private PictureBox Minimizar;
        private PictureBox Salir;
        private Panel pnlMenu;
        private PictureBox picMain;
        private Panel pnlMain;
        private Button BtnCliente;
        private Panel panel1;
        private Label lbCierre;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lbfecha;
        private Label lbHora;
        private System.Windows.Forms.Timer timer1;
        private Panel panel6;
        private Panel panel7;
        private Label label4;
        private Panel panel4;
        private Panel panel2;
        private Panel pnlSubmenu;
        private Button btnProd;
        private Button btnVender;
        private Button btnAdmin;
        private Panel panel5;
        private Label label3;
        private Panel panel3;
        private Label label2;
        private PictureBox picConfig;
        private Panel submenu2;
        private Button btnDescuentos;
        private Button BtnProductos;
        private Button BtnUsuarios;
        private Button btnGestion;
        private Button button2;
        private Panel pnlNoti;
        private Label label5;
        private PictureBox PicCampana;
    }
}