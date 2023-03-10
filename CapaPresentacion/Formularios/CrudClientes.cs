using CapaCapaNegocio.Interfaces;
using CapaDatos.Datos;
using CapaDatos.Dominio;
using CapaNegocio.Implementacion;
using CapaNegocio.Interfaces;
using CapaPresentacion.Formularios.Combos;
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
        int edit = 0;
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

        //trae la lista de los socios, carga cbo y aplica idioma
        private void CrudClubSocial_Load(object sender, EventArgs e)
        {
            lClientes = lg.TraerClientes();
            cargarDgv(lClientes);
            cargar_cboLocalidad(cboloclaidad,"NLocalidad", "idLocalidad");
            DetectarIdioma();
            AplicarIdioma();

        }
        //limpia campos, abre panel de formulario y activa y desactiva botones
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
            edit = 0;
        }
        //baja panel, activa y desactiva botones y limpia datos
        private void picbajar_Click(object sender, EventArgs e)
        {
            TxbDni.Text = string.Empty;
            BtnBorrar.Enabled = false;
            Limpiar();
            pnlCrud.Visible = false;
            Botones(false);
            btnNuevo.Enabled = true;
            edit = 0;

        }

        private void pnlCrud_Paint(object sender, PaintEventArgs e)
        {

        }
        //carga el cliente seleccionado al panel de formulario para ver el detalle
        private void Click_Acciones(object sender, DataGridViewCellEventArgs e)
        {
            cliente = new Cliente();
            s = new Socio();
            cliente.socio = s;
            cliente.TipoCliente = tp;
            if (dgvCliente.Columns[e.ColumnIndex].Name == "Acciones" && dgvCliente.Rows.Count != 0)
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
                if (LogIn.u.Rol.Id_Rol == 1 || LogIn.u.Rol.Id_Rol == 3 || LogIn.u.Rol.Id_Rol == 5 || LogIn.u.Rol.Id_Rol == 6)
                {
                    BtnBorrar.Enabled = true;
                }
                else
                {
                    BtnBorrar.Enabled = false;
                }
                habilitar(false);
                picLimpiar.Enabled = false;
                Botones(false);
                BtnEditar.Enabled = true;
                pnlCrud.Visible = true;
            }
        }
        //carga panel cliente
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
            if (cliente.socio.Baja_logica == 0)
            {
                TxbDni.Visible = true;
                TxbEmail.Visible = true;
                TxbDni.Text = cliente.socio.DNI.ToString();
                TxbEmail.Text = cliente.socio.Email;
            }
        }
        //acvtiva botones o desactiva
        private void Botones(bool a)
        {
            BtnCancelar.Enabled = a;
            btnNuevo.Enabled = a;
            BtnEditar.Enabled = a;
            BtnGuardar.Enabled = a;
        }
        //habilita o deshabilita campos
        private void habilitar(bool a)
        {
            txbNombre.Enabled = a;
            TxbApellido.Enabled = a;
            TxbDirec.Enabled = a;
            texboxnumero.Enabled = a;
            TxbDni.Enabled = a;
            TxbDni.Enabled = a;
            TxbEmail.Enabled = a;
            nupPiso.Enabled = a;
            nupaltura.Enabled = a;
            txbDepto.Enabled = a;
            cboloclaidad.Enabled = a;
        }

        //habilita y desabilita botones y campso para realizra correcta eidicion
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Botones(false);
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
            habilitar(true);
            BtnBorrar.Enabled = false;
            edit = 1;

        }
        //cancela la edicion y limpia datos 
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxbDni.Text = string.Empty;
            Limpiar();
            pnlCrud.Visible = false;
            Botones(false);
            btnNuevo.Enabled = true;
            BtnBorrar.Enabled = false;
            edit = 0;


        }
        //metodo para limpiar campos
        private void Limpiar()
        {
            if (TxbDni.Enabled)
            {
                txbNombre.Text = string.Empty;
                TxbApellido.Text = string.Empty;
                TxbDni.Text = string.Empty;
                TxbEmail.Text = string.Empty;
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
                TxbDirec.Text = string.Empty;
                texboxnumero.Text = string.Empty;
                txbDepto.Text = string.Empty;
                nupaltura.Value = 0;
                nupPiso.Value = 0;
                cboloclaidad.SelectedIndex = -1;
            }

        }
        //boton limpiar
        private void picLimpar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }
        //cargar dgv con lista de clientes
        private void cargarDgv(List<Cliente> lClientes)
        {
            dgvCliente.Rows.Clear();

            foreach (Cliente c in lClientes)
            {
                if (c.socio.Baja_logica == 1 || c.socio.Baja_logica == 2)
                {
                    dgvCliente.Rows.Add(c.IdCliente, " ",c.Nombre + " "+ c.Apellido," ",c.Direccion, c.Altura, c.Piso,c.Departamento,c.Telefono,Rec.No);

                }else if (c.socio.Baja_logica == 0)
                {
                    dgvCliente.Rows.Add(c.IdCliente, c.socio.DNI, c.Nombre + " " + c.Apellido, c.socio.FechaAdhesion.ToShortDateString(), c.Direccion, c.Altura, c.Piso, c.Departamento, c.Telefono, Rec.Si);

                }

            }
        }
        //opcion no ACTIVA, se usaba para cargar socios no socios y todos
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

        //aplica filtros de busqueda segun se encesite
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

        //valida campos requeridos
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
            else if (cboloclaidad.SelectedIndex == -1)
            {
                MessageBox.Show(Rec.MesssageValidacionLoc, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;

            }

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
                if (TxbDni.Text.Length > 8)
                {
                    MessageBox.Show(Rec.validacionDNI, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (TxbEmail.Text.Length > 50)
                {
                    MessageBox.Show(Rec.validacionLengEmail, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            if (txbNombre.Text.Length > 30)
            {
                MessageBox.Show(Rec.ValidacionLengNombre, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TxbApellido.Text.Length > 30)
            {
                MessageBox.Show(Rec.ValidacionLengApellido, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            return true;
        }
        //opcion no habiltiada, dependiendo tipo de cliente cargaba ciertos datos 

        private void CboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //valida que los datos esten biem, si se quiere modificar o insertar y si DNI esta en uso o no, luego de hacer un correcto guardado se enviara el email con terminos y condiciones
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



                if (edit == 1)
                {
                    if (lg.BuscarClienteSocioDni(cli))
                    {
                        if (cliente.socio.DNI == cli.socio.DNI)
                        {
                            if (lg.ModificacionCliente(cli, LogIn.u))
                            {
                                if (cli.socio.Email != "" && cli.socio.Email != cliente.socio.Email)
                                {


                                    if (lg.EmailSender(cli))
                                    {
                                        MessageBox.Show(Rec.MessageEmailEnviado, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                BtnBorrar.Enabled = false;
                                edit = 0;
                                cliente = new Cliente();
                                s = new Socio();
                                cliente.socio = s;
                            }
                        }
                        else
                        {
                            MessageBox.Show(Rec.MessageboxDniyaregistrado, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        if (lg.ModificacionCliente(cli, LogIn.u))
                        {
                            if (cli.socio.Email != "" && cli.socio.Email != cliente.socio.Email)
                            {


                                if (lg.EmailSender(cli))
                                {
                                    MessageBox.Show(Rec.MessageEmailEnviado, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            BtnBorrar.Enabled = false;
                            edit = 0;
                            cliente = new Cliente();
                            s = new Socio();
                            cliente.socio = s;
                        }
                    }
                }
                else
                {
                    if (lg.BuscarClienteSocioDni(cli))
                    {
                        MessageBox.Show(Rec.MessageboxDniyaregistrado, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        if (lg.AltaClienteSocio(cli, LogIn.u))
                        {

                            MessageBox.Show(Rec.MessageSocioDadoAlta);
                            if (lg.EmailSender(cli))
                            {
                                MessageBox.Show(Rec.MessageEmailEnviado, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(Rec.MessageEmailNoEnviado, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            lClientes = lg.TraerClientes();
                            cargarDgv(lClientes);
                            Botones(false);
                            Limpiar();
                            btnNuevo.Enabled = true;
                            BtnBorrar.Enabled = false;
                            pnlCrud.Visible = false;
                            edit = 0;
                            cliente = new Cliente();
                            s = new Socio();
                            cliente.socio = s;

                        }
                    }
                }
            }
        }
        //abstrae el objeto cliente
        private void AbstraerCliente(Cliente cli)
        {
            Localidad l = new Localidad();
            cli.Nombre = txbNombre.Text;
            cli.Apellido= TxbApellido.Text;
            cli.Direccion= TxbDirec.Text;
            cli.TipoCliente.Id_TipoCliente = 1;

                cli.socio.DNI = Convert.ToInt64(TxbDni.Text);
                cli.socio.Email = TxbEmail.Text;

            cli.Altura = Convert.ToInt32(nupaltura.Value);
            cli.Piso = Convert.ToInt32(nupPiso.Value);
            cli.Departamento = txbDepto.Text;
            l.idLocalidad= Convert.ToInt32(cboloclaidad.SelectedValue);
            cli.locali = l;
            cli.Telefono = texboxnumero.Text;
        }

        //carga cliente de la lsita a el objeto
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
        //carga cbo localidad

        private void cargar_cboLocalidad(ComboBox cbo, string display, string value)
        {
            cbo.DataSource = lcbo.Localidad();
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;
        }
        //carga cbo tipo cliente, NO HABILITADO
        private void cargar_cboTipOclIENTE(ComboBox cbo, string display, string value)
        {
            cbo.DataSource = lcbo.TipoClientes();
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;
        }

        //verifica que el campo se ingrese un emai
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
        //aplica texto segun diioma
        public void AplicarIdioma()
        {
            lbClientes.Text = Rec.Clientes;
            btnNuevo.Text = Rec.Nuevo;
            BtnEditar.Text = Rec.Editar;
            BtnCancelar.Text = Rec.Cancelar;
            BtnGuardar.Text = Rec.Guardar;
            lbNombre.Text = Rec.Nombre;
            RbtDni.Text = Rec.DNI;
            RbtNombre.Text = Rec.Nombre;
            BtnBuscar.Text = Rec.Buscar;
            lbApellido.Text = Rec.Apellido;
            TxbDireccion.Text = Rec.Calle;
            TxbTelefono.Text = Rec.Telefono;
            lbdni.Text = Rec.DNI;
            lbEmail.Text = Rec.Email;
            btnLocalidad.Text = Rec.localidad;
            lbAltura.Text = Rec.Altura;
            lbpiso.Text = Rec.Piso;
            lbDepartamento.Text = Rec.Departamento;
            lblocalidad.Text = Rec.localidad;
            BtnBorrar.Text = Rec.Borrar;





            dgvCliente.Columns[0].HeaderText = Rec.CodigoCliente;
            dgvCliente.Columns[1].HeaderText = Rec.DNI;
            dgvCliente.Columns[2].HeaderText = Rec.NombreCompleto;
            dgvCliente.Columns[3].HeaderText = Rec.FechaAdhesion;
            dgvCliente.Columns[4].HeaderText = Rec.Calle;
            dgvCliente.Columns[5].HeaderText = Rec.Altura;
            dgvCliente.Columns[6].HeaderText = Rec.Departamento;
            dgvCliente.Columns[7].HeaderText = Rec.Piso;
            dgvCliente.Columns[8].HeaderText = Rec.Telefono;
            dgvCliente.Columns[9].HeaderText = Rec.Detalle;

        }
        //reinicia filtros de busqueda
        private void picreset_Click(object sender, EventArgs e)
        {
            lClientes = lg.TraerClientes();
            cargarDgv(lClientes);

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
        //NO HABILITADO
        private void chkDepa_CheckedChanged(object sender, EventArgs e)
        {
            lbpiso.Visible = !lbpiso.Visible;
            nupPiso.Visible = !lbpiso.Visible;

        }
        //btn localidad, permite cargar una nueva si no esta cargada
        private void btnLocalidad_Click(object sender, EventArgs e)
        {
            FormLocalidad fm = new FormLocalidad(); 
            fm.ShowDialog();
            if (fm.DialogResult == DialogResult.OK)
            {
                cargar_cboLocalidad(cboloclaidad, "NLocalidad", "idLocalidad");

            }
        }
        //dgv cliente cambia el nombre del boton al idioma seleccionado
        private void dgvCliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCliente.Columns[e.ColumnIndex].Name == "Acciones")
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
        //borra el cliente
        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Rec.MessageDarBajaCliente) == DialogResult.Yes)
            {
                if (lg.EliminarCliente(cliente.IdCliente, LogIn.u))
                {
                    MessageBox.Show(Rec.deshaderirextio);
                    lClientes = lg.TraerClientes();
                    cargarDgv(lClientes);
                    Botones(false);
                    Limpiar();
                    btnNuevo.Enabled = true;
                    pnlCrud.Visible = false;
                    cliente = new Cliente();
                    s = new Socio();
                    cliente.socio = s;
                    BtnBorrar.Enabled = false;

                }
                else
                {
                    MessageBox.Show(Rec.deshaderirnoexti);

                }
            }

        }
        //verifica que se cargue texto
        private void txbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar < 0 || e.KeyChar > 127)
            {
                e.Handled = true;
            }
        }
        //verifica que se cargue texto

        private void TxbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar < 0 || e.KeyChar > 127)
            {
                e.Handled = true;
            }
        }
        //verifica que se cargue texto

        private void TxbDirec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar < 0 || e.KeyChar > 127)
            {
                e.Handled = true;
            }
        }
        //verifica que se cargue numeor

        private void texboxnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //verifica que se cargue numero

        private void TxbDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
