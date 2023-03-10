using CapaPresentacion.Formularios.Venta;
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
using CapaDatos.Dominio;
using CapaNegocio.Implementacion;
using CapaNegocio.Interfaces;
using Microsoft.VisualBasic.Logging;
using CapaPresentacion.RecursoIdioma;
using System.Globalization;

namespace CapaPresentacion.Formularios
{
    public partial class Main : Form
    {
        Form FormActual;
        private int PreviousWidth = 0;
        private int PreviousHeight = 0;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private ing_Logeo lg = new ng_Logeo();
        private ing_DatosExtra dt = new ng_DatosExtra();


        public Main()
        {
            InitializeComponent();
        }

        //abre el form en el panel del centro
        public void AbrirFormEnPanel(Form Formhijo)
        {
            if (FormActual != null)
            {
                FormActual.Close();
            }
            FormActual = Formhijo;
            Formhijo.TopLevel = false;
            if (this.WindowState == FormWindowState.Maximized)
            {
                Formhijo.WindowState= FormWindowState.Maximized;
            }
            else
            {
                Formhijo.WindowState = FormWindowState.Normal;

            }
            Formhijo.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(Formhijo);
            pnlMain.Tag = Formhijo;
            this.Size = new Size(Formhijo.Size.Width + 218, Formhijo.Size.Height);
            Formhijo.BringToFront();
            Formhijo.Show();
        }
        //detecta y applica idioma, carga textos 
        private void Main_Load(object sender, EventArgs e)
        {
            
            DetectarIdioma();
            AplicarIdioma();
            lbUsuario.Text = LogIn.u.Empleado.Nombre + " " + LogIn.u.Empleado.Apellido;
            visibilidadRoles();
            lbrecaudodiario.Text = dt.RecaudadoDiario().ToString();
            lbventasdeldia.Text = dt.VentasdelDia().ToString();
            lbventasdelmes.Text = dt.VentasdelMes().ToString();
            VentaRol();
        }
        //actualiza la hora y fecha

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
            lbfecha.Text = DateTime.Now.ToString("dddd MMMM  yyyy");
        }
        //mueve el form
        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlBarra_Paint(object sender, PaintEventArgs e)
        { 
        }

