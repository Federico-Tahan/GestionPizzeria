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
using System.Globalization;
using Microsoft.VisualBasic.ApplicationServices;

namespace CapaPresentacion
{
    public partial class LogIn : Form
    {

        ing_CrudUsuarios log = new ng_CrudUsuarios();
        int cont = 0;
        private ing_Logeo lg = new ng_Logeo();
        public static Usuarios u = new Usuarios();
        string AliasAnterior = "";

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
            DetectarIdioma();
            AplicarIdioma();
        }

        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

            if (MessageBox.Show(Rec.MessageCerrarPrograma, Rec.CapCerrar, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    MessageBox.Show(Rec.MessageErroraliniciarSesion,Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(Rec.MessageCargarUsuario, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }else if (txbContraseña.Text == "")
            {

                MessageBox.Show(Rec.MessageCargarContraseña, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            btncambiaridioma.Text = Rec.BtnCambiarIdioma;
        }

        private void BloqueoCuenta()
        {
            string txbmin;
            txbmin = txbUsuario.Text.ToLower();
            if (txbmin != "admin")
            {


            if (log.BuscarAliasUsuario(txbUsuario.Text))
            {

                if (log.UsuarioAltaoBaja(txbUsuario.Text))
                {
                    if (AliasAnterior == txbUsuario.Text)
                    {
                        cont++;
                        if (cont == 3)
                        {
                            if (log.BloquearUsuario(txbUsuario.Text))
                            {
                                MessageBox.Show(Rec.MessageUsuarioBloqueado, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cont = 0;
                            };
                        }
                        else
                        {
                            int tope = 3;
                            MessageBox.Show(Rec.MessageTiene + " " + (tope - cont) + " " + Rec.MessageIntentos, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            AliasAnterior = txbUsuario.Text;

                        }
                    }
                    else
                    {
                        cont = 1;
                        int tope = 3;
                        MessageBox.Show(Rec.MessageTiene + " " + (tope - cont) + " " + Rec.MessageIntentos, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AliasAnterior = txbUsuario.Text;
                    }
                        
                }
                else
                {
                    MessageBox.Show(Rec.MessageUsuarioBloqueado, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cont = 0;
                    AliasAnterior = txbUsuario.Text;

                }

            }
            else
            {
                AliasAnterior = txbUsuario.Text;

            }
            }
            else
            {
                cont = 0;
                AliasAnterior = txbUsuario.Text; 
            }
        }

        private void DetectarIdioma()
        {
            if (SeleccionIdioma.i.IdIdioma == 2)
            {
                picLogo.Image = Properties.Resources.LogPizzaUs;


                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

                CultureInfo.CurrentCulture = new CultureInfo("en-US");

            }
            else
            {
                picLogo.Image = Properties.Resources.LogoLogin;

                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-AR");
                CultureInfo.CurrentCulture = new CultureInfo("es-ES");


            }
        }

        private void btncambiaridioma_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.select.Show();

        }
    }
}
