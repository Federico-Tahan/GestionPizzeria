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
                dgvProd.Rows.Add(c.IdFactura,c.cliente.NombreCompleto,c.Fecha,c.Forma_Compra.Forma_Compra,c.descuento.PorcentajeDescuento,"$" + facturacarga.Calcular_total());


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
                Det.Text = "Detalla Factura N°:" + facturaselected.IdFactura;
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
                Ticket.logotipo = Properties.Resources.Formaggio;
                Ticket.Empleado = "Vendedor: " +facturaselected.Usuario.Empleado.NombreCompleto;
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
    }
}
