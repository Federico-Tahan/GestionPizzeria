using CapaCapaNegocio.Interfaces;
using CapaDatos.Datos;
using CapaDatos.Dominio;
using CapaNegocio.Implementacion;
using CapaNegocio.Interfaces;
using CapaPresentacion.RecursoIdioma;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class CrudClientes : Form
    {
        ing_Cliente lg = new ng_Cliente();
        ing_Cbos lcbo = new ng_Cbos();
        Cliente cliente = new Cliente();
        Tipo_Cliente tp = new Tipo_Cliente();
        Socio s = new Socio();

        List<Cliente> lClientes = new List<Cliente>();
        public CrudClientes()
        {
            InitializeComponent();
            cliente.socio = s;
        }

        private void CrudClubSocial_Load(object sender, EventArgs e)
        {
            lClientes = lg.TraerClientes();
            cargarDgv(lClientes);
            cargar_cboTipOclIENTE(CboTipoCliente, "TipoCliente", "Id_TipoCliente");
            cargar_cboLocalidad(cboloclaidad,"NLocalidad", "idLocalidad");
            DetectarIdioma();
            AplicarIdioma();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cliente = new Cliente();
            s = new Socio();
            TxbDni.Enabled = true;
            Limpiar();
            
            txbNombre.Text = string.Empty;
            TxbApellido.Text = string.Empty;
            pnlCrud.Visible = true;
            Botones(false);
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
            habilitar(true);
        }

        private void picbajar_Click(object sender, EventArgs e)
        {
            TxbDni.Text = string.Empty;

            Limpiar();
            pnlCrud.Visible = false;
            Botones(false);
            btnNuevo.Enabled = true;

        }

        private void pnlCrud_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Click_Acciones(object sender, DataGridViewCellEventArgs e)
        {
            cliente = new Cliente();
            s = new Socio();
            cliente.socio = s;
            cliente.TipoCliente = tp;
            if (dgvCliente.Columns[e.ColumnIndex].Name == "Acciones")
            {
                pnlCrud.Visible = true;
                cliente.IdCliente = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
                CargarCliente(cliente.IdCliente);
                CargarPanelCliente();
                if (cliente.TipoCliente.Id_TipoCliente == 2)
                {
                    TxbDni.Visible = false;
                    TxbEmail.Visible= false;
                }
                habilitar(false);
                picLimpiar.Enabled = false;
                Botones(false);
                BtnEditar.Enabled = true;
                pnlCrud.Visible = true;
            }
        }

        private void CargarPanelCliente()
        {
            txbNombre.Text = cliente.Nombre;
            TxbApellido.Text = cliente.Apellido;
            TxbDirec.Text = cliente.Direccion;
            texboxnumero.Text = cliente.Telefono.ToString();
            txbDepto.Text = cliente.Departamento.ToString();
            nupaltura.Value = cliente.Altura;
            nupPiso.Value = cliente.Piso;
            cboloclaidad.SelectedValue = cliente.locali.idLocalidad;
            CboTipoCliente.SelectedValue = cliente.TipoCliente.Id_TipoCliente;
            if (cliente.socio.Baja_logica == 0)
            {
                TxbDni.Visible = true;
                TxbEmail.Visible = true;
                TxbDni.Text = cliente.socio.DNI.ToString();
                TxbEmail.Text = cliente.socio.Email;
            }
        }

        private void Botones(bool a)
        {
            BtnCancelar.Enabled = a;
            btnNuevo.Enabled = a;
            BtnEditar.Enabled = a;
            BtnGuardar.Enabled = a;
        }
        private void habilitar(bool a)
        {
            txbNombre.Enabled = a;
            TxbApellido.Enabled = a;
            TxbDirec.Enabled = a;
            texboxnumero.Enabled = a;
            TxbDni.Enabled = a;
            CboTipoCliente.Enabled = a;
            TxbDni.Enabled = a;
            TxbEmail.Enabled = a;
            nupPiso.Enabled = a;
            nupaltura.Enabled = a;
            txbDepto.Enabled = a;
            cboloclaidad.Enabled = a;
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Botones(false);
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
            habilitar(true);
            txbNombre.Enabled = false;
            TxbApellido.Enabled = false;
            if (Convert.ToInt32(CboTipoCliente.SelectedValue) == 1)
            {
                TxbDni.Enabled = false;

            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxbDni.Text = string.Empty;
            Limpiar();
            pnlCrud.Visible = false;
            Botones(false);
            btnNuevo.Enabled = true;

        }

        private void Limpiar()
        {
            if (TxbDni.Enabled)
            {
                txbNombre.Text = string.Empty;
                TxbApellido.Text = string.Empty;
                TxbDni.Text = string.Empty;
                TxbEmail.Text = string.Empty;
                CboTipoCliente.SelectedIndex = -1;
                TxbDirec.Text = string.Empty;
                texboxnumero.Text = string.Empty;
                txbDepto.Text = string.Empty;
                nupaltura.Value = 0;
                nupPiso.Value = 0;
                cboloclaidad.SelectedIndex = -1;
            }
            else
            {
                TxbEmail.Text = string.Empty;
                CboTipoCliente.SelectedIndex = -1;
                TxbDirec.Text = string.Empty;
                texboxnumero.Text = string.Empty;
                txbDepto.Text = string.Empty;
                nupaltura.Value = 0;
                nupPiso.Value = 0;
                cboloclaidad.SelectedIndex = -1;
            }

        }

        private void picLimpar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void cargarDgv(List<Cliente> lClientes)
        {
            dgvCliente.Rows.Clear();

            foreach (Cliente c in lClientes)
            {
                if (c.socio.Baja_logica == 1 || c.socio.Baja_logica == 2)
                {
                    dgvCliente.Rows.Add(c.IdCliente, " ",c.Nombre + " "+ c.Apellido," ",c.Direccion, c.Altura,c.Departamento,c.Piso,c.Telefono,"No");

                }else if (c.socio.Baja_logica == 0)
                {
                    dgvCliente.Rows.Add(c.IdCliente, c.socio.DNI, c.Nombre + " " + c.Apellido, c.socio.FechaAdhesion.ToShortDateString(), c.Direccion, c.Altura, c.Departamento, c.Piso, c.Telefono, "Si");

                }

            }
        }

        private void rbtTodos_CheckedChanged(object sender, EventArgs e)
        {
            lClientes = lg.TraerClientes();
            cargarDgv(lClientes);
        }

        private void RbtSocios_CheckedChanged(object sender, EventArgs e)
        {
            lClientes = lg.TraerClientes();
            cargarDgv(lClientes);

                List<DataGridViewRow> temp = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dgvCliente.Rows)
                {
                    if (row.Cells["dni"].Value == " ")
                    {
                        temp.Add(row);
                    }

                }

                foreach (DataGridViewRow row in temp)
                {

                    dgvCliente.Rows.Remove(row);

                }
            }

        private void RbtNoSocios_CheckedChanged(object sender, EventArgs e)
        {
            lClientes = lg.TraerClientes();
            cargarDgv(lClientes);

            List<DataGridViewRow> temp = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in dgvCliente.Rows)
            {
                if (row.Cells["dni"].Value != " ")
                {
                    temp.Add(row);
                }

            }

            foreach (DataGridViewRow row in temp)
            {

                dgvCliente.Rows.Remove(row);

            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            lClientes = lg.TraerClientes();
            cargarDgv(lClientes);
            if (RbtDni.Checked)
            {
                if (txbBusqueda.Text != "")
                {
                    List<DataGridViewRow> temp = new List<DataGridViewRow>();

                    foreach (DataGridViewRow row in dgvCliente.Rows)
                    {
                        try
                        {
                            if (Convert.ToString(row.Cells["dni"].Value) != Convert.ToString(txbBusqueda.Text))
                            {
                                temp.Add(row);
                            }
                        }
                        catch
                        {

                        }


                    }

                    foreach (DataGridViewRow row in temp)
                    {

                        dgvCliente.Rows.Remove(row);

                    }
                }
                else
                {
                    MessageBox.Show(Rec.MessageDebeCargarDNIparabuscar,Rec.CapError,MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                if (txbBusqueda.Text != "")
                {
                    List<DataGridViewRow> temp = new List<DataGridViewRow>();

                    foreach (DataGridViewRow row in dgvCliente.Rows)
                    {
                        try
                        {
                            if (Convert.ToString(row.Cells["NombreCompleto"].Value) != Convert.ToString(txbBusqueda.Text))
                            {
                                temp.Add(row);
                            }
                        }
                        catch
                        {

                        }


                    }

                    foreach (DataGridViewRow row in temp)
                    {

                        dgvCliente.Rows.Remove(row);

                    }
                }
                else
                {
                    MessageBox.Show(Rec.MessageDebeCargarNombreparabuscar, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }


        private bool Validacion()
        {
            if (txbNombre.Text == "")
            {
                MessageBox.Show(Rec.MessageValidacionNombreCli, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }else if (TxbApellido.Text == "")
            {
                MessageBox.Show(Rec.MessageValidacionApellidoCli, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;

            }
            else if (CboTipoCliente.SelectedIndex == -1)
            {
                MessageBox.Show(Rec.MessageValidacionTipoCli, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;

            }
            else if (cboloclaidad.SelectedIndex == -1)
            {
                MessageBox.Show(Rec.MesssageValidacionLoc, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;

            }

            if (Convert.ToInt32(CboTipoCliente.SelectedValue) == 1)
            {
                if (TxbEmail.Text == "" || EsEmail(TxbEmail.Text) is false)
                {
                    MessageBox.Show(Rec.MessageValidacionEmailCli, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;

                }
                else if (TxbDni.Text == "")
                {
                    MessageBox.Show(Rec.MessageValidacionDNIcli, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;

                }

                try
                {
                    Convert.ToInt64(TxbDni.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(Rec.MessageValidacionDNINumeroCli, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }

            }

            return true;
        }

        private void CboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CboTipoCliente.SelectedValue) == 1)
            {
                lbdni.Visible = true;
                lbEmail.Visible = true;
                TxbEmail.Visible = true;
                TxbDni.Visible = true;
                if (cliente.socio.DNI == 0)
                {
                    TxbDni.Text = string.Empty;
                    TxbEmail.Text = string.Empty;
                    TxbDni.Enabled = true;

                }
                else
                {
                    TxbDni.Text = cliente.socio.DNI.ToString();
                    TxbEmail.Text = cliente.socio.Email;
                    TxbDni.Enabled = false;
                }

            }
            else
            {
                lbdni.Visible = false;
                lbEmail.Visible = false;
                TxbEmail.Visible = false;
                TxbDni.Visible = false;
                if (cliente.socio.DNI == 0)
                {
                    TxbDni.Text = string.Empty;
                    TxbEmail.Text = string.Empty;
                }
                else
                {
                    TxbDni.Text = cliente.socio.DNI.ToString();
                    TxbEmail.Text = cliente.socio.Email;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                Cliente cli = new Cliente();
                Socio soc = new Socio();
                Tipo_Cliente tpc = new Tipo_Cliente();
                cli.socio = soc;
                cli.TipoCliente = tpc;
                AbstraerCliente(cli);
                cli.IdCliente = cliente.IdCliente;


                if (lg.BuscarClienteSocioDni(cli) )
                {
                    if (txbNombre.Enabled is true && cli.socio.DNI != 0) //Verificar que no se ingrese con un DNI registrado
                    {
                        MessageBox.Show(Rec.MessageboxDniyaregistrado, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (lg.ModificacionCliente(cli,LogIn.u)) //Modifica los datos del socio, ya que accedio al apartado Editar.
                    {
                        if (cli.socio.Email != "" && cli.socio.Email != cliente.socio.Email)
                        {


                            if (lg.EmailSender(cli))
                            {
                                MessageBox.Show(Rec.MessageEmailEnviado,"", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(Rec.MessageEmailNoEnviado, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                        MessageBox.Show(Rec.MessageClienteModificado);
                        lClientes = lg.TraerClientes();
                        cargarDgv(lClientes);
                        Botones(false);
                        Limpiar();
                        btnNuevo.Enabled = true;
                        pnlCrud.Visible = false;
                        rbtTodos.Checked = true;
                    }
                }
                else if (lg.BuscarCliente(cliente))
                {
                    if (Convert.ToInt32(CboTipoCliente.SelectedValue) == 1)
                    {
                        if (lg.AltaSocio(cli, LogIn.u))
                        {
                            if (cli.socio.Email != "")
                            {

                            
                            if (lg.EmailSender(cli))
                            {
                                    MessageBox.Show(Rec.MessageEmailEnviado, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                            {
                                    MessageBox.Show(Rec.MessageEmailNoEnviado, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                                MessageBox.Show(Rec.MessageSocioDadoAlta);
                            }
                        }
                    }else if (Convert.ToInt32(CboTipoCliente.SelectedValue) == 2)
                    {
                        if (lg.ModificacionCliente(cli, LogIn.u)) 
                        {
                            MessageBox.Show(Rec.MessageClienteModificado);
                        }
                    }
                    lClientes = lg.TraerClientes();
                    cargarDgv(lClientes);
                    Botones(false);
                    Limpiar();
                    btnNuevo.Enabled = true;
                    pnlCrud.Visible = false;
                    rbtTodos.Checked = true;
                }
                else
                {
                    if (Convert.ToInt32(CboTipoCliente.SelectedValue) == 1)
                    {
                        if (lg.AltaClienteSocio(cli, LogIn.u))
                        {

                            MessageBox.Show(Rec.MessageSocioDadoAlta);
                            if (lg.EmailSender(cli))
                            {
                                MessageBox.Show(Rec.MessageEmailEnviado, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(Rec.MessageEmailNoEnviado, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                    else if (Convert.ToInt32(CboTipoCliente.SelectedValue) == 2)
                    {
                        if (lg.AltaClienteNosocio(cli, LogIn.u))
                        {
                            MessageBox.Show(Rec.MessageClienteDadoAlta);
                        }
                    }
                    lClientes = lg.TraerClientes();
                    cargarDgv(lClientes);
                    Botones(false);
                    Limpiar();
                    btnNuevo.Enabled = true;
                    pnlCrud.Visible = false;
                }
                cliente = new Cliente();
                s = new Socio();
                cliente.socio = s;
            }
        }

        private void AbstraerCliente(Cliente cli)
        {
            Localidad l = new Localidad();
            cli.Nombre = txbNombre.Text;
            cli.Apellido= TxbApellido.Text;
            cli.Direccion= TxbDirec.Text;
            cli.TipoCliente.Id_TipoCliente = Convert.ToInt32(CboTipoCliente.SelectedValue);
            if (Convert.ToInt32(CboTipoCliente.SelectedValue) == 1)
            {
                cli.socio.DNI = Convert.ToInt64(TxbDni.Text);
                cli.socio.Email = TxbEmail.Text;
            }
            cli.Altura = Convert.ToInt32(nupaltura.Value);
            cli.Piso = Convert.ToInt32(nupPiso.Value);
            cli.Departamento = txbDepto.Text;
            l.idLocalidad= Convert.ToInt32(cboloclaidad.SelectedValue);
            cli.locali = l;
            cli.Telefono = texboxnumero.Text;
        }


        private void CargarCliente(int c)
        {
            foreach (Cliente u in lClientes)
            {
                if (u.IdCliente == c)
                {
                    cliente = u;
                    break;
                }
            }
        }

        private void cargar_cboLocalidad(ComboBox cbo, string display, string value)
        {
            cbo.DataSource = lcbo.Localidad();
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;
        }

        private void cargar_cboTipOclIENTE(ComboBox cbo, string display, string value)
        {
            cbo.DataSource = lcbo.TipoClientes();
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;
        }


        public bool EsEmail(string comprobarEmail)
        {
            string emailFormato;
            emailFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(comprobarEmail, emailFormato))
            {
                if (Regex.Replace(comprobarEmail, emailFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void AplicarIdioma()
        {
            lbClientes.Text = Rec.Clientes;
            btnNuevo.Text = Rec.Nuevo;
            BtnEditar.Text = Rec.Editar;
            BtnCancelar.Text = Rec.Cancelar;
            BtnGuardar.Text = Rec.Guardar;
            lbNombre.Text = Rec.Nombre;
            rbtTodos.Text = Rec.Todos;
            RbtSocios.Text = Rec.Socios;
            RbtNoSocios.Text = Rec.NoSocios;
            RbtDni.Text = Rec.DNI;
            RbtNombre.Text = Rec.Nombre;
            BtnBuscar.Text = Rec.Buscar;
            lbApellido.Text = Rec.Apellido;
            TxbDireccion.Text = Rec.Direccion;
            TxbTelefono.Text = Rec.Telefono;
            lbtipocliente.Text = Rec.TipodeCliente;
            lbdni.Text = Rec.DNI;
            lbEmail.Text = Rec.Email;




            dgvCliente.Columns[0].HeaderText = Rec.CodigoCliente;
            dgvCliente.Columns[1].HeaderText = Rec.DNI;
            dgvCliente.Columns[2].HeaderText = Rec.NombreCompleto;
            dgvCliente.Columns[3].HeaderText = Rec.FechaAdhesion;
            dgvCliente.Columns[4].HeaderText = Rec.Calle;
            dgvCliente.Columns[5].HeaderText = Rec.Altura;
            dgvCliente.Columns[6].HeaderText = Rec.Departamento;
            dgvCliente.Columns[7].HeaderText = Rec.Piso;
            dgvCliente.Columns[8].HeaderText = Rec.Telefono;
            dgvCliente.Columns[9].HeaderText = Rec.Socio;
            dgvCliente.Columns[10].HeaderText = Rec.Detalle;

        }

        private void picreset_Click(object sender, EventArgs e)
        {
            rbtTodos.Checked = true;
            lClientes = lg.TraerClientes();
            cargarDgv(lClientes);

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

        private void chkDepa_CheckedChanged(object sender, EventArgs e)
        {
            lbpiso.Visible = !lbpiso.Visible;
            nupPiso.Visible = !lbpiso.Visible;

        }
    }
}
