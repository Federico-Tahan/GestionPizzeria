using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;
using CapaNegocio.Implementacion;
using CapaNegocio.Interfaces;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ticket_o_factura;
using CapaPresentacion.RecursoIdioma;

namespace CapaPresentacion.Formularios.Venta
{
    public partial class ConsultaVentas : Form
    {
        ing_CrudVentas lg = new ng_CrudVentas();
        List<Factura> lFacturas = new List<Factura>();
        Factura facturaselected = new Factura();
        Factura facturacarga = new Factura();

        public ConsultaVentas()
        {
            InitializeComponent();
        }

        private void BtntICKET_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaVentas_Load(object sender, EventArgs e)
        {
            lFacturas = lg.TraerFactura();
            cargarDgv();
            DetectarIdioma();
            AplicarIdioma();
        }

        private void cargarDgv()
        {
            dgvProd.Rows.Clear();

            foreach (Factura c in lFacturas)
            {
                facturacarga.DetalleFacturas = lg.TraerDetalles(c.IdFactura);
                Descuento d = new Descuento();
                d.PorcentajeDescuento = c.descuento.PorcentajeDescuento;
                facturacarga.descuento = d;
                dgvProd.Rows.Add(c.IdFactura,c.cliente.NombreCompleto,c.Fecha,c.Forma_Compra.Forma_Compra,c.Usuario.Empleado.NombreCompleto,c.descuento.PorcentajeDescuento,"$" + facturacarga.Calcular_total());


            }
        }
        private void cargarDgvDet()
        {
            dgvDetalle.Rows.Clear();

            foreach (DetalleFactura c in facturaselected.DetalleFacturas)
            {
                dgvDetalle.Rows.Add(c.Prod.Id_producto,c.Prod.Nombre,c.Descripcion,c.Prod.Tipo_producto.Tipo_producto,c.Prod.Unidadmedida.Unidad_Medida,c.Prod.clasificacion.clasificacion,
                    c.Cantidad,c.Precio, c.Cantidad * c.Precio);


            }
        }

        private void dgvProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProd.Columns[e.ColumnIndex].Name == "Accion")
            {
                CargarFactura(Convert.ToInt32(dgvProd.CurrentRow.Cells[0].Value));
                facturaselected.DetalleFacturas = lg.TraerDetalles(facturaselected.IdFactura);
                cargarDgvDet();
                lbAltura.Text = facturaselected.cliente.Altura.ToString();
                lbPiso.Text = facturaselected.cliente.Piso.ToString();
                lbCalle.Text = facturaselected.cliente.Direccion;
                lbLocalidad.Text = facturaselected.cliente.locali.NLocalidad;
                lbDepartamento.Text = facturaselected.cliente.Departamento;
                Det.Text = Rec.DetalleFacturaN +" " +facturaselected.IdFactura;
                panel1.Visible = true;

            }
            else if (dgvProd.Columns[e.ColumnIndex].Name == "Ticket")
            {
                CargarFactura(Convert.ToInt32(dgvProd.CurrentRow.Cells[0].Value));
                facturaselected.DetalleFacturas = lg.TraerDetalles(facturaselected.IdFactura);
                crearTicket Ticket = new crearTicket();
                Ticket.Descuento = facturaselected.descuento.PorcentajeDescuento.ToString();
                Ticket.Subtotal = facturaselected.Calcular_Subtotal().ToString();
                Ticket.Total = facturaselected.Calcular_total().ToString();
                Ticket.Fecha = "Fecha de Compra: " + facturaselected.Fecha.ToShortDateString();
                Ticket.Hora = "Hora de Compra: " + facturaselected.Fecha.Hour +":" + facturaselected.Fecha.Minute + ":" +facturaselected.Fecha.Second;
                Ticket.listaProducto = facturaselected.DetalleFacturas;
                Ticket.logotipo = Properties.Resources.LogoTest;
                Ticket.Empleado = "Vendedor: " +facturaselected.Usuario.Empleado.NombreCompleto;
                Ticket.InfoCuit = "                                               Hai Pianto SRL 20-39123943-7";
                Ticket.NroFac = "Nro de Factura: "+ facturaselected.IdFactura.ToString();
                Ticket.imprimir(Ticket);

            }
        }

        private void CargarFactura(int c)
        {
            foreach (Factura u in lFacturas)
            {
                if (u.IdFactura == c)
                {
                    facturaselected = u;
                    break;
                }
            }
        }

        private void BtnVovler_Click(object sender, EventArgs e)
        {
            dgvDetalle.Rows.Clear();
            panel1.Visible = false;
            facturaselected = new Factura();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            lFacturas = lg.TraerFactura();
            cargarDgv();
            if (RbtCodigo.Checked)
            {
                if (txbbusqueda.Text != "")
                {
                    try
                    {
                        Convert.ToInt32(txbbusqueda.Text);
                        List<DataGridViewRow> temp = new List<DataGridViewRow>();

                        foreach (DataGridViewRow row in dgvProd.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["Nroventa"].Value) != Convert.ToInt32(txbbusqueda.Text))
                            {
                                temp.Add(row);
                            }

                        }

                        foreach (DataGridViewRow row in temp)
                        {

                            dgvProd.Rows.Remove(row);

                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(Rec.MessageCargarCodigoParafiltrar);

                    }
                }
                else
                {
                    MessageBox.Show(Rec.MessageCargarCodigoParafiltrar);
                }
            }
        }

        private void picreset_Click(object sender, EventArgs e)
        {
            lFacturas = lg.TraerFactura();
            cargarDgv();
        }


        private void AplicarIdioma()
        {
            lbVentas.Text = Rec.Ventas;
            RbtCodigo.Text = Rec.NroFactura;
            BtnBuscar.Text = Rec.Aplicar;
            dgvProd.Columns[0].HeaderText = Rec.NroFactura;
            dgvProd.Columns[1].HeaderText = Rec.NombreCliente;
            dgvProd.Columns[2].HeaderText = Rec.Fecha;
            dgvProd.Columns[3].HeaderText = Rec.FormaDePedido;
            dgvProd.Columns[4].HeaderText = Rec.DGVNombreVendedor;
            dgvProd.Columns[5].HeaderText = Rec.Descuento;
            dgvProd.Columns[6].HeaderText = Rec.Total;
            dgvProd.Columns[7].HeaderText = Rec.Ticket;
            dgvProd.Columns[8].HeaderText = Rec.Accion;
            dgvDetalle.Columns[0].HeaderText = Rec.NroProd;
            dgvDetalle.Columns[1].HeaderText = Rec.Nombre;
            dgvDetalle.Columns[2].HeaderText = Rec.Detalle;
            dgvDetalle.Columns[3].HeaderText = Rec.TipoProducto;
            dgvDetalle.Columns[4].HeaderText = Rec.UnidadMedida;
            dgvDetalle.Columns[5].HeaderText = Rec.Clasificacion;
            dgvDetalle.Columns[6].HeaderText = Rec.Cantidad;
            dgvDetalle.Columns[7].HeaderText = Rec.Precio;
            dgvDetalle.Columns[8].HeaderText = Rec.Importe;
            BtnVovler.Text = Rec.Volver;
            Det.Text = Rec.DetalleFacturaN;

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

        private void BtnCancelarVenta_Click(object sender, EventArgs e)
        {

        }
    }
}
