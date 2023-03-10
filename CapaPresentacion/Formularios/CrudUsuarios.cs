using CapaDatos.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.Interfaces;
using CapaNegocio.Implementacion;
using CapaDatos.Dominio;
using System.Reflection.Metadata;
using CapaCapaNegocio.Interfaces;
using System.Collections;
using Microsoft.Identity.Client;
using CapaPresentacion.RecursoIdioma;
using CapaPresentacion.Formularios.Combos;

namespace CapaPresentacion.Formularios
{
    public partial class CrudUsuarios : Form
    {
        ing_CrudUsuarios lg = new ng_CrudUsuarios();
        int dgvselectedcondicion = 0;
        ing_Cbos lcbo = new ng_Cbos();
        List<Usuarios> lUsuaris= new List<Usuarios>();  
        Usuarios user = new Usuarios();
        bool chkestado = true;
        bool banderaBaja;
        bool ChKActual;
        public CrudUsuarios()
        {
            InitializeComponent();
        }

        //dependiendo el rol se mostrara todos los datos o solo el dato del usuario que inicio sesion, y tambien se dejará editar todo o solo la contraseña, dependiendo el rol
        //carga los roles a ingles si es necesario y carga cbo de localidades
        private void CrudUsuarios_Load(object sender, EventArgs e)
        {
            lUsuaris.Clear();
            if (LogIn.u.Rol.Id_Rol == 1 || LogIn.u.Rol.Id_Rol == 2 || LogIn.u.Rol.Id_Rol == 3)
            {
                lUsuaris = lg.ObtenerUsuarios(dgvselectedcondicion);
                Cargar_Dgv(lUsuaris);
            }
            else
            {
                lUsuaris = lg.ObtenerUsuario(LogIn.u);

                Cargar_Dgv(lUsuaris);
                btnNuevo.Enabled = false;
                rbtTodos.Enabled = false;
                RbtActivos.Enabled = false;
                RbtEliminados.Enabled = false;
                RbtAlias.Enabled = false;
                RbtDNI.Enabled = false;
                RbtNombre.Enabled = false;
                RbtAlias.Enabled = false;
                RbtCodigo.Enabled = false;
                txbbusqueda.Enabled = false;
                BtnBuscar.Enabled = false;
                picreset.Enabled = false;
                btnLocalidad.Enabled = false;
            }

            if (SeleccionIdioma.i.IdIdioma == 2)
            {
                cargar_cboRoles(CboRoles, "RolesEN", "id_rol");

            }
            else
            {
                cargar_cboRoles(CboRoles, "Rol", "id_rol");

            }
            cargar_cboLocalidad(cboloclaidad, "NLocalidad", "idLocalidad");
            DetectarIdioma();
            AplicarIdioma();
        }


        //habilita o deshabilita btn
        private void Botones(bool a)
        {
            BtnCancelar.Enabled = a;
            btnNuevo.Enabled = a;
            BtnEditar.Enabled = a;
            BtnGuardar.Enabled = a;
        }
        //Carga el formulario todo limpio y con botones activados y desactivados para cargar un nuevo usuario
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            picContraseña.Tag = "activar";
            TxbContraseña.UseSystemPasswordChar = true;
            picContraseña.Image = Properties.Resources.mostrar;
            habilitar(true);
            picLimpiar.Enabled = true;
            picContraseña.Enabled = true;
            pnlCrud.Visible = true;
            Botones(false);
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true; Limpiar();
            user = new Usuarios();
        }

        //habilita txb dependiendo el rol y botones
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (LogIn.u.Rol.Id_Rol == 1 || (LogIn.u.Rol.Id_Rol == 2) || LogIn.u.Rol.Id_Rol == 3)
            {
                habilitar(true);
                picContraseña.Enabled = true;
                picLimpiar.Enabled = true;
                chkActivo.Enabled = true;
                TxbAlias.Enabled = true;
                TxbContraseña.Enabled = true;
                txbDireccion.Enabled = true;
                txbDepto.Enabled = true;
                nupaltura.Enabled = true;
                nupPiso.Enabled = true;
                cboloclaidad.Enabled = true;
                TxbTelefono.Enabled = true;
                CboRoles.Enabled = true;
            }
            else
            {
                picContraseña.Enabled = true;
                TxbContraseña.Enabled = true;

            }

