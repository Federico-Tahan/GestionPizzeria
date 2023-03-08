using CapaDatos.Datos.Interfaces;
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
            habilitarBtn(true);
            BtnEditar.Enabled = false;
            btnNuevo.Enabled = false;
            txbClasificacion.Text = string.Empty; txbClasificacion.Enabled = true;
            chkActivo.Checked = true; chkActivo.Enabled = true;
            panel1.Visible = true;
            chkActivo.Visible = false;

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            habilitarBtn(false);
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
            txbClasificacion.Enabled = true;
            chkActivo.Enabled = true;
            txbClasificacion.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            habilitarBtn(false);
            btnNuevo.Enabled = true;
            panel1.Visible = false;
            txbClasificacion.Text = string.Empty;
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
                    dgvClasi.Rows.Add(p.IdClasificacion, p.clasificacion, Rec.Si);
                }
                else
                {
                    dgvClasi.Rows.Add(p.IdClasificacion, p.clasificacion,Rec.No);
                }


            }
        }

        private void FormClasificacion_Load(object sender, EventArgs e)
        {
            list = lg.GetClasificacion(0);
            cargarDgv(list);
            DetectarIdioma();
            AplicarIdioma();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            this.Close();

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txbClasificacion.Text != string.Empty)
            {
               
                AbstraerClasificacion();
                if (cla.IdClasificacion != 1 && cla.IdClasificacion != 2)
                {
                    if (cla.IdClasificacion != 0)
                    {
                        if (lg.ModificacionClasificacion(cla,LogIn.u))
                        {
                            MessageBox.Show(Rec.ModClasiConExtio);
                        }
                        else
                        {
                            MessageBox.Show(Rec.ModClasiSinExti);

                        }
                        cla = new Clasificacion();
                        panel1.Visible = false;
                        habilitarBtn(false);
                        btnNuevo.Enabled = true;
                        list = lg.GetClasificacion(0);
                        cargarDgv(list);
                    }
                    else
                    {
                        if (lg.AltaClasificacion(cla, LogIn.u))
                        {
                            MessageBox.Show(Rec.AltaClasiExito);
                        }
                        else
                        {
                            MessageBox.Show(Rec.AltaClasiSinExito);

                        }
                        cla = new Clasificacion();
                        panel1.Visible = false;
                        habilitarBtn(false);
                        btnNuevo.Enabled = true;
                        list = lg.GetClasificacion(0);
                        cargarDgv(list);
                    }
                }
                else
                {
                    MessageBox.Show(Rec.MessageNoModProdFinal,Rec.CapError,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    cla = new Clasificacion();
                    panel1.Visible = false;
                    habilitarBtn(false);
                    btnNuevo.Enabled = true;
                    list = lg.GetClasificacion(0);
                    cargarDgv(list);
                }
                

            }
            else
            {
                MessageBox.Show(Rec.MessageDebeCargarClasificacion);
            }
        }

        private void dgvClasi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cla = new Clasificacion();
            if (dgvClasi.Columns[e.ColumnIndex].Name == "Accion")
            {

                CargarClasificacion(Convert.ToInt32(dgvClasi.CurrentRow.Cells[0].Value));
                txbClasificacion.Text = cla.clasificacion;
                if (cla.BajaLogica == 0)
                {
                    chkActivo.Checked = true;
                }
                else
                {
                    chkActivo.Checked = false;
                }
                chkActivo.Visible = true;
                panel1.Visible = true;
                txbClasificacion.Enabled = false;
                chkActivo.Enabled = false;
                habilitarBtn(false);
                BtnEditar.Enabled = true;
            }
        }

        private void CargarClasificacion(int c)
        {
            foreach (Clasificacion u in list)
            {
                if (u.IdClasificacion == c)
                {
                    cla = u;
                    break;
                }
            }
        }

        private void picbajar_Click(object sender, EventArgs e)
        {
            txbClasificacion.Text = string.Empty;
            panel1.Visible = false;
            habilitarBtn(false);
            btnNuevo.Enabled = true;
        }

        private void AbstraerClasificacion()
        {
            cla.clasificacion = txbClasificacion.Text;
            if (chkActivo.Checked)
            {
                cla.BajaLogica = 0;
            }
            else
            {
                cla.BajaLogica = 1;
            }
        }

        private void RbtActivo_CheckedChanged(object sender, EventArgs e)
        {
            list = lg.GetClasificacion(0);
            cargarDgv(list);
        }

        private void RbtNoActivo_CheckedChanged(object sender, EventArgs e)
        {
            list = lg.GetClasificacion(1);
            cargarDgv(list);
        }

        private void rbtTodos_CheckedChanged(object sender, EventArgs e)
        {
            list = lg.GetClasificacion(2);
            cargarDgv(list);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txbBusqeuda.Text != "")
            {
                try
                {
                    Convert.ToInt32(txbBusqeuda.Text);
                    List<DataGridViewRow> temp = new List<DataGridViewRow>();

                    foreach (DataGridViewRow row in dgvClasi.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["CodigoClasificacion"].Value) != Convert.ToInt32(txbBusqeuda.Text))
                        {
                            temp.Add(row);
                        }

                    }

                    foreach (DataGridViewRow row in temp)
                    {

                        dgvClasi.Rows.Remove(row);

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
            lbclasificacion.Text = Rec.Clasificacion;
            lbclasi.Text = Rec.Clasificacion;
            chkActivo.Text = Rec.Activo;
            btnNuevo.Text = Rec.Nuevo;
            BtnEditar.Text = Rec.Editar;
            BtnCancelar.Text = Rec.Cancelar;
            BtnGuardar.Text = Rec.Guardar;
            BtnBuscar.Text = Rec.Buscar;
            RbtActivo.Text = Rec.Activo;
            RbtNoActivo.Text = Rec.noactivo;
            rbtTodos.Text = Rec.Todos;
            lbcodclasi.Text = Rec.CodigoClasificacion;
            dgvClasi.Columns[0].HeaderText = Rec.CodigoClasificacion;
            dgvClasi.Columns[1].HeaderText = Rec.Clasificacion;
            dgvClasi.Columns[2].HeaderText = Rec.Activo;
            dgvClasi.Columns[3].HeaderText = Rec.Accion;

        }

        private void Minimizar_Click(object sender, EventArgs e)
        {

        }

        private void dgvClasi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvClasi.Columns[e.ColumnIndex].Name == "Accion")
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
