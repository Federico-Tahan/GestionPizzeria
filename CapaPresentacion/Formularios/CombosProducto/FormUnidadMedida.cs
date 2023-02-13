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

namespace CapaPresentacion.Formularios.CombosProducto
{
    public partial class FormUnidadMedida : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        ing_TipoProdClasiUnidadMed lg = new ng_TipoProdClasiUnidadMed();
        UnidadMedida tp = new UnidadMedida();
        List<UnidadMedida> lUnidadMedida = new List<UnidadMedida>();
        public FormUnidadMedida()
        {
            InitializeComponent();
        }

        private void FormUnidadMedida_Load(object sender, EventArgs e)
        {
            lUnidadMedida = lg.GetUnidadMedida(0);
            cargarDgv(lUnidadMedida);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarBtn(true);
            BtnEditar.Enabled = false;
            btnNuevo.Enabled = false;
            TxbUnidadMedida.Text = string.Empty; TxbUnidadMedida.Enabled = true;
            chkActivo.Checked = true; chkActivo.Enabled = true;
            panel1.Visible = true;
            chkActivo.Visible = false;

        }
        private void habilitarBtn(bool a)
        {
            btnNuevo.Enabled = a;
            BtnCancelar.Enabled = a;
            BtnCancelar.Enabled = a;
            BtnGuardar.Enabled = a;
            BtnEditar.Enabled = a;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            habilitarBtn(false);
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
            TxbUnidadMedida.Enabled = true;
            chkActivo.Enabled = true;
            TxbUnidadMedida.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            habilitarBtn(false);
            btnNuevo.Enabled = true;
            panel1.Visible = false;
            TxbUnidadMedida.Text = string.Empty;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxbUnidadMedida.Text != string.Empty)
            {
                AbstraerUnidadMedida();
                if (tp.IdUnidadMedida != 0)
                {
                    if (lg.ModificacionUnidadMedida(tp))
                    {
                        MessageBox.Show("Modificacion de Unidad de Medida realizada con Exito.");
                    }
                    else
                    {
                        MessageBox.Show("Modificacion de Unidad de Medida no se ha realizado con Exito.");

                    }
                    tp = new UnidadMedida();
                    panel1.Visible = false;
                    habilitarBtn(false);
                    btnNuevo.Enabled = true;
                    lUnidadMedida = lg.GetUnidadMedida(0);
                    cargarDgv(lUnidadMedida);
                }
                else
                {
                    if (lg.AltaUnidadMedida(tp))
                    {
                        MessageBox.Show("Alta de Unidad de Medida realizada con Exito.");
                    }
                    else
                    {
                        MessageBox.Show("Alta de Unidad de Medida no se ha realizado con Exito.");

                    }
                    tp = new UnidadMedida();
                    panel1.Visible = false;
                    habilitarBtn(false);
                    btnNuevo.Enabled = true;
                    lUnidadMedida = lg.GetUnidadMedida(0);
                    cargarDgv(lUnidadMedida);
                }

            }
            else
            {
                MessageBox.Show("Debe Cargar la Clasifiacion");
            }
        }

        private void AbstraerUnidadMedida()
        {
            tp.Unidad_Medida = TxbUnidadMedida.Text;
            if (chkActivo.Checked)
            {
                tp.Baja_Logica = 0;
            }
            else
            {
                tp.Baja_Logica = 1;
            }
        }

        private void picbajar_Click(object sender, EventArgs e)
        {
            TxbUnidadMedida.Text = string.Empty;
            panel1.Visible = false;
            habilitarBtn(false);
            btnNuevo.Enabled = true;
        }

        private void dgvUnidadMedida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tp = new UnidadMedida();
            if (dgvUnidadMedida.Columns[e.ColumnIndex].Name == "Accion")
            {
                CargarUnidadMedida(Convert.ToInt32(dgvUnidadMedida.CurrentRow.Cells[0].Value));
                TxbUnidadMedida.Text = tp.Unidad_Medida;
                if (tp.Baja_Logica == 0)
                {
                    chkActivo.Checked = true;
                }
                else
                {
                    chkActivo.Checked = false;
                }
                chkActivo.Visible = true;

                panel1.Visible = true;
                TxbUnidadMedida.Enabled = false;
                chkActivo.Enabled = false;
                habilitarBtn(false);
                BtnEditar.Enabled = true;
            }
        }

        private void CargarUnidadMedida(int c)
        {
            foreach (UnidadMedida u in lUnidadMedida)
            {
                if (u.IdUnidadMedida == c)
                {
                    tp = u;
                    break;
                }
            }
        }

        private void RbtActivo_CheckedChanged(object sender, EventArgs e)
        {
            lUnidadMedida = lg.GetUnidadMedida(0);
            cargarDgv(lUnidadMedida);
        }

        private void cargarDgv(List<UnidadMedida> lp)
        {
            dgvUnidadMedida.Rows.Clear();

            foreach (UnidadMedida p in lp)
            {
                if (p.Baja_Logica == 0)
                {
                    dgvUnidadMedida.Rows.Add(p.IdUnidadMedida, p.Unidad_Medida, "Si");
                }
                else
                {
                    dgvUnidadMedida.Rows.Add(p.IdUnidadMedida, p.Unidad_Medida, "No");
                }


            }
        }

        private void RbtNoActivo_CheckedChanged(object sender, EventArgs e)
        {
            lUnidadMedida = lg.GetUnidadMedida(1);
            cargarDgv(lUnidadMedida);
        }

        private void rbtTodos_CheckedChanged(object sender, EventArgs e)
        {
            lUnidadMedida = lg.GetUnidadMedida(2);
            cargarDgv(lUnidadMedida);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txbBusqeuda.Text != "")
            {
                try
                {
                    Convert.ToInt32(txbBusqeuda.Text);
                    List<DataGridViewRow> temp = new List<DataGridViewRow>();

                    foreach (DataGridViewRow row in dgvUnidadMedida.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["CodigoTipoProd"].Value) != Convert.ToInt32(txbBusqeuda.Text))
                        {
                            temp.Add(row);
                        }

                    }

                    foreach (DataGridViewRow row in temp)
                    {

                        dgvUnidadMedida.Rows.Remove(row);

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

        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}