        //menu visible si apreta botones
        private void button3_Click(object sender, EventArgs e)
        {
            pnlSubmenu.Visible = !pnlSubmenu.Visible;
        }
        //sale del fom
        private void Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Rec.MessageCerrarPrograma, Rec.CapCerrar, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lg.RegistroSalida(LogIn.u.ID_Usuario);
                Program.select.Close();
                
            }
        }
        //minizmiza formulario 
        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
        //menu visible si apreta botones

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            pnlSubmenu.Visible = !pnlSubmenu.Visible;
            submenu2.Visible = false;

        }
        private void BtnBackUp_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Configuration());
        }
        //entra a descuento
        private void btnDescuento_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmDescuentos());

        }
        //abre panel gestion
        private void btnGestion_Click(object sender, EventArgs e)
        {
            submenu2.Visible = !submenu2.Visible;
            pnlSubmenu.Visible = false;
        }
        private void BtnFacturas_Click(object sender, EventArgs e)
        {
        }
        //entra crud cliente
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CrudClientes());
            hidemenus();
        }
        //BOTON DE CONFIGURACION

        private void picConfig_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Configuration());

        }
        //entra crud descuento

        private void btnDescuentos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmDescuentos());

        }
        //entra crud prodcuto
        private void BtnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CrudProductos());

        }
        //entra crud usuario
        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CrudUsuarios());

        }
        //entra crud vender
        private void btnVender_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new AltaVenta());

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PicCampana_Click(object sender, EventArgs e)
        {

        }
        //oculta submenues
        private void hidemenus()
        {
            pnlSubmenu.Visible = false;
            submenu2.Visible = false;
        }
        //vuelve al main
        private void picMain_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Remove(FormActual);
            hidemenus();
            lbrecaudodiario.Text = dt.RecaudadoDiario().ToString();
            lbventasdeldia.Text = dt.VentasdelDia().ToString();
            lbventasdelmes.Text = dt.VentasdelMes().ToString();
            this.Size = new Size(1216, 676);
            pnlMain.Size = new Size(998, 641);

        }
        //cierra sesion
        private void lbCierre_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Rec.MessageDeseaCerrarSesion,Rec.CapCerrarSesion,MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lg.RegistroSalida(LogIn.u.ID_Usuario);
                this.Close();
                Program.select.Show();
                LogIn.u = new Usuarios();
            }

        }
        //entra a consulta de ventas
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ConsultaVentas());

        }
        //aplica visiblidad dependiendo los roles

        private void visibilidadRoles()
        {
            if (LogIn.u.Rol.Id_Rol == 4 )
            {
                btnVender.Visible = false;
                BtnCliente.Visible = false;
                picConfig.Visible = false;
                btnDescuentos.Visible = false;  
                BtnProductos.Visible = false;

            }else if (LogIn.u.Rol.Id_Rol == 5)
            {
                picConfig.Visible = false;
                lbrecaudodiario.Visible = false;
                lbventasdeldia.Visible = false;
                lbventasdelmes.Visible = false;
                btnGestion.Visible = true;

            }
            else if (LogIn.u.Rol.Id_Rol == 6)
            {
                picConfig.Visible = false;
                BtnProductos.Visible = false;
                lbrecaudodiario.Visible = false;
                lbventasdeldia.Visible = false;
                lbventasdelmes.Visible = false;
                btnGestion.Visible = true;


            }
            else if (LogIn.u.Rol.Id_Rol == 2)
            {
                lbrecaudodiario.Visible = false;
                lbventasdeldia.Visible = false;
                lbventasdelmes.Visible = false;
                btnVender.Visible = true;


            }
        }
        //detecta idioma
        private void DetectarIdioma()
        {
            if (SeleccionIdioma.i.IdIdioma == 2)
            {

                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

                CultureInfo.CurrentCulture = new CultureInfo("en-US");
            }   
            else
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-AR");
                CultureInfo.CurrentCulture = new CultureInfo("es-ES");


            }
        }
        //aplica idioma
        private void AplicarIdioma()
        {
            BtnCliente.Text = Rec.BtnCliente;
            btnAdmin.Text = Rec.BtnVentas;
            btnVender.Text = Rec.BtnVender;
            btnGestion.Text = Rec.BtnGestion;
            BtnProductos.Text = Rec.BtnProducto;
            BtnUsuarios.Text = Rec.BtnUsuario;
            btnDescuentos.Text = Rec.BtnDescuento;
            lbCierre.Text = Rec.CerrarSesion;
            lbRecauddoDiario.Text = Rec.RecaudoDiario;
            lbVentasDelDiaa.Text = Rec.VentaDiaria;
            LbVetnasdelMes.Text = Rec.VentasMes;
            btnConsultar.Text = Rec.BtnConsultar;
        }
        //aplica roles
        private void VentaRol()
        {
            if (LogIn.u.Rol.Id_Rol != 1 && LogIn.u.Rol.Id_Rol != 6 && LogIn.u.Rol.Id_Rol != 5 && LogIn.u.Rol.Id_Rol != 2)
            {
                btnVender.Visible = false;
            }
        }



        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;

            }
            else
            {
                this.WindowState = FormWindowState.Maximized;

            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pnlMain_Resize(object sender, EventArgs e)
        {

        }

        private void pnlMain_SizeChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox5_Click_3(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void pictureBox5_Click_4(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }
        private Dictionary<Control, Point> originalSizes = new Dictionary<Control, Point>();

        private void pnlMain_SizeChanged_1(object sender, EventArgs e)
        {

        }
    }
}
