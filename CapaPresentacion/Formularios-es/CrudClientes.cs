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
    public partial class CrudClientes : Form
    {
        public CrudClientes()
        {
            InitializeComponent();
        }

        private void CrudClubSocial_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlCrud.Visible = true;
            Botones(false);
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
        }

        private void picbajar_Click(object sender, EventArgs e)
        {
            pnlCrud.Visible = false;

        }

        private void pnlCrud_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Click_Acciones(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCliente.Columns[e.ColumnIndex].Name == "Acciones")
            {
                pnlCrud.Visible = true;

            }
        }

        private void Botones(bool a)
        {
            BtnBorrar.Enabled = a;
            BtnCancelar.Enabled = a;
            btnNuevo.Enabled = a;
            BtnEditar.Enabled = a;
            BtnGuardar.Enabled = a;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Botones(false);
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            pnlCrud.Visible = false;
            Botones(true);

        }

        private void Limpiar()
        {
            txbNombre.Text = string.Empty;
            TxbApellido.Text = string.Empty;
            TxbCodCliente.Text = string.Empty;
            TxbDni.Text = string.Empty;
            TxbEmail.Text = string.Empty;
            CboTipoCliente.SelectedIndex = -1;
        }

        private void picLimpar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }
    }
}
