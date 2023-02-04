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
            Cargar_Dgv();
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
            pnlCrud.Visible = true;
            Botones(false);
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Botones(false);
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
            txbApellido.Text= string.Empty;
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
        private void Cargar_Dgv()
        {
            lUsuaris= lg.ObtenerUsuarios();

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
            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "accion")
            {
                user.ID_Usuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
                Cargar_Usuario(user.ID_Usuario);
                Cargar_PanelUsuarios();
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
        }

    }
}
