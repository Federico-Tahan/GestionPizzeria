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

namespace CapaPresentacion.Formularios
{
    public partial class CrudUsuarios : Form
    {
        ing_CrudUsuarios lg = new ng_CrudUsuarios();
        int dgvselectedcondicion = 0;
        ing_Cbos lcbo = new ng_Cbos();
        List<Usuarios> lUsuaris= new List<Usuarios>();  
        Usuarios user = new Usuarios();
        Empleado e = new Empleado();
        public CrudUsuarios()
        {
            InitializeComponent();
        }

        private void CrudUsuarios_Load(object sender, EventArgs e)
        {
            lUsuaris.Clear();
            lUsuaris = lg.ObtenerUsuarios(dgvselectedcondicion);
            Cargar_Dgv(lUsuaris);
            cargar_cboRoles(CboRoles, "Rol", "id_rol");
        }
        private void Botones(bool a)
        {
            BtnCancelar.Enabled = a;
            btnNuevo.Enabled = a;
            BtnEditar.Enabled = a;
            BtnGuardar.Enabled = a;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitar(true);
            picLimpiar.Enabled = true;
            picContraseña.Enabled = true;
            pnlCrud.Visible = true;
            Botones(false);
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
            user = new Usuarios();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Botones(false);
            habilitar(false);
            picContraseña.Enabled = true;
            picLimpiar.Enabled = true;
            chkActivo.Enabled = true;
            TxbAlias.Enabled= true;
            TxbContraseña.Enabled = true;
            txbDireccion.Enabled = true;
            TxbTelefono.Enabled = true;
            CboRoles.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            pnlCrud.Visible = false;
            Botones(false);
            btnNuevo.Enabled = true;
        }

        private void Limpiar()
        {
            if (txbNombre.Enabled)
            {
                txbApellido.Text = string.Empty;
                txbCod.Text = string.Empty;
                txbDireccion.Text = string.Empty;
                txbNombre.Text = string.Empty;
                TxbAlias.Text = string.Empty;
                TxbContraseña.Text = string.Empty;
                TxbDni.Text = string.Empty;
                TxbTelefono.Text = string.Empty;
                CboRoles.SelectedIndex = -1;
                chkActivo.Checked = true;
            }
            else
            {
                txbDireccion.Text = string.Empty;
                TxbAlias.Text = string.Empty;
                TxbContraseña.Text = string.Empty;
                TxbTelefono.Text = string.Empty;
                CboRoles.SelectedIndex = -1;
                chkActivo.Checked = true;
            }


        }

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

        private void picBajar_Click(object sender, EventArgs e)
        {
            Limpiar();
            pnlCrud.Visible = false;
            Botones(false);
            btnNuevo.Enabled = true;
        }

        private void picLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Cargar_Dgv(List<Usuarios> lUsuaris)
        {
            dgvUsuarios.Rows.Clear();

            foreach (Usuarios u in lUsuaris)
            {
                if (u.Baja_Logica == 1)
                {
                    dgvUsuarios.Rows.Add(u.ID_Usuario, u.Empleado.DNI, u.Empleado.Nombre + ' ' + u.Empleado.Apellido, u.Alias, u.Rol.Rol, "No");

                }
                else
                {
                    dgvUsuarios.Rows.Add(u.ID_Usuario, u.Empleado.DNI, u.Empleado.Nombre + ' ' + u.Empleado.Apellido, u.Alias, u.Rol.Rol, "Si");

                }
            }
        }

        private void Click_Detalle(object sender, DataGridViewCellEventArgs e)
        {
            user = new Usuarios();
            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "accion")
            {
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

        private void Cargar_PanelUsuarios()
        {
            txbApellido.Text = user.Empleado.Apellido;
            txbCod.Text = user.ID_Usuario.ToString();
            txbDireccion.Text = user.Empleado.Direccion;
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
            }
            else
            {
                chkActivo.Checked = false;
            }
        }


        private void cargar_cboRoles(ComboBox cbo, string display, string value)
        {
            cbo.DataSource = lcbo.ObtenerRoles();
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
            if (Validaciones())
            {
                Usuarios us = new Usuarios();
                Empleado emp = new Empleado();
                AbstraerUsuario(emp,us);
                if (lg.BuscarUsuario(user.ID_Usuario))
                {
                    us.ID_Usuario = user.ID_Usuario;
                    emp.Id_Empleado = Convert.ToInt32(txbIDEmpleado.Text);
                    us.Empleado = emp;
                    if (lg.ModificarUsuario(us))
                    {
                        MessageBox.Show("Usuario Modificado con Exito.");

                    }
                    else
                    {
                        MessageBox.Show("Problema al cargar datos, corrobore que los datos cargados sean correctos");
                    }
                }
                else
                {
                    if ( lg.AltaUsuario(us))
                    {
                        MessageBox.Show("Usuario Agregado Correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Problema con el servidor, Intentelo de nuevo más tarde");

                    }
                }
                Cargar_Usuario(user.ID_Usuario);
                lUsuaris.Clear();
                lUsuaris = lg.ObtenerUsuarios(0);
                RbtActivos.Checked = true;
                Cargar_Dgv(lUsuaris);
                Limpiar();
                pnlCrud.Visible = false;
            }
        }

        private bool Validaciones()
        {
            if (txbNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el nombre del usuario.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            if (txbApellido.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el apellido del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TxbDni.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el DNI correctamente del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbDireccion.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar la direccion del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TxbTelefono.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el telefono correctamente del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TxbAlias.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el Alias del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TxbContraseña.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar la contraseña del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dateTimePicker1.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
            {
                MessageBox.Show("Debe ingresar la fecha de nacimiento del usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CboRoles.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar el rol del usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                Convert.ToInt64(TxbDni.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un numero en el DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            try
            {
                Convert.ToInt64(TxbTelefono.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un numero en Telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }


            return true;
        }

        private void AbstraerUsuario(Empleado e, Usuarios u)
        {
            Roles r = new Roles();
            e.Nombre = txbNombre.Text;
            e.Apellido = txbApellido.Text;
            e.Direccion = txbDireccion.Text;
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
            r.Id_Rol = Convert.ToInt32(CboRoles.SelectedValue);
            u.Empleado = e;
            u.Rol=r;
            u.Alias = TxbAlias.Text;
            u.Contraseña = TxbContraseña.Text;
        }


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
        }

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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
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
                    MessageBox.Show("Para filtrar por codigo de usuario debe cargar un numero");
                    
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
                    MessageBox.Show("Para filtrar por Dni debe cargar un numero");

                }
            }
            else if(RbtNombre.Checked)
            {
                if (txbbusqueda.Text != string.Empty)
                {
                    List<DataGridViewRow> temp = new List<DataGridViewRow>();

                    foreach (DataGridViewRow row in dgvUsuarios.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["nombre"].Value) != Convert.ToInt32(txbbusqueda.Text))
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
                        if (Convert.ToInt32(row.Cells["Alias"].Value) != Convert.ToInt32(txbbusqueda.Text))
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

        private void picreset_Click(object sender, EventArgs e)
        {
            lUsuaris.Clear();
            RbtActivos.Checked = true;
            dgvselectedcondicion = 0;
            lUsuaris = lg.ObtenerUsuarios(dgvselectedcondicion);
            Cargar_Dgv(lUsuaris);
        }
    }
}
