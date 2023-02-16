using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;
using CapaNegocio.Implementacion;
using CapaNegocio.Interfaces;
using CapaPresentacion.RecursoIdioma;
using Microsoft.Data.SqlClient;
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

namespace CapaPresentacion.Formularios.Venta
{
    public partial class AltaVenta : Form
    {
        List<Producto> lproductos = new List<Producto>();   
        Producto productoSelected = new Producto();
        ing_CrudProductos lp = new ng_CrudProductos();
        DetalleFactura df = new DetalleFactura();
        Factura f = new Factura();
        public AltaVenta()
        {
            InitializeComponent();
            lproductos = lp.GetProductos(0);
            cargar_cboProductos(cboProductos, "Nombre", "Id_producto");

        }

        private void cargar_cboProductos(ComboBox cbo, string display, string value)
        {
            cbo.DataSource = lproductos;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }
        private void BtnSig_Click(object sender, EventArgs e)
        {
            if (f.DetalleFacturas.Count !=0)
            {
                ConfirmacionVenta form = new ConfirmacionVenta(f);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    f = new Factura();
                    productoSelected = new Producto();
                    df = new DetalleFactura();
                    f.DetalleFacturas.Clear();
                    dgvDetalle.Rows.Clear();
                    numpCantidad.Value = 0;
                    txbDetalle.Text = "";
                    lproductos = lp.GetProductos(0);
                    cargar_cboProductos(cboProductos, "Nombre", "Id_producto");
                    cboProductos.SelectedIndex = -1;
                    txbStock.Text = "";
                    txbTotal.Text = "";
                }

            }
            else
            {
                MessageBox.Show(Rec.MessageCargaralmenosunprod);
            }

        }
        
        private void AltaVenta_Load(object sender, EventArgs e)
        {
            DetectarIdioma();
            AplicarIdioma();
            productoSelected = new Producto();
            cboProductos.SelectedIndex = -1;
            numpCantidad.Value = 0;
            txbStock.Text = "";
            txbDetalle.Text = "";
        }

        private void Producto_Cambia(object sender, EventArgs e)
        {
            try
            {
                if (cboProductos.SelectedIndex != -1)
                {
                    CargarProductoSelected(Convert.ToInt32(cboProductos.SelectedValue));
                    txbStock.Text = productoSelected.Stock.ToString();
                }
            }catch(Exception ex) { }
        }

        private void CargarProductoSelected(int id)
        {
            productoSelected = new Producto();
            foreach (Producto u in lproductos)
            {
                if (u.Id_producto == id)
                {
                    productoSelected = u;
                    break;
                }
            }
        }

        private void CargarDetalleSelected(int id)
        {
            df = new DetalleFactura();
            foreach (DetalleFactura u in f.DetalleFacturas)
            {
                if (u.Prod.Id_producto == id)
                {
                    df = u;
                    break;
                }
            }
        }

        private void cboProductos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboProductos.SelectedIndex != -1)
            {
                CargarProductoSelected(Convert.ToInt32(cboProductos.SelectedValue));
                txbStock.Text = productoSelected.Stock.ToString();
            }
        }

        private bool validacionStock()
        {
            if(Convert.ToInt32(numpCantidad.Value) > productoSelected.Stock)
            {
                MessageBox.Show(Rec.MessageNohaySuficienteStock);
                return false;
            }else if (Convert.ToInt32(numpCantidad.Value) == 0)
            {
                MessageBox.Show(Rec.MessageAgregaralemnosun);
                return false;
            }
            return true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (validacionStock())
            {
                if (!f.buscar(productoSelected.Id_producto))
                {
                    AbstraerDetalle();
                    f.DetalleFacturas.Add(df);
                    CargarDgvVenta();
                    txbTotal.Text = f.Calcular_Subtotal().ToString();
                    productoSelected = new Producto();
                    cboProductos.SelectedIndex = -1;
                    numpCantidad.Value = 0;
                    txbStock.Text = "";
                    txbDetalle.Text = "";

                }
                else
                {
                    MessageBox.Show(Rec.MessageElprodYaesta);
                }
            }
        }


        private void AbstraerDetalle()
        {
            df = new DetalleFactura();
            df.Descripcion = txbDetalle.Text;
            df.Prod = productoSelected;
            df.Precio = productoSelected.Precio;
            df.Cantidad = Convert.ToInt32(numpCantidad.Value);

        }

        private void CargarDgvVenta()
        {
            dgvDetalle.Rows.Clear();

            foreach (DetalleFactura com in f.DetalleFacturas)
            {
                dgvDetalle.Rows.Add(com.Prod.Id_producto,com.Prod.Nombre,com.Descripcion,com.Prod.Tipo_producto.Tipo_producto,
                    com.Prod.Unidadmedida.Unidad_Medida, com.Prod.clasificacion.clasificacion, com.Cantidad,"$ " +com.Precio,
                    "$ "+ com.Cantidad * com.Precio);
            }
        }

        private void Boton_Quitar(object sender, DataGridViewCellEventArgs e)
        {
            df = new DetalleFactura();
            if (dgvDetalle.Columns[e.ColumnIndex].Name == "Accion")
            {
                CargarDetalleSelected(Convert.ToInt32(dgvDetalle.CurrentRow.Cells[0].Value));
                f.remover(df);
                dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow);
                txbTotal.Text = f.Calcular_Subtotal().ToString();
                df = new DetalleFactura();
            }
        }

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

        private void AplicarIdioma()
        {
            lbVender.Text = Rec.BtnVender;
            lbproducto.Text = Rec.Producto;
            lbcantidad.Text = Rec.Cantidad;
            BtnAgregar.Text = Rec.BtnAgregar;
            lbStock.Text = Rec.Stock;
            lbSubTtoal.Text = Rec.Subtotal;
            BtnSig.Text = Rec.Siguiente;
            dgvDetalle.Columns[0].HeaderText = Rec.NroProd;
            dgvDetalle.Columns[1].HeaderText = Rec.Nombre;
            dgvDetalle.Columns[2].HeaderText = Rec.Detalle;
            dgvDetalle.Columns[3].HeaderText = Rec.TipoProducto;
            dgvDetalle.Columns[4].HeaderText = Rec.UnidadMedida;
            dgvDetalle.Columns[5].HeaderText = Rec.Clasificacion;
            dgvDetalle.Columns[6].HeaderText = Rec.Cantidad;
            dgvDetalle.Columns[7].HeaderText = Rec.Precio;
            dgvDetalle.Columns[8].HeaderText = Rec.Total;
            dgvDetalle.Columns[9].HeaderText = Rec.Accion;


        }
    }
}