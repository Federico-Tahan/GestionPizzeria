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
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.RecursoIdioma;

namespace CapaPresentacion
{
    public partial class LogIn : Form
    {
        ing_CrudUsuarios log = new ng_CrudUsuarios();
        int cont = 0;
        private ing_Logeo lg = new ng_Logeo();
        public static Usuarios u = new Usuarios();


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
            AplicarIdioma();
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
                Program.select.Close();
            }
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (validacion())
            {
                AbstraerUsuario(u);
                u = lg.GetUsuario(u);

                if (lg.Logeado(u))
                {
                    cont = 0;
                    lg.RegistroInicio(u.ID_Usuario);
                    Main form = new Main();
                    form.Show();
                    txbContraseña.Text = string.Empty;
                    txbUsuario.Text = string.Empty;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error al iniciar sesion, Verifique Usuario o Contraseña","Error");
                    BloqueoCuenta();
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

        public void Cerrar()
        {
            this.Close();
        }

        public void AplicarIdioma()
        {
            lbContraseña.Text = Rec.Contraseña;
            lbUsuario.Text = Rec.Usuario;
            BtnLogin.Text = Rec.IniciarSesion;
        }

        private void BloqueoCuenta()
        {
            if (log.BuscarAliasUsuario(txbUsuario.Text))
            {
                cont++;
                if (cont == 3)
                {
                    if (log.BloquearUsuario(txbUsuario.Text))
                    {
                        MessageBox.Show("El usuario se ha bloqueado temporalmente, por favor contacta con el gerente.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    };
                }
                else
                {
                    int tope = 3;
                    MessageBox.Show("Tiene " + (tope - cont) + " intentos restantes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

    }
}
