using CapaCapaNegocio.Interfaces;
using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;
using CapaNegocio.Implementacion;
using CapaNegocio.Interfaces;
using CapaPresentacion.Formularios.CombosProducto;
using CapaPresentacion.Formularios_es.CombosProducto;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace CapaPresentacion.Formularios
{
    public partial class CrudProductos : Form
    {
        ing_Cbos lgcbo = new ng_Cbos();
        ing_CrudProductos lg = new ng_CrudProductos();
        List<Producto> lproductos = new List<Producto>();   
        Producto prodSelect = new Producto();   
        public CrudProductos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlCrud.Visible = true;
            Limpiar();
            Botones(false);
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;
            Habilitar(true);
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
            Habilitar(true);

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
            txbNombre.Text = string.Empty;
            txbDescripcion.Text = string.Empty;
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
            Botones(false);
            btnNuevo.Enabled = true;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void cargar_cboClasificacion(ComboBox cbo, string display, string value)
        {
            cbo.DataSource = lgcbo.ObtenerClasificacion();
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;
        }
        private void cargar_cboTipoProducto(ComboBox cbo, string display, string value)
        {
            cbo.DataSource = lgcbo.ObtenerTipoProducto();
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;
        }
        private void cargar_cboUnidadMedida(ComboBox cbo, string display, string value)
        {
            cbo.DataSource = lgcbo.ObtenerUnidadMedida();
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;
        }
        private void CrudProductos_Load(object sender, EventArgs e)
        {
            cargar_cboClasificacion(cboClasificacion,"clasificacion", "IdClasificacion");
            cargar_cboTipoProducto(cboTipoProd,"Tipo_Producto", "IdTipoProducto");
            cargar_cboUnidadMedida(cboUnidadMeidda,"Unidad_Medida", "IdUnidadMedida");
            lproductos = lg.GetProductos(0);
            cargarDgv(lproductos);
        }

        private void cargarDgv(List<Producto> lp)
        {
            dgvProd.Rows.Clear();

            foreach (Producto p in lp)
            {
                string baj = "No";
                if (p.Baja_logica == 0)
                {
                    baj = "Si";
                }
               dgvProd.Rows.Add(p.Id_producto,p.Nombre,p.Detalle,p.Tipo_producto.Tipo_producto,p.Unidadmedida.Unidad_Medida,p.clasificacion.clasificacion,p.Stock,p.Precio,baj);

            }
        }

        private void Click_Detalle(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvProd.Columns[e.ColumnIndex].Name == "accion")
            {
                prodSelect = new Producto();
                Clasificacion c = new Clasificacion();
                UnidadMedida um = new UnidadMedida();
                TipoProducto tprod = new TipoProducto();
                prodSelect.Unidadmedida= um;
                prodSelect.clasificacion= c;
                prodSelect.Tipo_producto= tprod;
                pnlCrud.Visible = true;
                prodSelect.Id_producto = Convert.ToInt32(dgvProd.CurrentRow.Cells[0].Value);
                CargarProducto(prodSelect.Id_producto);
                CargarPanelProducto(prodSelect);
                Habilitar(false);
                picLimpiar.Enabled = false;
                Botones(false);
                BtnEditar.Enabled = true;
                pnlCrud.Visible = true;

            }
        }

        private void CargarPanelProducto(Producto producto)
        {
            txbNombre.Text = producto.Nombre;
            cboClasificacion.SelectedValue = producto.clasificacion.IdClasificacion;
            cboTipoProd.SelectedValue = producto.Tipo_producto.IdTipoProducto;
            cboUnidadMeidda.SelectedValue = producto.Unidadmedida.IdUnidadMedida;
            txbDescripcion.Text = producto.Detalle;
            if (producto.Baja_logica == 0)
            {
                chkActivo.Checked = true;
            }
            else
            {
                chkActivo.Checked = false;
            }
            nupStock.Value = producto.Stock;
            numpPrecio.Value = producto.Precio;

        }

        private bool Validacion()
        {
            if (txbNombre.Text == "")
            {
                MessageBox.Show("Debe cargar el Nombre del producto","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else if (cboClasificacion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe cargar la clasificacion del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cboUnidadMeidda.SelectedIndex == -1)
            {
                MessageBox.Show("Debe cargar la unidad de medida del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cboTipoProd.SelectedIndex == -1)
            {
                MessageBox.Show("Debe cargar el tipo de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (numpPrecio.Value == 0)
            {
                MessageBox.Show("Debe cargar el precio del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                Producto prod = new Producto();
                AbstraerProducto(prod);
                if (prodSelect.Id_producto != 0)
                {
                    prod.Id_producto = prodSelect.Id_producto; 
                    if (lg.Modificacion(prod,LogIn.u))
                    {
                        MessageBox.Show("Producto Modificado con Exito.");
                        lproductos = lg.GetProductos(0);
                        cargarDgv(lproductos);
                        Botones(false);
                        Limpiar();
                        btnNuevo.Enabled = true;
                        pnlCrud.Visible = false;
                        RbtActivos.Checked = true;
                        prodSelect = new Producto();
                    }
                }
                else
                {
                    if (lg.AltaProducto(prod, LogIn.u))
                    {
                        MessageBox.Show("Producto dado de alta con Exito.");
                        lproductos = lg.GetProductos(0);
                        cargarDgv(lproductos);
                        Botones(false);
                        Limpiar();
                        btnNuevo.Enabled = true;
                        pnlCrud.Visible = false;
                        RbtActivos.Checked = true;
                    }
                }

            }
        }



        private void AbstraerProducto(Producto p)
        {
            Clasificacion c = new Clasificacion();
            UnidadMedida um = new UnidadMedida();
            TipoProducto tprod = new TipoProducto();
            p.clasificacion= c;
            p.Unidadmedida= um;
            p.Tipo_producto= tprod;
            p.Nombre = txbNombre.Text;
            p.Precio = numpPrecio.Value;
            p.Stock = Convert.ToInt32(nupStock.Value);
            p.Detalle = txbDescripcion.Text;
            p.clasificacion.IdClasificacion = Convert.ToInt32(cboClasificacion.SelectedValue);
            p.Tipo_producto.IdTipoProducto = Convert.ToInt32(cboTipoProd.SelectedValue);
            p.Unidadmedida.IdUnidadMedida = Convert.ToInt32(cboUnidadMeidda.SelectedValue);
            if (chkActivo.Checked)
            {
                p.Baja_logica = 0;
            }
            else
            {
                p.Baja_logica = 1;

            }
        }

        private void CargarProducto( int id_prod)
        {
            foreach (Producto u in lproductos)
            {
                if (u.Id_producto == id_prod)
                {
                    prodSelect = u;
                    break;
                }
            }
        }

        private void Habilitar(bool a)
        {
            txbNombre.Enabled = a;
            cboClasificacion.Enabled = a;
            cboTipoProd.Enabled = a;
            cboUnidadMeidda.Enabled = a;
            txbDescripcion.Enabled = a;
            chkActivo.Enabled = a;
            nupStock.Enabled = a;
            numpPrecio.Enabled = a;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if (rbtCodigo.Checked)
            {
                try
                {
                    lproductos.Clear();
                    lproductos = lg.GetProductos(0);
                    cargarDgv(lproductos);
                    Convert.ToInt32(txbbusqueda.Text);
                    List<DataGridViewRow> temp = new List<DataGridViewRow>();

                    foreach (DataGridViewRow row in dgvProd.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["IdProducto"].Value) != Convert.ToInt32(txbbusqueda.Text))
                        {
                            temp.Add(row);
                        }

                    }

                    foreach (DataGridViewRow row in temp)
                    {

                        dgvProd.Rows.Remove(row);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Para filtrar por codigo de usuario debe cargar un numero");

                }
            }else if (txbbusqueda.Text != string.Empty)
            {
                lproductos.Clear();
                lproductos = lg.GetProductos(0);
                cargarDgv(lproductos);
                List<DataGridViewRow> temp = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dgvProd.Rows)
                {
                    if (Convert.ToString(row.Cells["nombreprod"].Value) != txbbusqueda.Text)
                    {
                        temp.Add(row);
                    }

                }

                foreach (DataGridViewRow row in temp)
                {

                    dgvProd.Rows.Remove(row);

                }
            }
        }

        private void RbtActivos_CheckedChanged(object sender, EventArgs e)
        {
            lproductos.Clear();
            int dgvselectedcondicion = 0;
            lproductos = lg.GetProductos(dgvselectedcondicion);
            cargarDgv(lproductos);
        }

        private void RbtEliminados_CheckedChanged(object sender, EventArgs e)
        {
            lproductos.Clear();
            int dgvselectedcondicion = 1;
            lproductos = lg.GetProductos(dgvselectedcondicion);
            cargarDgv(lproductos);
        }

        private void rbtTodos_CheckedChanged(object sender, EventArgs e)
        {
            lproductos.Clear();
            int dgvselectedcondicion = 2;
            lproductos = lg.GetProductos(dgvselectedcondicion);
            cargarDgv(lproductos);
        }

        private void BtnClasificacion_Click(object sender, EventArgs e)
        {
            FormClasificacion fc = new FormClasificacion();
            fc.ShowDialog();
            if (fc.DialogResult == DialogResult.OK)
            {
                cargar_cboClasificacion(cboClasificacion, "clasificacion", "IdClasificacion");
                cargar_cboTipoProducto(cboTipoProd, "Tipo_Producto", "IdTipoProducto");
                cargar_cboUnidadMedida(cboUnidadMeidda, "Unidad_Medida", "IdUnidadMedida");
            }
        }

        private void BtnTipoProd_Click(object sender, EventArgs e)
        {
            FormTipoProd ftp = new FormTipoProd();
            ftp.ShowDialog();
            if (ftp.DialogResult == DialogResult.OK)
            {
                cargar_cboClasificacion(cboClasificacion, "clasificacion", "IdClasificacion");
                cargar_cboTipoProducto(cboTipoProd, "Tipo_Producto", "IdTipoProducto");
                cargar_cboUnidadMedida(cboUnidadMeidda, "Unidad_Medida", "IdUnidadMedida");
            }
        }

        private void btnUnidadMedida_Click(object sender, EventArgs e)
        {
            FormUnidadMedida fum = new FormUnidadMedida();
            fum.ShowDialog();
            if (fum.DialogResult == DialogResult.OK)
            {
                cargar_cboClasificacion(cboClasificacion, "clasificacion", "IdClasificacion");
                cargar_cboTipoProducto(cboTipoProd, "Tipo_Producto", "IdTipoProducto");
                cargar_cboUnidadMedida(cboUnidadMeidda, "Unidad_Medida", "IdUnidadMedida");
            }
        }
    }
}