            Botones(false);

            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
        }
        //limpia controles y objeto para cancelar la modificacion
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            pnlCrud.Visible = false;
            Botones(false);
            user = new Usuarios();
            chkestado = true;

            if (LogIn.u.Rol.Id_Rol != 1 && LogIn.u.Rol.Id_Rol != 2)
            {
                lUsuaris = lg.ObtenerUsuario(LogIn.u);

                Cargar_Dgv(lUsuaris);
                btnNuevo.Enabled = false;
                rbtTodos.Enabled = false;
                RbtActivos.Enabled = false;
                RbtEliminados.Enabled = false;
                RbtAlias.Enabled = false;
                RbtDNI.Enabled = false;
                RbtNombre.Enabled = false;
                RbtAlias.Enabled = false;
                RbtCodigo.Enabled = false;
                txbbusqueda.Enabled = false;
                BtnBuscar.Enabled = false;
                picreset.Enabled = false;
            }
            else
            {
                btnNuevo.Enabled = true;
            }
        }

        //limpia campos
        private void Limpiar()
        {
            if (txbNombre.Enabled)
            {
                txbApellido.Text = string.Empty;
                txbCod.Text = string.Empty;
                txbDireccion.Text = string.Empty;
                txbDepto.Text = string.Empty;
                nupaltura.Value = 0; 
                nupPiso.Value = 0;
                cboloclaidad.SelectedIndex = -1;
                txbNombre.Text = string.Empty;
                TxbAlias.Text = string.Empty;
                TxbContraseña.Text = string.Empty;
                TxbDni.Text = string.Empty;
                TxbTelefono.Text = string.Empty;
                CboRoles.SelectedIndex = -1;
                chkActivo.Checked = true;
                dateTimePicker1.Value = DateTime.Now;

            }
            else
            {
                txbDireccion.Text = string.Empty;
                TxbAlias.Text = string.Empty;
                TxbContraseña.Text = string.Empty;
                TxbTelefono.Text = string.Empty;
                CboRoles.SelectedIndex = -1;
                chkActivo.Checked = true;
                txbDepto.Text = string.Empty;
                nupaltura.Value = 0;
                nupPiso.Value = 0;
                cboloclaidad.SelectedIndex = -1;
            }


        }
        //muestra o no la contraseña
        private void picContraseña_Click(object sender, EventArgs e)
        {
            if (picContraseña.Tag != "Desactivar")
            {
                picContraseña.Tag = "Desactivar";
                TxbContraseña.UseSystemPasswordChar = false;
                picContraseña.Image = Properties.Resources.esconder__1_;
            }
            else
            {
                picContraseña.Tag = "activar";
                TxbContraseña.UseSystemPasswordChar = true;
                picContraseña.Image = Properties.Resources.mostrar;
            }
        }
        //funciona igual que el btn cancelar
        private void picBajar_Click(object sender, EventArgs e)
        {
            Limpiar();
            pnlCrud.Visible = false;
            Botones(false);
            user = new Usuarios();
            chkestado = true;

            btnNuevo.Enabled = true;
        }
        // limpia los campos
        private void picLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        //carga el dgv con los usuarios de la lista
        private void Cargar_Dgv(List<Usuarios> lUsuaris)
        {
            dgvUsuarios.Rows.Clear();

            foreach (Usuarios u in lUsuaris)
            {
                if (SeleccionIdioma.i.IdIdioma == 2)
                {


                    string rolidioma;
                    rolidioma = cambioIdiomaNombre(u.Rol.Rol);
                    if (u.Baja_Logica == 1)
                    {
                        if (u.FechaBaja == DateTime.MinValue)
                        {
                            dgvUsuarios.Rows.Add(u.ID_Usuario, u.Empleado.DNI, u.Empleado.Nombre + ' ' + u.Empleado.Apellido, u.Empleado.Direccion, u.Empleado.Altura, u.Empleado.Piso, u.Empleado.Departamento, u.Empleado.Loc.NLocalidad, u.Alias, rolidioma, u.FechaAlta.ToShortDateString(), " ", Rec.No);

                        }
                        else
                        {
                            dgvUsuarios.Rows.Add(u.ID_Usuario, u.Empleado.DNI, u.Empleado.Nombre + ' ' + u.Empleado.Apellido, u.Empleado.Direccion, u.Empleado.Altura, u.Empleado.Piso, u.Empleado.Departamento, u.Empleado.Loc.NLocalidad, u.Alias, rolidioma, u.FechaAlta.ToShortDateString(), u.FechaBaja.ToShortDateString(), Rec.No);

                        }

                    }
                    else
                    {
                        dgvUsuarios.Rows.Add(u.ID_Usuario, u.Empleado.DNI, u.Empleado.Nombre + ' ' + u.Empleado.Apellido, u.Empleado.Direccion, u.Empleado.Altura, u.Empleado.Piso, u.Empleado.Departamento, u.Empleado.Loc.NLocalidad, u.Alias, rolidioma, u.FechaAlta.ToShortDateString(), ' ', Rec.Si);

                    }
                }
                else
                {
                    if (u.Baja_Logica == 1)
                    {
                        if (u.FechaBaja == DateTime.MinValue)
                        {
                            dgvUsuarios.Rows.Add(u.ID_Usuario, u.Empleado.DNI, u.Empleado.Nombre + ' ' + u.Empleado.Apellido, u.Empleado.Direccion, u.Empleado.Altura, u.Empleado.Piso, u.Empleado.Departamento, u.Empleado.Loc.NLocalidad, u.Alias, u.Rol.Rol, u.FechaAlta.ToShortDateString(), " ", Rec.No);

                        }
                        else
                        {
                            dgvUsuarios.Rows.Add(u.ID_Usuario, u.Empleado.DNI, u.Empleado.Nombre + ' ' + u.Empleado.Apellido, u.Empleado.Direccion, u.Empleado.Altura, u.Empleado.Piso, u.Empleado.Departamento, u.Empleado.Loc.NLocalidad, u.Alias, u.Rol.Rol, u.FechaAlta.ToShortDateString(), u.FechaBaja.ToShortDateString(), Rec.No);

                        }

                    }
                    else
                    {
                        dgvUsuarios.Rows.Add(u.ID_Usuario, u.Empleado.DNI, u.Empleado.Nombre + ' ' + u.Empleado.Apellido, u.Empleado.Direccion, u.Empleado.Altura, u.Empleado.Piso, u.Empleado.Departamento, u.Empleado.Loc.NLocalidad, u.Alias, u.Rol.Rol, u.FechaAlta.ToShortDateString(), ' ', Rec.Si);

                    }
                }
            }
        }
        //carga el panel con el formulario con los datos del usuario seleccionado
        private void Click_Detalle(object sender, DataGridViewCellEventArgs e)
        {
            user = new Usuarios();
            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "accion" && dgvUsuarios.Rows.Count != 0)
            {
                picContraseña.Tag = "activar";
                TxbContraseña.UseSystemPasswordChar = true;
                picContraseña.Image = Properties.Resources.mostrar;
                user.ID_Usuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
                Cargar_Usuario(user.ID_Usuario);
                
                Cargar_PanelUsuarios();
                habilitar(false);
                picLimpiar.Enabled = false;
                picContraseña.Enabled = false;
                chkActivo.Enabled = false;
                Botones(false);
                BtnEditar.Enabled = true;
                pnlCrud.Visible = true;

            }
        }
        // carga los datos de la lista con el usuario seleccionado
        private void Cargar_Usuario(int cod)
        {
            foreach (Usuarios u in lUsuaris)
            {
                if (u.ID_Usuario == cod)
                {
                    user = u;
                    break;
                }
            }
        }
        //carga el panel de usuario
        private void Cargar_PanelUsuarios()
        {
            txbApellido.Text = user.Empleado.Apellido;
            txbCod.Text = user.ID_Usuario.ToString();
            txbDireccion.Text = user.Empleado.Direccion;
            txbDepto.Text = user.Empleado.Departamento;
            nupaltura.Value = user.Empleado.Altura;
            cboloclaidad.SelectedValue = user.Empleado.Loc.idLocalidad;
            nupPiso.Value = user.Empleado.Piso;
            txbNombre.Text = user.Empleado.Nombre;
            TxbAlias.Text = user.Alias;
            TxbContraseña.Text = user.Contraseña;
            TxbDni.Text = user.Empleado.DNI.ToString();
            TxbTelefono.Text = user.Empleado.Telefono.ToString();
            CboRoles.SelectedValue = user.Rol.Id_Rol;
            txbIDEmpleado.Text = user.Empleado.Id_Empleado.ToString();
            dateTimePicker1.Value = user.Empleado.FechaNacimiento;
            if (user.Baja_Logica == 0)
            {
                chkActivo.Checked = true;
                ChKActual = true;
                chkestado = true;
            }
            else
            {
                chkActivo.Checked = false;
                ChKActual = false;
                chkestado = false;

            }
        }
        //carga cbo roles
        private void cargar_cboRoles(ComboBox cbo, string display, string value)
        {
            cbo.DataSource = lcbo.ObtenerRoles();
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;
        }
        //Btn Guardar, verifica si desea dar de baja un usuario, si quiere darse de baja el mismo no podrá y verifica si el alias y dni usado existe o no y realiza el alta
        //o modficacion segun lo requiera
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (chkestado && !chkActivo.Checked)
            {
                if (MessageBox.Show(Rec.messageDarBajUsuario, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Validaciones())
                    {
                        string aliasActual;
                        Usuarios us = new Usuarios();
                        Empleado emp = new Empleado();
                        aliasActual = user.Alias;
                        AbstraerUsuario(emp, us);

                        if (lg.BuscarUsuario(user.ID_Usuario))
                        {
                            us.ID_Usuario = user.ID_Usuario;
                            emp.Id_Empleado = Convert.ToInt32(txbIDEmpleado.Text);
                            us.Empleado = emp;
                            if (us.ID_Usuario == LogIn.u.ID_Usuario && us.Baja_Logica == 1)
                            {

                                MessageBox.Show(Rec.MessageUsuarioNopuededarsedebaja, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                if (aliasActual == us.Alias)
                                {

                                    if (lg.ModificarUsuario(us, LogIn.u))
                                    {

                                        MessageBox.Show(Rec.MessageUsuarioModificado);
                                        Cargar_Usuario(user.ID_Usuario);
                                        lUsuaris.Clear();
                                        lUsuaris = lg.ObtenerUsuarios(0);
                                        RbtActivos.Checked = true;
                                        Botones(false);
                                        btnNuevo.Enabled = true;
                                        Cargar_Dgv(lUsuaris);
                                        Limpiar();
                                        pnlCrud.Visible = false;
                                        user = new Usuarios();
                                    }
                                }
                                else if (!lg.BuscarAliasUsuario(us.Alias))
                                {

                                    if (lg.ModificarUsuario(us, LogIn.u))
                                    {

                                        MessageBox.Show(Rec.MessageUsuarioModificado);
                                        Cargar_Usuario(user.ID_Usuario);
                                        lUsuaris.Clear();
                                        lUsuaris = lg.ObtenerUsuarios(0);
                                        RbtActivos.Checked = true;
                                        Botones(false);
                                        btnNuevo.Enabled = true;
                                        Cargar_Dgv(lUsuaris);
                                        Limpiar();
                                        pnlCrud.Visible = false;
                                        user = new Usuarios();

                                    }
                                }
                                else
                                {
                                    MessageBox.Show(Rec.MessageAliasIngresadoyaregistrado, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                            }
                        }
                        else
                        {
                            if (!lg.BuscarAliasUsuario(us.Alias))
                            {
                                if (!lg.BuscarDniUsuario(us.Empleado.DNI))
                                {
                                    if (lg.AltaUsuario(us, LogIn.u))
                                    {
                                        MessageBox.Show(Rec.MessageUsuarioAgregadoCorrectamente);
                                        Cargar_Usuario(user.ID_Usuario);
                                        lUsuaris.Clear();
                                        lUsuaris = lg.ObtenerUsuarios(0);
                                        RbtActivos.Checked = true;
                                        Botones(false);
                                        btnNuevo.Enabled = true;
                                        Cargar_Dgv(lUsuaris);
                                        Limpiar();
                                        pnlCrud.Visible = false;
                                        user = new Usuarios();

                                    }
                                    else
                                    {
                                        MessageBox.Show(Rec.messageNosepudoagregarusuario, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    }

                                }
                                else
                                {
                                    MessageBox.Show(Rec.MessageboxDniyaregistrado, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show(Rec.MessageAliasIngresadoyaregistrado, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }

                        if (LogIn.u.Rol.Id_Rol != 1 && LogIn.u.Rol.Id_Rol != 2 && LogIn.u.Rol.Id_Rol != 3)
                        {
                            lUsuaris = lg.ObtenerUsuario(LogIn.u);

                            Cargar_Dgv(lUsuaris);
                            btnNuevo.Enabled = false;
                            rbtTodos.Enabled = false;
                            RbtActivos.Enabled = false;
                            RbtEliminados.Enabled = false;
                            RbtAlias.Enabled = false;
                            RbtDNI.Enabled = false;
                            RbtNombre.Enabled = false;
                            RbtAlias.Enabled = false;
                            RbtCodigo.Enabled = false;
                            txbbusqueda.Enabled = false;
                            BtnBuscar.Enabled = false;
                            picreset.Enabled = false;
                        }

                    }

                }
            }
            else
            {
                if (Validaciones())
                {
                    string aliasActual;
                    Usuarios us = new Usuarios();
                    Empleado emp = new Empleado();
                    aliasActual = user.Alias;
                    AbstraerUsuario(emp, us);

                    if (lg.BuscarUsuario(user.ID_Usuario))
                    {
                        us.ID_Usuario = user.ID_Usuario;
                        emp.Id_Empleado = Convert.ToInt32(txbIDEmpleado.Text);
                        us.Empleado = emp;
                        if (us.ID_Usuario == LogIn.u.ID_Usuario && us.Baja_Logica == 1)
                        {

                            MessageBox.Show(Rec.MessageUsuarioNopuededarsedebaja, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            if (aliasActual == us.Alias)
                            {

                                if (lg.ModificarUsuario(us, LogIn.u))
                                {

                                    MessageBox.Show(Rec.MessageUsuarioModificado);
                                    Cargar_Usuario(user.ID_Usuario);
                                    lUsuaris.Clear();
                                    lUsuaris = lg.ObtenerUsuarios(0);
                                    RbtActivos.Checked = true;
                                    Botones(false);
                                    btnNuevo.Enabled = true;
                                    Cargar_Dgv(lUsuaris);
                                    Limpiar();
                                    pnlCrud.Visible = false;
                                    user = new Usuarios();
                                }
                            }
                            else if (!lg.BuscarAliasUsuario(us.Alias))
                            {

                                if (lg.ModificarUsuario(us, LogIn.u))
                                {

                                    MessageBox.Show(Rec.MessageUsuarioModificado);
                                    Cargar_Usuario(user.ID_Usuario);
                                    lUsuaris.Clear();
                                    lUsuaris = lg.ObtenerUsuarios(0);
                                    RbtActivos.Checked = true;
                                    Botones(false);
                                    btnNuevo.Enabled = true;
                                    Cargar_Dgv(lUsuaris);
                                    Limpiar();
                                    pnlCrud.Visible = false;
                                    user = new Usuarios();

                                }
                            }
                            else
                            {
                                MessageBox.Show(Rec.MessageAliasIngresadoyaregistrado, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                    else
                    {
                        if (!lg.BuscarAliasUsuario(us.Alias))
                        {
                            if (!lg.BuscarDniUsuario(us.Empleado.DNI))
                            {
                                if (lg.AltaUsuario(us, LogIn.u))
                                {
                                    MessageBox.Show(Rec.MessageUsuarioAgregadoCorrectamente);
                                    Cargar_Usuario(user.ID_Usuario);
                                    lUsuaris.Clear();
                                    lUsuaris = lg.ObtenerUsuarios(0);
                                    RbtActivos.Checked = true;
                                    Botones(false);
                                    btnNuevo.Enabled = true;
                                    Cargar_Dgv(lUsuaris);
                                    Limpiar();
                                    pnlCrud.Visible = false;
                                    user = new Usuarios();

                                }
                                else
                                {
                                    MessageBox.Show(Rec.messageNosepudoagregarusuario, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }

                            }
                            else
                            {
                                MessageBox.Show(Rec.MessageboxDniyaregistrado, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show(Rec.MessageAliasIngresadoyaregistrado, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                    if (LogIn.u.Rol.Id_Rol != 1 && LogIn.u.Rol.Id_Rol != 2 && LogIn.u.Rol.Id_Rol != 3)
                    {
                        lUsuaris = lg.ObtenerUsuario(LogIn.u);

                        Cargar_Dgv(lUsuaris);
                        btnNuevo.Enabled = false;
                        rbtTodos.Enabled = false;
                        RbtActivos.Enabled = false;
                        RbtEliminados.Enabled = false;
                        RbtAlias.Enabled = false;
                        RbtDNI.Enabled = false;
                        RbtNombre.Enabled = false;
                        RbtAlias.Enabled = false;
                        RbtCodigo.Enabled = false;
                        txbbusqueda.Enabled = false;
                        BtnBuscar.Enabled = false;
                        picreset.Enabled = false;
                    }

                }

            }
        }
        //validacion de datos
        private bool Validaciones()
        {
            if (txbNombre.Text == string.Empty)
            {
                MessageBox.Show(Rec.MessageValidacionNombre,Rec.CapError,MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            if (txbApellido.Text == string.Empty)
            {
                MessageBox.Show(Rec.MessageValidacionApellido, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TxbDni.Text == string.Empty)
            {
                MessageBox.Show(Rec.MessageValidacionDNIvacio, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbDireccion.Text == string.Empty)
            {
                MessageBox.Show(Rec.MessageValidacionDireccion, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TxbTelefono.Text == string.Empty)
            {
                MessageBox.Show(Rec.MessageValidacionTelefonovacio, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TxbAlias.Text == string.Empty)
            {
                MessageBox.Show(Rec.MessageValidacionAlias, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TxbContraseña.Text == string.Empty)
            {
                MessageBox.Show(Rec.MessageValidacionContraseña, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dateTimePicker1.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
            {
                MessageBox.Show(Rec.MessageValidacionfecha, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CboRoles.SelectedIndex == -1)
            {
                MessageBox.Show(Rec.MessageValidacionRoles, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cboloclaidad.SelectedIndex == -1)
            {
                MessageBox.Show(Rec.MessageSedebeCargarLoc, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nupaltura.Value == 0)
            {
                MessageBox.Show(Rec.validacionAltura, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TxbDni.Text.Length > 8)
            {
                MessageBox.Show(Rec.validacionDNI, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbNombre.Text.Length > 30)
            {
                MessageBox.Show(Rec.ValidacionLengNombre, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbApellido.Text.Length > 30)
            {
                MessageBox.Show(Rec.ValidacionLengApellido, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                Convert.ToInt64(TxbDni.Text);
            }
            catch
            {
                MessageBox.Show(Rec.MessageValidacionDNInumero, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            try
            {
                Convert.ToInt64(TxbTelefono.Text);
            }
            catch
            {
                MessageBox.Show(Rec.MessageValidacionTelefonoNumero, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }


            return true;
        }
        //abstraer usuario
        private void AbstraerUsuario(Empleado e, Usuarios u)
        {
            Roles r = new Roles();
            Localidad l = new Localidad();
            l.idLocalidad = Convert.ToInt32(cboloclaidad.SelectedValue);
            e.Nombre = txbNombre.Text;
            e.Apellido = txbApellido.Text;
            e.Direccion = txbDireccion.Text;
            e.Altura = Convert.ToInt32(nupaltura.Value);
            e.Piso = Convert.ToInt32(nupPiso.Value);
            e.Departamento = txbDepto.Text;
            e.Loc = l;
            e.DNI = Convert.ToInt64(TxbDni.Text);
            e.Telefono = Convert.ToInt64(TxbTelefono.Text);
            e.FechaNacimiento = dateTimePicker1.Value;
            if (chkActivo.Checked == true)
            {
                e.Baja_logica = 0;
                u.Baja_Logica = 0;
                
            }
            else
            {
                e.Baja_logica = 1;
                u.Baja_Logica = 1;
            }
            if (ChKActual != chkActivo.Checked)
            {
                banderaBaja = true;
            }
            else
            {
                banderaBaja = false;
            }
            r.Id_Rol = Convert.ToInt32(CboRoles.SelectedValue);
            u.Empleado = e;
            u.Rol=r;
            u.Alias = TxbAlias.Text;
            u.Contraseña = TxbContraseña.Text;
        }
        //habilitar campos

        private void habilitar(bool a)
        {
            txbApellido.Enabled = a;
            txbDireccion.Enabled = a;
            txbNombre.Enabled = a;
            TxbAlias.Enabled = a;
            TxbContraseña.Enabled = a;
            TxbDni.Enabled = a;
            TxbTelefono.Enabled = a;
            CboRoles.Enabled = a;
            txbIDEmpleado.Enabled = a;
            dateTimePicker1.Enabled = a;
            chkActivo.Enabled = a;
            txbDepto.Enabled = a;
            nupaltura.Enabled = a;
            nupPiso.Enabled =a;
            cboloclaidad.Enabled =a;
        }
        //segun rbt este acitvo mostrara en la dgv
        private void RbtActivos_CheckedChanged(object sender, EventArgs e)
        {
            lUsuaris.Clear();
            dgvselectedcondicion = 0;
            lUsuaris = lg.ObtenerUsuarios(dgvselectedcondicion);
            Cargar_Dgv(lUsuaris);
        }

        private void RbtEliminados_CheckedChanged(object sender, EventArgs e)
        {
            lUsuaris.Clear();
            dgvselectedcondicion = 1;
            lUsuaris = lg.ObtenerUsuarios(dgvselectedcondicion);
            Cargar_Dgv(lUsuaris);
        }

        private void rbtTodos_CheckedChanged(object sender, EventArgs e)
        {
            lUsuaris.Clear();
            dgvselectedcondicion = 2;
            lUsuaris = lg.ObtenerUsuarios(dgvselectedcondicion);
            Cargar_Dgv(lUsuaris);
        }
        //BOTON BUSCAR!!, realiza la busqueda segun la opcion seleccionada, 
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            lUsuaris.Clear();
            lUsuaris = lg.ObtenerUsuarios(dgvselectedcondicion);
            Cargar_Dgv(lUsuaris);
            if (RbtCodigo.Checked)
            {
                try
                {
                    Convert.ToInt32(txbbusqueda.Text);
                    List<DataGridViewRow> temp = new List<DataGridViewRow>();

                    foreach (DataGridViewRow row in dgvUsuarios.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["codigoUser"].Value) != Convert.ToInt32(txbbusqueda.Text))
                        {
                            temp.Add(row);
                        }

                    }

                    foreach (DataGridViewRow row in temp)
                    {

                        dgvUsuarios.Rows.Remove(row);

                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(Rec.MessageFiltrarporcodigodebecargarnumero,Rec.CapError,MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
                }
            }
            else if(RbtDNI.Checked)
            {
                try
                {
                    Convert.ToInt32(txbbusqueda.Text);
                    List<DataGridViewRow> temp = new List<DataGridViewRow>();

                    foreach (DataGridViewRow row in dgvUsuarios.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["dni"].Value) != Convert.ToInt32(txbbusqueda.Text))
                        {
                            temp.Add(row);
                        }

                    }

                    foreach (DataGridViewRow row in temp)
                    {

                        dgvUsuarios.Rows.Remove(row);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(Rec.MessageParafiltrarpordni);

                }
            }
            else if(RbtNombre.Checked)
            {
                if (txbbusqueda.Text != string.Empty)
                {
                    List<DataGridViewRow> temp = new List<DataGridViewRow>();

                    foreach (DataGridViewRow row in dgvUsuarios.Rows)
                    {
                        if (Convert.ToString(row.Cells["nombre"].Value) != txbbusqueda.Text)
                        {
                            temp.Add(row);
                        }

                    }

                    foreach (DataGridViewRow row in temp)
                    {

                        dgvUsuarios.Rows.Remove(row);

                    }
                }
               
            }
            else if (RbtAlias.Checked)
            {
                if (txbbusqueda.Text != string.Empty)
                {
                    List<DataGridViewRow> temp = new List<DataGridViewRow>();

                    foreach (DataGridViewRow row in dgvUsuarios.Rows)
                    {
                        if (Convert.ToString(row.Cells["Alias"].Value) != txbbusqueda.Text)
                        {
                            temp.Add(row);
                        }

                    }

                    foreach (DataGridViewRow row in temp)
                    {

                        dgvUsuarios.Rows.Remove(row);

                    }
                }

            }
        }
        //reseta los filtros anteriores y carga como estaba al principio
        private void picreset_Click(object sender, EventArgs e)
        {
            lUsuaris.Clear();
            RbtActivos.Checked = true;
            dgvselectedcondicion = 0;
            txbbusqueda.Text = string.Empty;
            lUsuaris = lg.ObtenerUsuarios(dgvselectedcondicion);
            Cargar_Dgv(lUsuaris);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void pnlCrud_Paint(object sender, PaintEventArgs e)
        {

        }
        //aplica idioma 
        public void AplicarIdioma()
        {
            lbusuarios.Text = Rec.Usuarios;
            RbtCodigo.Text = Rec.Codigo;
            RbtNombre.Text = Rec.Nombre;
            RbtDNI.Text = Rec.DNI;
            RbtAlias.Text= Rec.Alias;
            BtnBuscar.Text = Rec.Buscar;
            rbtTodos.Text = Rec.Todos;
            RbtActivos.Text= Rec.Activos;
            RbtEliminados.Text = Rec.Eliminados;
            lbNombre.Text = Rec.Nombre;
            lbApellido.Text = Rec.Apellido;
            lbdni.Text = Rec.DNI;
            lbDireccion.Text = Rec.Calle;
            lbTel.Text = Rec.Telefono;
            lbFechaNac.Text = Rec.FechaNacimineto;
            lbalias.Text = Rec.Alias;
            lbcontraseña.Text = Rec.Contraseña;
            lbroles.Text = Rec.Roles;
            chkActivo.Text = Rec.Activo;
            btnNuevo.Text = Rec.Nuevo;
            BtnEditar.Text = Rec.Editar;
            BtnCancelar.Text = Rec.Cancelar;
            BtnGuardar.Text = Rec.Guardar;
            dgvUsuarios.Columns[0].HeaderText = Rec.CodigoUsuario;
            dgvUsuarios.Columns[1].HeaderText = Rec.DNI;
            dgvUsuarios.Columns[2].HeaderText = Rec.NombreCompleto;
            dgvUsuarios.Columns[3].HeaderText = Rec.Calle;
            dgvUsuarios.Columns[4].HeaderText = Rec.Altura;
            dgvUsuarios.Columns[5].HeaderText = Rec.Piso;
            dgvUsuarios.Columns[6].HeaderText = Rec.Departamento;
            dgvUsuarios.Columns[7].HeaderText = Rec.localidad;

            dgvUsuarios.Columns[8].HeaderText = Rec.Alias;
            dgvUsuarios.Columns[9].HeaderText = Rec.Rol;
            dgvUsuarios.Columns[10].HeaderText = Rec.FechaAlta;
            dgvUsuarios.Columns[11].HeaderText = Rec.FechaBaja;
            dgvUsuarios.Columns[12].HeaderText = Rec.Activo;
            dgvUsuarios.Columns[13].HeaderText = Rec.Detalle;
            btnLocalidad.Text = Rec.localidad;
            lbAltura.Text = Rec.Altura;
            lbpiso.Text = Rec.Piso;
            lbDepartamento.Text = Rec.Departamento;
            lblocalidad.Text = Rec.localidad;

        }
        //detecta idioma seleccionado
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
        //aplica idioma a los botones de la dgv
        private void dgvUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "accion")
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

        //carga cbo de localidad
        private void cargar_cboLocalidad(ComboBox cbo, string display, string value)
        {
            cbo.DataSource = lcbo.Localidad();
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;
        }
        //abre form para cargar nueva localidad si es necesario
        private void btnLocalidad_Click(object sender, EventArgs e)
        {
            FormLocalidad fm = new FormLocalidad();
            fm.ShowDialog();
            if (fm.DialogResult == DialogResult.OK)
            {
                cargar_cboLocalidad(cboloclaidad, "NLocalidad", "idLocalidad");

            }
        }
        //solo permite cargar letras
        private void txbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar < 0 || e.KeyChar > 127)
            {
                e.Handled = true;
            }
        }
        //solo permite cargar letras

        private void txbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar < 0 || e.KeyChar > 127)
            {
                e.Handled = true;
            }
        }
        //solo permite cargar letras

        private void txbDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar < 0 || e.KeyChar > 127)
            {
                e.Handled = true;
            }
        }
        //solo permite cargar numeros

        private void TxbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //solo permite cargar numeros

        private void TxbDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //cambia idioma a los roles
        private string cambioIdiomaNombre(string a)
        {
            string aa = "";
            if (a == "Gerente")
            {
                aa = "Manager";
            }else if (a == "Representante Tècnico")
            {
                aa = "Technical Representative";

            }
            else if (a == "Administrativo")
            {
                aa = "Administrative";


            }
            else if (a == "Contador")
            {
                aa = "Accountant";

            }
            else if (a == "Encargados")
            {
                aa = "supervisor";

            }
            else if (a == "Vendedores")
            {
                aa = "Sellers";

            }
            return aa;
        }
    }
}
