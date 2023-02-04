using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class CrudUsuarios : Form
    {
        public CrudUsuarios()
        {
            InitializeComponent();
        }

        private void CrudUsuarios_Load(object sender, EventArgs e)
        {

        }
        private void Botones(bool a)
        {
            BtnBorrar.Enabled = a;
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
            Botones(true);
        }

        private void Limpiar()
        {
            txbApellido.Text= string.Empty;
            txbCod.Text = string.Empty;
            txbNombre.Text = string.Empty;
            TxbAlias.Text = string.Empty;
            TxbContraseña.Text = string.Empty;
            TxbDni.Text = string.Empty;
            TxbEmail.Text = string.Empty;
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
            Botones(true);
        }

        private void picLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
