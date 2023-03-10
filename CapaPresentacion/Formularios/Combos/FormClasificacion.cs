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
        //permite que se pueda arrastrar el formulario

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

        //permite que se pueda arrastrar el formulario
        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Boton nuevo habilita los botones y deshabilita los texbox y botnoes necesarios
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
        //Boton Editar habilita los botones y deshabilita los texbox y botnoes necesarios

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            habilitarBtn(false);
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
            txbClasificacion.Enabled = true;
            chkActivo.Enabled = true;
            txbClasificacion.Enabled = true;
        }
        //Boton cancelar deshabilita los botnoes necesariosy cierrra el panel del formulario

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            habilitarBtn(false);
            btnNuevo.Enabled = true;
            panel1.Visible = false;
            txbClasificacion.Text = string.Empty;
        }
        //habilita o deshabilita los botones
        private void habilitarBtn(bool a)
        {
            btnNuevo.Enabled = a;
            BtnCancelar.Enabled = a;
            BtnCancelar.Enabled = a;
            BtnGuardar.Enabled = a;
            BtnEditar.Enabled = a;
        }
        //carga la datagrid view con los datos de la lista
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

        //load se trae la lista, carga la dgv y se cambia el idioma dependiendo el seleccionado
        private void FormClasificacion_Load(object sender, EventArgs e)
        {
            list = lg.GetClasificacion(0);
            cargarDgv(list);
            DetectarIdioma();
            AplicarIdioma();
        }

        //cerrar formulario
        private void Salir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            this.Close();

        }

        //guardar verifica los datos, ve que no se este modificando los primros dos clasificaciones que son improtantes y chekea si hay que actualizar o generar un nueva clasificacion
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

        //al hacer click en boton de detalles se cargara los datos de la clasificacion seleccioanda y se abrira el panel del formulario con los datos de esa clasi cargados, se activaran los botones
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

        //carga la clasificacion seleccionada a un objeto cla
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

        //boton de bajar, funciona igual qque el cancelar
        private void picbajar_Click(object sender, EventArgs e)
        {
            txbClasificacion.Text = string.Empty;
            panel1.Visible = false;
            habilitarBtn(false);
            btnNuevo.Enabled = true;
        }
        //abstrae los datos del objeto
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

        //rbt si presiona activo
        private void RbtActivo_CheckedChanged(object sender, EventArgs e)
        {
            list = lg.GetClasificacion(0);
            cargarDgv(list);
        }
        //rbt si presiona No activo

        private void RbtNoActivo_CheckedChanged(object sender, EventArgs e)
        {
            list = lg.GetClasificacion(1);
            cargarDgv(list);
        }
        //rbt si presiona Todos

        private void rbtTodos_CheckedChanged(object sender, EventArgs e)
        {
            list = lg.GetClasificacion(2);
            cargarDgv(list);
        }
        //Filtro, corrobora la opcion ingresada y que cumpla con el tipo de dato 
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

        //detecta el idioma seleccionado y lo cambia
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

        //asignacion de texto a los controles
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
        //cambia el texto al idioma seleccionado del boton dgv
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
