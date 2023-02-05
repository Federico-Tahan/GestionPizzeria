using CapaDatos.Dominio;
using CapaNegocio.Implementacion;
using CapaNegocio.Interfaces;
using CapaPresentacion.Formularios;
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

namespace CapaPresentacion
{
    public partial class LogIn : Form
    {
        private ing_Logeo lg = new ng_Logeo();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cerrar el programa", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            if (validacion())
            {
                AbstraerUsuario(u);
                if (lg.Logeado(u))
                {
                    Main form = new Main();
                    form.Show();
                    txbContraseña.Text = string.Empty;
                    txbUsuario.Text = string.Empty;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error al iniciar sesion, Verifique Usuario o Contraseña","Error");
                }
            }
        }

        private void picpass_Click(object sender, EventArgs e)
        {
            if (picpass.Tag != "Desactivar")
            {
                picpass.Tag = "Desactivar";
                txbContraseña.UseSystemPasswordChar = false;
                picpass.Image = Properties.Resources.esconder__1_;
            }
            else
            {
                picpass.Tag = "activar";
                txbContraseña.UseSystemPasswordChar = true;
                picpass.Image = Properties.Resources.mostrar;
            }

        }

        private bool validacion()
        {
            if (txbUsuario.Text == "")
            {
                MessageBox.Show("Debe cargar el usuario para continuar.");
                return false;
            }else if (txbContraseña.Text == "")
            {
                MessageBox.Show("Debe cargar la contraseña para continuar.");
                return false;

            }
            return true;

        }

        private void AbstraerUsuario(Usuarios u)
        {
            u.Alias = txbUsuario.Text;
            u.Contraseña = txbContraseña.Text;
        }
    }
}
