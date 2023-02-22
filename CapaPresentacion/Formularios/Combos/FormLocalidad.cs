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

namespace CapaPresentacion.Formularios.Combos
{
    public partial class FormLocalidad : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        ing_TipoProdClasiUnidadMed lg = new ng_TipoProdClasiUnidadMed();

        List<Localidad> list = new List<Localidad>();
        Localidad cla = new Localidad();
        public FormLocalidad()
        {
            InitializeComponent();
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (txbClasificacion.Text != string.Empty)
            {

                AbstraerLocalidad();

                    if (cla.idLocalidad != 0)
                    {
                        if (lg.ModLocalidad(cla))
                        {
                            MessageBox.Show(Rec.ModLocalildadExito);
                        }
                        else
                        {
                            MessageBox.Show(Rec.ModLocalidadSinExito);

                        }
                        cla = new Localidad();
                        panel1.Visible = false;
                        habilitarBtn(false);
                        btnNuevo.Enabled = true;
                        list = lg.GetLocalidad(0);
                        cargarDgv(list);
                    }
                    else
                    {
                        if (lg.AltaLocalidad(cla))
                        {
                            MessageBox.Show(Rec.AltaLocalidadExito);
                        }
                        else
                        {
                            MessageBox.Show(Rec.AltaLocalidadSinExito);

                        }
                            cla = new Localidad();
                            panel1.Visible = false;
                            habilitarBtn(false);
                            btnNuevo.Enabled = true;
                            list = lg.GetLocalidad(0);
                            cargarDgv(list);
                    }
            }
            else
            {
                MessageBox.Show(Rec.MessageSedebeCargarLoc);
            }
        }

        private void cargarDgv(List<Localidad> list)
        {
            dgvClasi.Rows.Clear();

            foreach (Localidad p in list)
            {
                if (p.BajaLogica == 0)
                {
                    dgvClasi.Rows.Add(p.idLocalidad, p.NLocalidad, "Si");
                }
                else
                {
                    dgvClasi.Rows.Add(p.idLocalidad, p.NLocalidad, "No");
                }


            }
        }

        private void AbstraerLocalidad()
        {
            cla.NLocalidad = txbClasificacion.Text;
            if (chkActivo.Checked)
            {
                cla.BajaLogica = 0;
            }
            else
            {
                cla.BajaLogica = 1;
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {   
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {

        }

        private void FormLocalidad_Load(object sender, EventArgs e)
        {
            list = lg.GetLocalidad(0);
            cargarDgv(list);
            DetectarIdioma();
            AplicarIdioma();
        }

        private void picbajar_Click(object sender, EventArgs e)
        {
            txbClasificacion.Text = string.Empty;
            panel1.Visible = false;
            habilitarBtn(false);
            btnNuevo.Enabled = true;
        }

        private void dgvClasi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cla = new Localidad();
            if (dgvClasi.Columns[e.ColumnIndex].Name == "Accion")
            {

                CargarLocalidad(Convert.ToInt32(dgvClasi.CurrentRow.Cells[0].Value));
                txbClasificacion.Text = cla.NLocalidad;
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

        private void CargarLocalidad(int c)
        {
            foreach (Localidad u in list)
            {
                if (u.idLocalidad == c)
                {
                    cla = u;
                    break;
                }
            }
        }

        private void RbtActivo_CheckedChanged(object sender, EventArgs e)
        {
            list = lg.GetLocalidad(0);
            cargarDgv(list);
        }

        private void RbtNoActivo_CheckedChanged(object sender, EventArgs e)
        {
            list = lg.GetLocalidad(1);
            cargarDgv(list);
        }

        private void rbtTodos_CheckedChanged(object sender, EventArgs e)
        {
            list = lg.GetLocalidad(2);
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
                        if (Convert.ToInt32(row.Cells["Codigolocalidad"].Value) != Convert.ToInt32(txbBusqeuda.Text))
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
            lbclasificacion.Text = Rec.localidad;
            lbclasi.Text = Rec.localidad;
            chkActivo.Text = Rec.Activo;
            btnNuevo.Text = Rec.Nuevo;
            BtnEditar.Text = Rec.Editar;
            BtnCancelar.Text = Rec.Cancelar;
            BtnGuardar.Text = Rec.Guardar;
            BtnBuscar.Text = Rec.Buscar;
            RbtActivo.Text = Rec.Activo;
            RbtNoActivo.Text = Rec.noactivo;
            rbtTodos.Text = Rec.Todos;
            lbcodclasi.Text = Rec.codigoLocalidad;
            dgvClasi.Columns[0].HeaderText = Rec.CodigoClasificacion;
            dgvClasi.Columns[1].HeaderText = Rec.localidad;
            dgvClasi.Columns[2].HeaderText = Rec.Activo;
            dgvClasi.Columns[3].HeaderText = Rec.Accion;

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
