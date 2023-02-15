using CapaDatos.Dominio;
using CapaNegocio.Implementacion;
using CapaNegocio.Interfaces;
using CapaPresentacion.Formularios;
using CapaPresentacion.RecursoIdioma;
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
        TipoProducto tp = new TipoProducto();   

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
            DetectarIdioma();
            AplicarIdioma();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarBtn(true);
            BtnEditar.Enabled = false;
            btnNuevo.Enabled = false;
            TxbTipoProd.Text = string.Empty; TxbTipoProd.Enabled = true;
            chkActivo.Visible = false; chkActivo.Enabled = true;
            panel1.Visible = true;
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
            TxbTipoProd.Enabled = true;
            chkActivo.Enabled = true;
            TxbTipoProd.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            habilitarBtn(false);
            btnNuevo.Enabled = true;
            panel1.Visible= false;
            TxbTipoProd.Text= string.Empty;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxbTipoProd.Text != string.Empty)
            {
                AbstraerTipoPruducto();
                if (tp.IdTipoProducto != 0)
                {
                    if (lg.ModificacionTipoProducto(tp))
                    {
                        MessageBox.Show(Rec.MessageModificacionTipoProdExtio);
                    }
                    else
                    {
                        MessageBox.Show(Rec.MessageModTIpoProdNoExITO);

                    }
                    tp = new TipoProducto();
                    panel1.Visible = false;
                    habilitarBtn(false);
                    btnNuevo.Enabled = true;
                    listTipoProd = lg.GetTipoProductos(0);
                    cargarDgv(listTipoProd);
                }
                else
                {
                    if (lg.AltaTipoProducto(tp))
                    {
                        MessageBox.Show(Rec.MessageAltaTipoProdExito);
                    }
                    else
                    {
                        MessageBox.Show(Rec.MessageAltaTipoProDNOExtio);

                    }
                    tp = new TipoProducto();
                    panel1.Visible = false;
                    habilitarBtn(false);
                    btnNuevo.Enabled = true;
                    listTipoProd = lg.GetTipoProductos(0);
                    cargarDgv(listTipoProd);
                }

            }
            else
            {
                MessageBox.Show(Rec.MessageDebeCargarTipoProducto);
            }
        }

        private void AbstraerTipoPruducto()
        {
            tp.Tipo_producto = TxbTipoProd.Text;
            if (chkActivo.Checked)
            {
                tp.Baja_logica = 0;
            }
            else
            {
                tp.Baja_logica = 1;
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

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

        private void picbajar_Click(object sender, EventArgs e)
        {
            TxbTipoProd.Text = string.Empty;
            panel1.Visible = false;
            habilitarBtn(false);
            btnNuevo.Enabled = true;
        }

        private void RbtActivo_CheckedChanged(object sender, EventArgs e)
        {
            listTipoProd = lg.GetTipoProductos(0);
            cargarDgv(listTipoProd);
        }

        private void RbtNoActivo_CheckedChanged(object sender, EventArgs e)
        {
            listTipoProd = lg.GetTipoProductos(1);
            cargarDgv(listTipoProd);
        }

        private void rbtTodos_CheckedChanged(object sender, EventArgs e)
        {
            listTipoProd = lg.GetTipoProductos(2);
            cargarDgv(listTipoProd);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txbBusqeuda.Text != "")
            {
                try
                {
                    Convert.ToInt32(txbBusqeuda.Text);
                    List<DataGridViewRow> temp = new List<DataGridViewRow>();

                    foreach (DataGridViewRow row in dgvTipoProd.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["CodigoTipoProd"].Value) != Convert.ToInt32(txbBusqeuda.Text))
                        {
                            temp.Add(row);
                        }

                    }

                    foreach (DataGridViewRow row in temp)
                    {

                        dgvTipoProd.Rows.Remove(row);

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(Rec.MessageCargarCodigoParafiltrar);

                }
            }
            else
            {
                MessageBox.Show(Rec.MessageCargarCodigoParafiltrar);
            }
        }

        private void dgvTipoProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tp = new TipoProducto();
            if (dgvTipoProd.Columns[e.ColumnIndex].Name == "Accion")
            {
                CargarTipoProd(Convert.ToInt32(dgvTipoProd.CurrentRow.Cells[0].Value));
                TxbTipoProd.Text = tp.Tipo_producto;
                if (tp.Baja_logica == 0)
                {
                    chkActivo.Checked = true;
                }
                else
                {
                    chkActivo.Checked = false;
                }
                chkActivo.Visible = true;
                panel1.Visible = true;
                TxbTipoProd.Enabled = false;
                chkActivo.Enabled = false;
                habilitarBtn(false);
                BtnEditar.Enabled = true;
            }
        }

        private void CargarTipoProd(int c)
        {
            foreach (TipoProducto u in listTipoProd)
            {
                if (u.IdTipoProducto == c)
                {
                    tp = u;
                    break;
                }
            }
        }

        private void DetectarIdioma()
        {
            if (SeleccionIdioma.i.IdIdioma == 2)
            {

                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            }
            else
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-AR");

            }
        }

        private void AplicarIdioma()
        {
            btnNuevo.Text = Rec.Nuevo;
            BtnEditar.Text = Rec.Editar;
            BtnCancelar.Text = Rec.Cancelar;
            BtnGuardar.Text = Rec.Guardar;
            chkActivo.Text = Rec.Activo;
            lb.Text = Rec.TipoProducto;
            lbTipoProd.Text = Rec.TipoProducto;
            BtnBuscar.Text = Rec.Buscar;
            RbtActivo.Text = Rec.Activo;
            RbtNoActivo.Text = Rec.noactivo;
            rbtTodos.Text = Rec.Todos;
            lbcodtipoprod.Text = Rec.CodigoTipoProducto;
            dgvTipoProd.Columns[0].HeaderText = Rec.CodigoTipoProducto;
            dgvTipoProd.Columns[1].HeaderText = Rec.TipoProducto;
            dgvTipoProd.Columns[2].HeaderText = Rec.Activo;
            dgvTipoProd.Columns[3].HeaderText = Rec.Accion;
        }
    }
}
