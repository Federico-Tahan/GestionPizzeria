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
    public partial class CrudProductos : Form
    {
        public CrudProductos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlCrud.Visible = true;
            Botones(false);
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
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
            txbNombre.Text = string.Empty;
            txbDescripcion.Text = string.Empty;
            txbCodProd.Text = string.Empty;
            cboClasificacion.SelectedIndex = -1;
            cboUnidadMeidda.SelectedIndex = -1;
            cboTipoProd.SelectedIndex = - 1;
            chkActivo.Checked = true;
            numpPrecio.Value = 0;
            nupStock.Value = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Limpiar();
            pnlCrud.Visible = false;
            Botones(true);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
