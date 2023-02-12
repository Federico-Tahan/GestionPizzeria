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
    public partial class FormTipoProd : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        List<TipoProducto> listTipoProd = new List<TipoProducto>();
        ing_TipoProdClasiUnidadMed lg = new ng_TipoProdClasiUnidadMed();

        public FormTipoProd()
        {
            InitializeComponent();
        }

        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormTipoProd_Load(object sender, EventArgs e)
        {
            listTipoProd = lg.GetTipoProductos(0);
            cargarDgv(listTipoProd);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarBtn(false);
            BtnEditar.Enabled = true;
            TxbtipoProd.Text = string.Empty;
            chkActivo.Checked = true;
        }

        private void habilitarBtn(bool a)
        {
            btnNuevo.Enabled = a;
            BtnCancelar.Enabled = a;
            BtnCancelar.Enabled = a;
            BtnGuardar.Enabled = a;
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
            panel1.Visible= false;
            TxbtipoProd.Text= string.Empty;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cargarDgv(List<TipoProducto> lp)
        {
            dgvTipoProd.Rows.Clear();

            foreach (TipoProducto p in lp)
            {
                if (p.Baja_logica == 0)
                {
                    dgvTipoProd.Rows.Add(p.IdTipoProducto, p.Tipo_producto, "Si");
                }
                else
                {
                    dgvTipoProd.Rows.Add(p.IdTipoProducto, p.Tipo_producto, "No");
                }


            }
        }
    }
}
