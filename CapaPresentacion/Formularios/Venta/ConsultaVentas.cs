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
using Microsoft.CodeAnalysis.Operations;

namespace CapaPresentacion.Formularios.Venta
{
    public partial class ConsultaVentas : Form
    {
        ing_CrudVentas lg = new ng_CrudVentas();
        List<Factura> lFacturas = new List<Factura>();
        Factura facturaselected = new Factura();
        Factura facturacarga = new Factura();
        List<Producto> LproductosVenta = new List<Producto>();
        List<Producto> LProductosCargados = new List<Producto>();
        List<Producto> LCombinada = new List<Producto>();
        Producto productoSelected = new Producto();
        Factura f = new Factura();
        DetalleFactura df = new DetalleFactura();



        ing_CrudProductos lgprod = new ng_CrudProductos();
        public ConsultaVentas()
        {
            InitializeComponent();
        }

        private void BtntICKET_Click(object sender, EventArgs e)
        {

        }
        //trae todas las facturas, dependiendo el rol permite visiblidad de cosas, y aplica cambio de idioma
        private void ConsultaVentas_Load(object sender, EventArgs e)
        {
            TraerFacturas();
            DetectarIdioma();
            AplicarIdioma();
            RolCancelarMod();
            AplicarRol();
        }
        //carga dgv de facturas
        private void cargarDgv()
        {
            dgvProd.Rows.Clear();

            foreach (Factura c in lFacturas)
            {
                facturacarga.DetalleFacturas = lg.TraerDetalles(c.IdFactura);
                Descuento d = new Descuento();
                d.PorcentajeDescuento = c.descuento.PorcentajeDescuento;
                facturacarga.descuento = d;
                string dni = "";
                string tel = "";

                if (c.cliente.socio.DNI != 0)
                {
                    dni = c.cliente.socio.DNI.ToString();
                }
                if (c.cliente.tel != 0)
                {
                    tel = c.cliente.tel.ToString();
                }

                if (c.BajaLogica == 0)
                {
                    dgvProd.Rows.Add(c.IdFactura, c.cliente.NombreCompleto, c.Fecha.ToShortDateString(),dni,tel, c.Forma_Compra.Forma_Compra, c.Usuario.Empleado.NombreCompleto, c.descuento.PorcentajeDescuento, "$" + facturacarga.Calcular_total());

                }
                else
                {
                    dgvProd.Rows.Add(c.IdFactura, c.cliente.NombreCompleto, c.Fecha.ToShortDateString(), dni,tel, c.Forma_Compra.Forma_Compra, c.Usuario.Empleado.NombreCompleto, c.descuento.PorcentajeDescuento, "$" + facturacarga.Calcular_total(), Rec.cancelada);

                }


            }
        }
        //carga dgv de detalle de facturas

        private void cargarDgvDet()
        {
            dgvDetalle.Rows.Clear();

            foreach (DetalleFactura c in facturaselected.DetalleFacturas)
            {
                dgvDetalle.Rows.Add(c.Prod.Id_producto,c.Prod.Nombre,c.Descripcion,c.Prod.Tipo_producto.Tipo_producto,c.Prod.Unidadmedida.Unidad_Medida,c.Prod.clasificacion.clasificacion,
                    c.Cantidad,c.Precio, c.Cantidad * c.Precio);


            }
        }
        //DGV FACTURA!, si presiona accion cargara todos los datos en el panel siguiente mostrando los datos de la factura y detalles de esta, permitiendo dependiendo el rol
        // y el estado modificarla y cancelarla

