﻿using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class SeleccionIdioma : Form
    {
        public static LogIn log;
        public static Idioma i;


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]



        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public SeleccionIdioma()
        {
            InitializeComponent();
        }

        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picEspaña_Click(object sender, EventArgs e)
        {
            i = new Idioma();
            i.IdIdioma = 1;
            i.NombreIdioma = "Español";
            log = new LogIn();
            log.Show();
            this.Hide();
        }

        private void picIngles_Click(object sender, EventArgs e)
        {
            i = new Idioma();
            i.IdIdioma = 2;
            i.NombreIdioma = "Ingles";
            log = new LogIn();
            log.Show();
            this.Hide();
        }

        private void SeleccionIdioma_Load(object sender, EventArgs e)
        {
            piclogo.Image = Properties.Resources.pizzalogograndee;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}