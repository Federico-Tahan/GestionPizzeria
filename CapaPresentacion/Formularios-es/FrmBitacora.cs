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

namespace CapaPresentacion.Formularios_es
{
    public partial class FrmBitacora : Form
    {

        Bitacora bitacora = new Bitacora();
        ing_Bitacora lg = new ng_bitacora();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FrmBitacora()
        {
            InitializeComponent();
        }

        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            bitacora = lg.ObtenerBitacora();
            CargarDgv();
        }

        private void CargarDgv()
        {
            dgvBitacora.Rows.Clear();

            foreach (DetalleBitacora u in bitacora.DetalleBit )
            {

                dgvBitacora.Rows.Add(u.user.ID_Usuario,u.user.Empleado.Nombre + " " + u.user.Empleado.Apellido, u.Fecha_accion,u.Accion);
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cerrar Bitacora", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void RbtCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txbbusqueda.Visible = true;
            CboAccion.Visible = false;
            dtpFecha.Visible = false;
        }

        private void RbtNombre_CheckedChanged(object sender, EventArgs e)
        {
            txbbusqueda.Visible = true;
            CboAccion.Visible = false;
            dtpFecha.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txbbusqueda.Visible = false;
            CboAccion.Visible = false;
            dtpFecha.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txbbusqueda.Visible = false;
            CboAccion.Visible = true;
            dtpFecha.Visible = false;
        }

        private void picreset_Click(object sender, EventArgs e)
        {
            txbbusqueda.Visible = true;
            CboAccion.Visible = false;
            dtpFecha.Visible = false;
            RbtCodigo.Checked = true;
            bitacora = lg.ObtenerBitacora();
            CargarDgv();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (RbtCodigo.Checked)
            {
                if (txbbusqueda.Text != "")
                {
                    try
                    {
                        Convert.ToInt32(txbbusqueda.Text);
                        List<DataGridViewRow> temp = new List<DataGridViewRow>();

                        foreach (DataGridViewRow row in dgvBitacora.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["codigouser"].Value) != Convert.ToInt32(txbbusqueda.Text))
                            {
                                temp.Add(row);
                            }

                        }

                        foreach (DataGridViewRow row in temp)
                        {

                            dgvBitacora.Rows.Remove(row);

                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Debe cargar un codigo para filtrar.");

                    }
                }
                else
                {
                    MessageBox.Show("Debe cargar un codigo para filtrar.");
                }
            }
            else if (RbtNombre.Checked)
            {
                if (txbbusqueda.Text != "")
                {
                    List<DataGridViewRow> temp = new List<DataGridViewRow>();

                    foreach (DataGridViewRow row in dgvBitacora.Rows)
                    {
                        if (Convert.ToString(row.Cells["Nombre"].Value) != txbbusqueda.Text)
                        {
                            temp.Add(row);
                        }

                    }

                    foreach (DataGridViewRow row in temp)
                    {

                        dgvBitacora.Rows.Remove(row);

                    }
                }
                else
                {
                    MessageBox.Show("Debe cargar un Nombre para filtrar.");
                }
            }
            else if (rbtFecha.Checked)
            {
                List<DataGridViewRow> temp = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dgvBitacora.Rows)
                {
                    if (Convert.ToDateTime(row.Cells["fecha"].Value).ToShortDateString() != dtpFecha.Value.ToShortDateString())
                    {
                        temp.Add(row);
                    }

                }

                foreach (DataGridViewRow row in temp)
                {

                    dgvBitacora.Rows.Remove(row);

                }
            }
            else if (rbtAccion.Checked)
            {
                if (CboAccion.SelectedIndex == -1)
                {
                    List<DataGridViewRow> temp = new List<DataGridViewRow>();

                    foreach (DataGridViewRow row in dgvBitacora.Rows)
                    {
                        if (Convert.ToString(row.Cells["Accion"].Value) != CboAccion.Text)
                        {
                            temp.Add(row);
                        }

                    }

                    foreach (DataGridViewRow row in temp)
                    {

                        dgvBitacora.Rows.Remove(row);

                    }
                }
                else
                {
                    MessageBox.Show("Debe cargar una accion para filtrar.");
                }
            }
        }
    }
}