        //si se presiona TICKET, se formara una factura con los datos de la factura permitiendo imprimirla 
        private void dgvProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProd.Columns[e.ColumnIndex].Name == "Accion" && dgvProd.Rows.Count !=0)
            {
                CargarFactura(Convert.ToInt32(dgvProd.CurrentRow.Cells[0].Value));
                facturaselected.DetalleFacturas = lg.TraerDetalles(facturaselected.IdFactura);
                f.DetalleFacturas = facturaselected.DetalleFacturas;

                cargarDgvDet();
                txbStock.Text = "";
                lbAltura.Text = facturaselected.cliente.Altura.ToString();
                lbPiso.Text = facturaselected.cliente.Piso.ToString();
                lbCalle.Text = facturaselected.cliente.Direccion;
                lbLocalidad.Text = facturaselected.cliente.locali.NLocalidad;
                if (facturaselected.cliente.socio.DNI == 0)
                {
                    labdni.Text = "";

                }
                else
                {
                    labdni.Text = facturaselected.cliente.socio.DNI.ToString();

                }
                lbname.Text = facturaselected.cliente.NombreCompleto;
                label5labformaentrega.Text = facturaselected.FormaEntrega.Forma_Entrega;
                labtipocompra.Text = facturaselected.Forma_Compra.Forma_Compra;
                lbDepartamento.Text = facturaselected.cliente.Departamento;
                labtelefono.Text = facturaselected.cliente.tel.ToString();
                Det.Text = Rec.DetalleFacturaN +" " +facturaselected.IdFactura;
                if (facturaselected.BajaLogica == 0)
                {
                    BtnCancelarVenta.Visible = true;
                    BtnMod.Visible = true;
                }
                else
                {
                    BtnCancelarVenta.Visible = false;
                    BtnMod.Visible = false;
                }
                panel1.Visible = true;
                RolCancelarMod();


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
                Ticket.Empleado = facturaselected.Usuario.Empleado.NombreCompleto;
                Ticket.NombreEmpresa = "                                                                                           Hai Pianto SRL";
                Ticket.Cuit = "                                                                                          20-39123943-7";
                Ticket.NroFac = facturaselected.IdFactura.ToString();
                Ticket.Localidad = facturaselected.Locali.NLocalidad;
                Ticket.Nombre = facturaselected.cliente.Nombre + " " + facturaselected.cliente.Apellido;
                Ticket.TipoCommpra = facturaselected.Forma_Compra.Forma_Compra;
                Ticket.FomraEntrega = facturaselected.FormaEntrega.Forma_Entrega;
                Ticket.Departamento = facturaselected.cliente.Departamento.ToString();
                Ticket.Piso = facturaselected.cliente.Piso.ToString();
                Ticket.Calle = facturaselected.cliente.Direccion;
                Ticket.Telefono = facturaselected.cliente.tel.ToString();
                Ticket.Altura = facturaselected.cliente.Altura.ToString();

                if (facturaselected.cliente.socio.DNI != 0)
                {
                    Ticket.DNI = facturaselected.cliente.socio.DNI.ToString();
                }

                Ticket.imprimir(Ticket);

            }
        }
        //carga cbo de productos
        private void cargar_cboProductos(ComboBox cbo, string display, string value)
        {
            cbo.DataSource = LProductosCargados;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        //combina la lista de los producots activos con la lista de los productos comprados y su stock, para poder realizar una modificacion 
        private void CombinarListas()
        {
            LProductosCargados = new List<Producto>();
            foreach (Producto item in LproductosVenta)
            {
                LProductosCargados.Add(item);
            }
            foreach (DetalleFactura item in facturaselected.DetalleFacturas)
            {
                bool encontrado = false;

                foreach (Producto prodList in LproductosVenta)
                {
                    if (item.Prod.Id_producto == prodList.Id_producto)
                    {
                        prodList.Stock += item.Cantidad;
                        encontrado = true;
                        break;
                    }
                    else
                    {
                        encontrado = false;
                    }
                }
                if(encontrado is false)
                {
                    item.Prod.Stock = item.Cantidad;
                    LProductosCargados.Add(item.Prod);
                }
            }
            cargar_cboProductos(cboProductos, "Nombre", "Id_producto");

        }
        //carga la factura seleccionada a un objeto
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
        //vuelve y limpia datos
        private void BtnVovler_Click(object sender, EventArgs e)
        {
            dgvDetalle.Rows.Clear();
            panel1.Visible = false;
            facturaselected = new Factura();
        }
        //permite realizar filtro de busqueda dependiendo la seleccion
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            TraerFacturas();
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
            }else if (RbtVendedor.Checked)
            {
                try
                {
                    Convert.ToString(txbbusqueda.Text);
                    List<DataGridViewRow> temp = new List<DataGridViewRow>();

                    foreach (DataGridViewRow row in dgvProd.Rows)
                    {
                        if (Convert.ToString(row.Cells["Vendedor"].Value) != Convert.ToString(txbbusqueda.Text))
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
        //permite reinciar estos filtros
        private void picreset_Click(object sender, EventArgs e)
        {
            TraerFacturas();
        }
        //aplica idioma 

        private void AplicarIdioma()
        {
            lbVentas.Text = Rec.Ventas;
            RbtVendedor.Text = Rec.NroFactura;
            BtnBuscar.Text = Rec.Aplicar;
            lbNombre.Text = Rec.Nombre;
            lbDNI.Text = Rec.DNI;
            lbTipoCompra.Text = Rec.TipodeCompra;
            lbTipoEntrega.Text = Rec.TipodeEntrega;
            lbtel.Text = Rec.Telefono;
            dgvProd.Columns[0].HeaderText = Rec.NroFactura;
            dgvProd.Columns[1].HeaderText = Rec.NombreCliente;
            dgvProd.Columns[2].HeaderText = Rec.Fecha;
            dgvProd.Columns[3].HeaderText = Rec.DNI;
            dgvProd.Columns[4].HeaderText = Rec.Telefono;

            dgvProd.Columns[5].HeaderText = Rec.FormaDePedido;
            dgvProd.Columns[6].HeaderText = Rec.DGVNombreVendedor;
            dgvProd.Columns[7].HeaderText = Rec.Descuento;
            dgvProd.Columns[8].HeaderText = Rec.Total;
            dgvProd.Columns[9].HeaderText = Rec.Estado;

            dgvProd.Columns[10].HeaderText = Rec.Ticket;
            dgvProd.Columns[11].HeaderText = Rec.Accion;
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
            lbloc.Text = Rec.localidad + ":";
            lbCal.Text = Rec.Calle + ":";
            lbalt.Text = Rec.Altura+":";
            lbpis.Text = Rec.Piso + ":";
            lbdpto.Text = Rec.Departamento + ":";
            BtnCancelarVenta.Text = Rec.BtnCancelarVenta;

            lvmodificarventa.Text = Rec.BtnModificarVenta;
            lbproducto.Text = Rec.Producto;
            lbcantidad.Text = Rec.Cantidad;
            BtnAgregar.Text = Rec.BtnAgregar;
            lbStock.Text = Rec.Stock;
            lbSubTtoal.Text = Rec.Subtotal;
            BtnSig.Text = Rec.Siguiente;
            lbDetalle.Text = Rec.Detalle;
            dgvdet.Columns[0].HeaderText = Rec.NroProd;
            dgvdet.Columns[1].HeaderText = Rec.Nombre;
            dgvdet.Columns[2].HeaderText = Rec.Detalle;
            dgvdet.Columns[3].HeaderText = Rec.TipoProducto;
            dgvdet.Columns[4].HeaderText = Rec.UnidadMedida;
            dgvdet.Columns[5].HeaderText = Rec.Clasificacion;
            dgvdet.Columns[6].HeaderText = Rec.Cantidad;
            dgvdet.Columns[7].HeaderText = Rec.Precio;
            dgvdet.Columns[8].HeaderText = Rec.Total;
            dgvdet.Columns[9].HeaderText = Rec.Accion;
            BtnMod.Text = Rec.BtnModificarVenta;
            BtnSig.Text = Rec.Siguiente;
            RbtVendedor.Text = Rec.DGVNombreVendedor;

            RbtCodigo.Text = Rec.NroFactura;
        }
        //detecta el idioma
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
        //cancel ala venta y restablece el stock de esta
        private void BtnCancelarVenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Rec.CancelarVenta,"",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (lg.CancelarVenta(facturaselected.IdFactura,LogIn.u))
                {
                    MessageBox.Show(Rec.VentaCancelada);
                    dgvDetalle.Rows.Clear();
                    TraerFacturas();
                    panel1.Visible = false;
                    facturaselected = new Factura();
                }
            }
        }

        //cambia el idioma de los botones de dgv de facutra
        private void dgvProd_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProd.Columns[e.ColumnIndex].Name == "Accion")
            {
                // Obtener el valor de la celda
                object value = e.Value;

                if (SeleccionIdioma.i.IdIdioma == 2)
                {
                    // Comprobar el valor y establecer el texto del botón en consecuencia
                    if (value != null && value.ToString() == "accion")
                    {
                        e.Value = "Details";
                    }
                    else
                    {
                        e.Value = "Details";
                    }
                }

            }

            if (dgvProd.Columns[e.ColumnIndex].Name == "Ticket")
            {
                // Obtener el valor de la celda
                object value = e.Value;

                if (SeleccionIdioma.i.IdIdioma == 2)
                {
                    // Comprobar el valor y establecer el texto del botón en consecuencia
                    if (value != null && value.ToString() == "Ticket")
                    {
                        e.Value = "Print";
                    }
                    else
                    {
                        e.Value = "Print";
                    }
                }

            }
        }

        //permite la modificacion de la venta si es que esta disponible para esta facutra
        private void BtnMod_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel1.Visible = false;
            facturaselected.DetalleFacturas = lg.TraerDetalles(facturaselected.IdFactura);
            f.DetalleFacturas = facturaselected.DetalleFacturas;
            LproductosVenta = lgprod.GetProductos(3);
            CombinarListas();
            CargarDgvVenta();
            txbStock.Text = "";
            txbTotal.Text = f.Calcular_Subtotal().ToString();




        }
        //actualiza el producto y el stock del cbo producots

        private void cboProductos_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboProductos.SelectedIndex != -1)
                {
                    CargarProductoSelected(Convert.ToInt32(cboProductos.SelectedValue));
                    txbStock.Text = productoSelected.Stock.ToString();
                }
            }
            catch (Exception ex) { }
        }
        //actualiza el producto y el stock del cbo producots

        private void cboProductos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboProductos.SelectedIndex != -1)
            {
                CargarProductoSelected(Convert.ToInt32(cboProductos.SelectedValue));
                txbStock.Text = productoSelected.Stock.ToString();
            }
        }
        //carga el producto seleccionado a un objeto
        private void CargarProductoSelected(int id)
        {
            productoSelected = new Producto();
            foreach (Producto u in LProductosCargados)
            {
                if (u.Id_producto == id)
                {
                    productoSelected = u;
                    break;
                }
            }
        }
        //valida que stock este dentro del margen, datos del producto esten correctos
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
        //carga el dgv  de la modificacion de la venta con los productos adquiridos
        private void CargarDgvVenta()
        {
            dgvdet.Rows.Clear();

            foreach (DetalleFactura com in f.DetalleFacturas)
            {
                dgvdet.Rows.Add(com.Prod.Id_producto, com.Prod.Nombre, com.Descripcion, com.Prod.Tipo_producto.Tipo_producto,
                    com.Prod.Unidadmedida.Unidad_Medida, com.Prod.clasificacion.clasificacion, com.Cantidad, "$ " + com.Precio,
                    "$ " + com.Cantidad * com.Precio);
            }
        }

        //valida que el stock ingresado este dentro del margen
        private bool validacionStock()
        {
            if (Convert.ToInt32(numpCantidad.Value) > productoSelected.Stock)
            {
                MessageBox.Show(Rec.MessageNohaySuficienteStock);
                return false;
            }
            else if (Convert.ToInt32(numpCantidad.Value) == 0)
            {
                MessageBox.Show(Rec.MessageAgregaralemnosun);
                return false;
            }
            return true;
        }
        //abstrae el detalle
        private void AbstraerDetalle()
        {
            df = new DetalleFactura();
            df.Descripcion = txbDetalle.Text;
            df.Prod = productoSelected;
            df.Precio = productoSelected.Precio;
            df.Cantidad = Convert.ToInt32(numpCantidad.Value);

        }
        //remove el producto seleccionado de la dgv y lista y actualiza totales
        private void dgvdet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            df = new DetalleFactura();
            if (dgvdet.Columns[e.ColumnIndex].Name == "action" && dgvdet.Rows.Count != 0)
            {
                CargarDetalleSelected(Convert.ToInt32(dgvdet.CurrentRow.Cells[0].Value));
                f.remover(df);
                dgvdet.Rows.Remove(dgvdet.CurrentRow);
                txbTotal.Text = f.Calcular_Subtotal().ToString();
                df = new DetalleFactura();
            }
        }
        //carga el detalle seleccionado en objeto
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
        //verifica que todos los datos esten correcots para continuar con la  venta
        private void BtnSig_Click(object sender, EventArgs e)
        {
            if (f.DetalleFacturas.Count != 0)
            {
                f.IdFactura = facturaselected.IdFactura;
                f.Fecha= facturaselected.Fecha;
                f.Usuario = facturaselected.Usuario;
                f.cliente = facturaselected.cliente;
                f.FormaEntrega = facturaselected.FormaEntrega;
                f.Forma_Compra = facturaselected.Forma_Compra;
                f.descuento = facturaselected.descuento;
                f.Locali = facturaselected.Locali;
                ConfirmacionVenta form = new ConfirmacionVenta(f);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    f = new Factura();
                    productoSelected = new Producto();
                    df = new DetalleFactura();
                    LproductosVenta = new List<Producto>();
                    LProductosCargados = new List<Producto>();
                    LCombinada = new List<Producto>();
                    dgvProd.Rows.Clear();
                    f.DetalleFacturas.Clear();
                    dgvDetalle.Rows.Clear();
                    numpCantidad.Value = 0;
                    txbDetalle.Text = "";
                    LproductosVenta = lgprod.GetProductos(3);
                    CombinarListas();
                    cargar_cboProductos(cboProductos, "Nombre", "Id_producto");
                    cboProductos.SelectedIndex = -1;
                    txbStock.Text = "";
                    txbTotal.Text = "";
                    panel1.Visible = false;
                    panel3.Visible = false;
                    TraerFacturas();
                }

            }
            else
            {
                MessageBox.Show(Rec.MessageCargaralmenosunprod);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            LproductosVenta = new List<Producto>();
            LProductosCargados = new List<Producto>();
            LCombinada = new List<Producto>();
            productoSelected = new Producto();
            f = new Factura();
            df = new DetalleFactura();
            txbTotal.Text = "";
            txbStock.Text = "";
            panel1.Visible = true;

        }

        //cambia idioma de los botones la dgv
        private void dgvdet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvdet.Columns[e.ColumnIndex].Name == "action")
            {
                // Obtener el valor de la celda
                object value = e.Value;

                if (SeleccionIdioma.i.IdIdioma == 2)
                {
                    // Comprobar el valor y establecer el texto del botón en consecuencia
                    if (value != null && value.ToString() == "action")
                    {
                        e.Value = "Remove";
                    }
                    else
                    {
                        e.Value = "Remove";
                    }
                }

            }
        }
        //dependiendo el rol aplica visibilidad
        private void RolCancelarMod()
        {
            if (LogIn.u.Rol.Id_Rol != 1 && LogIn.u.Rol.Id_Rol != 3 && LogIn.u.Rol.Id_Rol != 5 )
            {
                BtnCancelarVenta.Visible = false;
                BtnMod.Visible = false;
            }
        }
        //trae las facturas de solo los usuarios que sean solo vendedores, o de todos dependiendo el rol
        private void TraerFacturas()
        {
            if (LogIn.u.Rol.Id_Rol == 6)
            {
                lFacturas = lg.TraerFactura(LogIn.u.ID_Usuario);
                cargarDgv();
            }
            else
            {
                lFacturas = lg.TraerFactura(0);
                cargarDgv();
            }
        }
        //dependiendo el rol aplica visibilidad

        private void AplicarRol()
        {
            if (LogIn.u.Rol.Id_Rol != 1 && LogIn.u.Rol.Id_Rol != 3 && LogIn.u.Rol.Id_Rol != 5 && LogIn.u.Rol.Id_Rol != 2)
            {
                RbtVendedor.Visible = false;
            }
        }
    }
}
