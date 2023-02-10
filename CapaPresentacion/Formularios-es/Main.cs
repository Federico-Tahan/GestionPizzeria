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

namespace CapaPresentacion.Formularios
{
    public partial class Main : Form
    {
        Form FormActual;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Main()
        {
            InitializeComponent();
        }

        public void AbrirFormEnPanel(Form Formhijo)
        {
            if (FormActual != null)
            {
                FormActual.Close();
            }
            FormActual = Formhijo;
            Formhijo.TopLevel = false;
            Formhijo.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(Formhijo);
            pnlMain.Tag = Formhijo;
            this.Size = new Size(Formhijo.Size.Width + 218, Formhijo.Size.Height);
            Formhijo.BringToFront();
            Formhijo.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lbUsuario.Text = LogIn.u.Empleado.Nombre + " " + LogIn.u.Empleado.Apellido;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
            lbfecha.Text = DateTime.Now.ToString("dddd MMMM  yyyy");
        }

        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlBarra_Paint(object sender, PaintEventArgs e)
        { 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlSubmenu.Visible = !pnlSubmenu.Visible;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cerrar el programa", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Program.log.Close();
            }
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            pnlSubmenu.Visible = !pnlSubmenu.Visible;
            submenu2.Visible = false;

        }

        private void BtnBackUp_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Configuration());
        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmDescuentos());

        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            submenu2.Visible = !submenu2.Visible;
            pnlSubmenu.Visible = false;
        }

        private void BtnFacturas_Click(object sender, EventArgs e)
        {
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CrudClientes());
            hidemenus();
        }

        private void picConfig_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Configuration());

        }

        private void btnDescuentos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmDescuentos());

        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CrudProductos());

        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CrudUsuarios());

        }

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
        private void hidemenus()
        {
            pnlSubmenu.Visible = false;
            submenu2.Visible = false;
        }

        private void picMain_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Remove(FormActual);
            hidemenus();
        }

        private void lbCierre_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar Sesion?","Cerrar Sesión",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                Program.log.Show();
                LogIn.u = new Usuarios();
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ConsultaVentas());

        }
    }
}
