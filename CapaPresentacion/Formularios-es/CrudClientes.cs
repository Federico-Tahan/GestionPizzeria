using CapaDatos.Dominio;
using CapaNegocio.Implementacion;
using CapaNegocio.Interfaces;
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
        ing_Cliente lg = new ng_Cliente();
        List<Cliente> lClientes = new List<Cliente>();
        public CrudClientes()
        {
            InitializeComponent();
        }

        private void CrudClubSocial_Load(object sender, EventArgs e)
        {
            lClientes = lg.TraerClientes();
            cargarDgv(lClientes);
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

        private void cargarDgv(List<Cliente> lClientes)
        {
            dgvCliente.Rows.Clear();

            foreach (Cliente c in lClientes)
            {
                if (c.TipoCliente.Id_TipoCliente == 2)
                {
                    dgvCliente.Rows.Add(c.IdCliente, " ",c.Nombre + " "+ c.Apellido," ", " ", "No");

                }else if (c.TipoCliente.Id_TipoCliente == 1)
                {
                    dgvCliente.Rows.Add(c.IdCliente, c.socio.DNI, c.Nombre + " " + c.Apellido, c.socio.FechaAdhesion, c.socio.Email, "Si");

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
    }
}
