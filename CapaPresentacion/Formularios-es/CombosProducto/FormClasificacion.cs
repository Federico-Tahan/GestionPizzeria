using CapaDatos.Dominio;
using CapaNegocio.Implementacion;
using CapaNegocio.Interfaces;
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

namespace CapaPresentacion.Formularios_es.CombosProducto
{
    public partial class FormClasificacion : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        List<Clasificacion> list = new List<Clasificacion>();
        ing_TipoProdClasiUnidadMed lg = new ng_TipoProdClasiUnidadMed();
        Clasificacion cla = new Clasificacion();
        public FormClasificacion()
        {
            InitializeComponent();
        }

        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarBtn(false);
            BtnEditar.Enabled = true;
            TxbtipoProd.Text = string.Empty;
            chkActivo.Checked = true;
            panel1.Visible = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            habilitarBtn(false);
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
            TxbtipoProd.Enabled = true;
            chkActivo.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            habilitarBtn(false);
            btnNuevo.Enabled = true;
            panel1.Visible = false;
            TxbtipoProd.Text = string.Empty;
        }
        private void habilitarBtn(bool a)
        {
            btnNuevo.Enabled = a;
            BtnCancelar.Enabled = a;
            BtnCancelar.Enabled = a;
            BtnGuardar.Enabled = a;
            BtnEditar.Enabled = a;
        }

        private void cargarDgv(List<Clasificacion> lp)
        {
            dgvClasi.Rows.Clear();

            foreach (Clasificacion p in lp)
            {
                if (p.BajaLogica == 0)
                {
                    dgvClasi.Rows.Add(p.IdClasificacion, p.clasificacion, "Si");
                }
                else
                {
                    dgvClasi.Rows.Add(p.IdClasificacion, p.clasificacion, "No");
                }


            }
        }

        private void FormClasificacion_Load(object sender, EventArgs e)
        {
            list = lg.GetClasificacion(0);
            cargarDgv(list);
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
