using CapaCapaNegocio.Interfaces;
using CapaDatos.Datos;
using CapaDatos.Dominio;
using CapaNegocio.Implementacion;
using CapaNegocio.Interfaces;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
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
            Limpiar();
            pnlCrud.Visible = false;
            Botones(true);

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
            }
            else
            {
                TxbEmail.Text = string.Empty;
                CboTipoCliente.SelectedIndex = -1;
                TxbDirec.Text = string.Empty;
                texboxnumero.Text = string.Empty;
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
                if (c.TipoCliente.Id_TipoCliente == 2)
                {
                    dgvCliente.Rows.Add(c.IdCliente, " ",c.Nombre + " "+ c.Apellido," ",c.Direccion, "No");

                }else if (c.TipoCliente.Id_TipoCliente == 1)
                {
                    dgvCliente.Rows.Add(c.IdCliente, c.socio.DNI, c.Nombre + " " + c.Apellido, c.socio.FechaAdhesion, c.Direccion, "Si");

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
                    MessageBox.Show("Debe cargar un DNI para realizar la busqueda");
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
                    MessageBox.Show("Debe cargar un DNI para realizar la busqueda");
                }
            }
            
            
        }


        private bool Validacion()
        {
            if (txbNombre.Text == "")
            {
                MessageBox.Show("Se debe agregar el nombre del cliente");
                return false;
            }else if (TxbApellido.Text == "")
            {
                MessageBox.Show("Se debe agregar el apellido del cliente");

                return false;

            }
            else if (CboTipoCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe elegir el tipo de cliente");

                return false;

            }
            else if (texboxnumero.Text == "")
            {
                MessageBox.Show("Se debe agregar el Telefono del cliente");

                return false;

            }
            else if (TxbDireccion.Text == "")
            {
                MessageBox.Show("Se debe agregar la direccion del cliente");

                return false;

            }

            if (Convert.ToInt32(CboTipoCliente.SelectedValue) == 1)
            {
                if (TxbEmail.Text == "" || EsEmail(TxbEmail.Text) is false)
                {
                    MessageBox.Show("Se debe cargar el email del cliente");

                    return false;

                }
                else if (TxbDni.Text == "")
                {
                    MessageBox.Show("Se debe cargar el dni del cliente");

                    return false;

                }

                try
                {
                    Convert.ToInt64(TxbDni.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar un numero de DNI");
                    return false;

                }

            }

            try
            {
                Convert.ToInt64(texboxnumero.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un numero de Telefono");

                return false;

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
                        MessageBox.Show("El DNI ya se encuentra registado.");
                    }
                    else if (lg.ModificacionCliente(cli)) //Modifica los datos del socio, ya que accedio al apartado Editar.
                    {
                        MessageBox.Show("Cliente Modificado con Exito.");
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
                        if (lg.AltaSocio(cli))
                        {
                            MessageBox.Show("Socio dado de alta con Exito.");

                        }
                    }else if (Convert.ToInt32(CboTipoCliente.SelectedValue) == 2)
                    {
                        if (lg.ModificacionCliente(cli)) 
                        {
                            MessageBox.Show("Cliente Modificado con Exito.");
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
                        if (lg.AltaClienteSocio(cli))
                        {
                            MessageBox.Show("Socio dado de alta con Exito.");
                        }
                    }
                    else if (Convert.ToInt32(CboTipoCliente.SelectedValue) == 2)
                    {
                        if (lg.AltaClienteNosocio(cli))
                        {
                            MessageBox.Show("Cliente dado de alta con Exito.");
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
            cli.Nombre = txbNombre.Text;
            cli.Apellido= TxbApellido.Text;
            cli.Direccion= TxbDirec.Text;
            cli.Telefono = Convert.ToInt64(texboxnumero.Text);
            cli.TipoCliente.Id_TipoCliente = Convert.ToInt32(CboTipoCliente.SelectedValue);
            if (Convert.ToInt32(CboTipoCliente.SelectedValue) == 1)
            {
                cli.socio.DNI = Convert.ToInt64(TxbDni.Text);
                cli.socio.Email = TxbEmail.Text;
            }

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
    }
}
