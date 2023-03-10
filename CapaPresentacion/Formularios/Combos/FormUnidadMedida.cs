using CapaDatos.Dominio;
using CapaNegocio.Implementacion;
using CapaNegocio.Interfaces;
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

namespace CapaPresentacion.Formularios.CombosProducto
{
    public partial class FormUnidadMedida : Form
    {
        //permite arrastrar el formualrio
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
        //carga lista dgv y aplica idioma
        private void FormUnidadMedida_Load(object sender, EventArgs e)
        {
            lUnidadMedida = lg.GetUnidadMedida(0);
            cargarDgv(lUnidadMedida);
            DetectarIdioma();
            AplicarIdioma();
        }
        //dhabilitas o deshabilita botones + campos en formualario
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
        //habilita o deshabiltia botones
        private void habilitarBtn(bool a)
        {
            btnNuevo.Enabled = a;
            BtnCancelar.Enabled = a;
            BtnCancelar.Enabled = a;
            BtnGuardar.Enabled = a;
            BtnEditar.Enabled = a;
        }
        //habilita botones y campos para editar

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            habilitarBtn(false);
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
            TxbUnidadMedida.Enabled = true;
            chkActivo.Enabled = true;
            TxbUnidadMedida.Enabled = true;
        }
        //cierra el panel formulario y deja todo limpio
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            habilitarBtn(false);
            btnNuevo.Enabled = true;
            panel1.Visible = false;
            TxbUnidadMedida.Text = string.Empty;
        }
        //boton guardar, verifica si se modifica o se inserta nuevo, valida datos y abstrae objeto
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxbUnidadMedida.Text != string.Empty)
            {
                AbstraerUnidadMedida();
                if (tp.IdUnidadMedida != 0)
                {
                    if (lg.ModificacionUnidadMedida(tp, LogIn.u))
                    {
                        MessageBox.Show(Rec.MessageModUMEXito);
                    }
                    else
                    {
                        MessageBox.Show(Rec.MessageModUMNoExito);

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
                    if (lg.AltaUnidadMedida(tp, LogIn.u))
                    {
                        MessageBox.Show(Rec.MessageAltaUMExito);
                    }
                    else
                    {
                        MessageBox.Show(Rec.MessageAltaUMNOExtio);

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
                MessageBox.Show(Rec.MessageDebecargarClasi);
            }
        }
        //abstrae objeto
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
        //igual que boton cancenlar
        private void picbajar_Click(object sender, EventArgs e)
        {
            TxbUnidadMedida.Text = string.Empty;
            panel1.Visible = false;
            habilitarBtn(false);
            btnNuevo.Enabled = true;
        }
        //carga el unidad de merdida seleccionada  al panel para ver detalle
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
        //carga objeto de unidad med
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
        //dependiedo si esta selecciionado activo no acitvo o todos se mostrara
        private void RbtActivo_CheckedChanged(object sender, EventArgs e)
        {
            lUnidadMedida = lg.GetUnidadMedida(0);
            cargarDgv(lUnidadMedida);
        }
        //carga la datagrid
        private void cargarDgv(List<UnidadMedida> lp)
        {
            dgvUnidadMedida.Rows.Clear();

            foreach (UnidadMedida p in lp)
            {
                if (p.Baja_Logica == 0)
                {
                    dgvUnidadMedida.Rows.Add(p.IdUnidadMedida, p.Unidad_Medida, Rec.Si);
                }
                else
                {
                    dgvUnidadMedida.Rows.Add(p.IdUnidadMedida, p.Unidad_Medida, Rec.No);
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
        //filtros segun el seleccionado
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
                    MessageBox.Show(Rec.MessageCargarCodigoParafiltrar);

                }
            }
            else
            {
                MessageBox.Show(Rec.MessageCargarCodigoParafiltrar);
            }
        }
        //permite que se mueva el form
        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //cierra formaulario
        private void Salir_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
            this.Close();
        }
        //aplica el texto
        private void AplicarIdioma()
        {
            lbum.Text = Rec.UnidadMedida;
            btnNuevo.Text = Rec.Nuevo;
            BtnEditar.Text = Rec.Editar;
            BtnCancelar.Text = Rec.Cancelar;
            BtnGuardar.Text = Rec.Guardar;
            lb.Text = Rec.UnidadMedida;
            chkActivo.Text = Rec.Activo;
            lbcodum.Text = Rec.CodigoUm;
            BtnBuscar.Text = Rec.Buscar;
            RbtActivo.Text = Rec.Activo;
            RbtNoActivo.Text = Rec.noactivo;
            rbtTodos.Text = Rec.Todos;
            dgvUnidadMedida.Columns[0].HeaderText = Rec.CodigoUm;
            dgvUnidadMedida.Columns[1].HeaderText = Rec.UnidadMedida;
            dgvUnidadMedida.Columns[2].HeaderText = Rec.Activo;
            dgvUnidadMedida.Columns[3].HeaderText = Rec.Accion;



        }
        //detecta idioma
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
        //aplica idioma a btn dgv
        private void dgvUnidadMedida_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUnidadMedida.Columns[e.ColumnIndex].Name == "Accion")
            {
                // Obtener el valor de la celda
                object value = e.Value;

                if (SeleccionIdioma.i.IdIdioma == 2)
                {
                    // Comprobar el valor y establecer el texto del botón en consecuencia
                    if (value != null && value.ToString() == "accion")
                    {
                        e.Value = "Details";
                    }
                    else
                    {
                        e.Value = "Details";
                    }
                }

            }
        }
    }
}
