using CapaCapaNegocio.Interfaces;
using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;
using CapaNegocio.Implementacion;
using CapaNegocio.Interfaces;
using CapaPresentacion.RecursoIdioma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Venta
{
    public partial class ConfirmacionVenta : Form
    {
        bool tienedescuento = false;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        ing_Cbos cb = new ng_Cbos();
        ing_CrudVentas lg = new ng_CrudVentas();
        ing_Cliente lc = new ng_Cliente();
        ing_Cbos lcbo = new ng_Cbos();

        List<Cliente> lclientes = new List<Cliente>();
        Cliente clienteSelected = new Cliente();
        Factura fac = new Factura();
        Configuracion config;
        public ConfirmacionVenta(Factura f)
        {
            InitializeComponent();
            fac = f;
            config = new Configuracion();
        }

        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cerrar Confirmacion de venta", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cboTipoCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (Convert.ToInt32(cboTipoCliente.SelectedValue) == 1)
            {
                lbDNI.Visible = true;
                txbDNI.Visible = true;
                btnverificar.Visible = true;

            }
            else
            {
                lbDNI.Visible = false;
                txbDNI.Visible = false;
                btnverificar.Visible = false;

            }                                                                               
        }

        private void cargar_cboTipOclIENTE(ComboBox cbo, string display, string value)
        {
            cbo.DataSource = cb.TipoClientes();
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;
        }
        private void cargar_cboTipoCompra(ComboBox cbo, string display, string value)
        {
            cbo.DataSource = cb.TipoCompra();
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;
        }
        private void cargar_cboTipoEntrega(ComboBox cbo, string display, string value)
        {
            cbo.DataSource = cb.TipoEntregas();
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;
        }

        private void ConfirmacionVenta_Load(object sender, EventArgs e)
        {
            DetectarIdioma();
            AplicarIdioma();
            cargar_cboTipOclIENTE(cboTipoCliente, "TipoCliente", "Id_TipoCliente");
            cargar_cboTipoEntrega(cbotipoentrega, "Forma_Entrega", "IdFormaEntrega");
            cargar_cboTipoCompra(cbotipocompra, "Forma_Compra", "IdFormaCompra");
            cargar_cboLocalidad(cboLocalidad, "NLocalidad", "idLocalidad");

            config = lg.TraerConfig();
            lclientes = lc.TraerClientes();
        }

        private void cargar_cboLocalidad(ComboBox cbo, string display, string value)
        {
            cbo.DataSource = lcbo.Localidad();
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo.SelectedIndex = -1;
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Rec.MessageConfirmarVenta,Rec.CapConfirmacion,MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                    if (validacion())
                    {
                        FormaEntrega fe = new FormaEntrega();
                        FormaCompra fc = new FormaCompra();
                        Localidad loc = new Localidad();
                        Cliente cliente = new Cliente();
                        loc.idLocalidad = Convert.ToInt32(cboLocalidad.SelectedValue);
                        if (tienedescuento)
                        {
                            fac.tieneDescuento = 0;
                        }
                        else { fac.tieneDescuento = 1; }
                        fac.FormaEntrega= fe;
                        fac.Forma_Compra= fc;
                        cliente.locali= loc;
                        cliente.Nombre = txbNombre.Text;
                        cliente.Apellido = txbApelldio.Text;
                        cliente.Direccion = txbCalle.Text;
                        cliente.Altura = Convert.ToInt32(nupAltura.Value);
                        cliente.Piso = Convert.ToInt32(nupPiso.Value);
                        cliente.Departamento = txDepto.Text;
                        if (txbDNI.Visible == true)
                        {
                            cliente.IdCliente = clienteSelected.IdCliente;
                        }
                        else
                        {
                            cliente.IdCliente = 0;
                        }
                        fac.cliente= cliente;
                        fac.FormaEntrega.IdFormaEntrega = Convert.ToInt32(cbotipoentrega.SelectedValue);
                        fac.Usuario = LogIn.u;
                        fac.Forma_Compra.IdFormaCompra = Convert.ToInt32(cbotipocompra.SelectedValue);
                        if (lg.AltaVenta(fac,LogIn.u))
                        {
                            if (MessageBox.Show(Rec.MessageVentaConExito, "", MessageBoxButtons.OK) == DialogResult.OK)
                            {
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                    }
            }
        }


        private void CalcularTotal()
        {
            if (config.DescuentoSocios == 0)
            {
                if (clienteSelected.socio.DNI != 0)
                {
                    if (config.DescuentoPresencial == 0)
                    {
                        if(Convert.ToInt32(cbotipocompra.SelectedValue) == 2)
                        {
                            txbSubtotal.Text = fac.Calcular_Subtotal().ToString();
                            txbDescuento.Text = config.PorcentajeDescuentoHoy.ToString();
                            txbTotal.Text = Math.Round((fac.Calcular_Subtotal() - (fac.Calcular_Subtotal() * config.PorcentajeDescuentoHoy) / 100),2).ToString();
                            tienedescuento = true;

                        }
                        else
                        {
                            txbSubtotal.Text = fac.Calcular_Subtotal().ToString();
                            txbDescuento.Text = 0.ToString();
                            txbTotal.Text = fac.Calcular_Subtotal().ToString();
                            tienedescuento = false;

                        }
                    }
                    else
                    {
                        txbSubtotal.Text = fac.Calcular_Subtotal().ToString();
                        txbDescuento.Text = config.PorcentajeDescuentoHoy.ToString();
                        txbTotal.Text = Math.Round((fac.Calcular_Subtotal() - (fac.Calcular_Subtotal() * config.PorcentajeDescuentoHoy) / 100),2).ToString();
                        tienedescuento = true;

                    }
                }
                else
                {
                    txbSubtotal.Text = fac.Calcular_Subtotal().ToString();
                    txbDescuento.Text = 0.ToString();
                    txbTotal.Text = fac.Calcular_Subtotal().ToString();
                    tienedescuento = false;


                }
            }
            else
            {
                if(config.DescuentoPresencial == 0)
                    {
                    if (Convert.ToInt32(cbotipocompra.SelectedValue) == 2)
                    {
                        txbSubtotal.Text = fac.Calcular_Subtotal().ToString();
                        txbDescuento.Text = config.PorcentajeDescuentoHoy.ToString();
                        txbTotal.Text = Math.Round((fac.Calcular_Subtotal() - (fac.Calcular_Subtotal() * config.PorcentajeDescuentoHoy) / 100), 2).ToString();
                        tienedescuento = true;
                    }
                    else
                    {
                        txbSubtotal.Text = fac.Calcular_Subtotal().ToString();
                        txbDescuento.Text = 0.ToString();
                        txbTotal.Text = fac.Calcular_Subtotal().ToString();
                        tienedescuento = false;

                    }
                }
                    else
                {
                    txbSubtotal.Text = fac.Calcular_Subtotal().ToString();
                    txbDescuento.Text = config.PorcentajeDescuentoHoy.ToString();
                    txbTotal.Text = Math.Round((fac.Calcular_Subtotal() - (fac.Calcular_Subtotal() * config.PorcentajeDescuentoHoy) / 100), 2).ToString();
                    tienedescuento = true;

                }
            }
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            clienteSelected = new Cliente();
            clienteSelected.socio.DNI = Convert.ToInt64(txbDNI.Text);
            if (lg.BuscarClienteSocioDni(clienteSelected))
            {
                cb.TraerClientesCbo(clienteSelected.socio.DNI, clienteSelected);
                if (clienteSelected.socio.Baja_logica == 0)
                {
                    txbNombre.Text = clienteSelected.Nombre;
                    txbApelldio.Text = clienteSelected.Apellido;
                    txbCalle.Text = clienteSelected.Direccion;
                    nupAltura.Value = clienteSelected.Altura;
                    nupPiso.Value = clienteSelected.Piso;
                    txDepto.Text = clienteSelected.Departamento;
                    cboLocalidad.SelectedValue = clienteSelected.locali.idLocalidad;
                    CalcularTotal();
                }
                else
                {
                    MessageBox.Show(Rec.MessageDniNoperteneceSocioActivo);
                }

            }
            else
            {
                MessageBox.Show(Rec.MessageDNInopertenece);

            }
        }

        private void cbotipocompra_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void cbotipoentrega_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void cbocliente_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            clienteSelected = new Cliente();
            CalcularTotal();
            txbDNI.Text = string.Empty;


        }

        private void cbocliente_SelectedIndexChanged(object sender, EventArgs e)
        {                
        }


        private bool validacion()
        {
            if (Convert.ToInt32(cbotipocompra.SelectedValue) == 0)
            {
                MessageBox.Show(Rec.MessageValidacionTipoCOmpra);
                return false;
            }
            else if (Convert.ToInt32(cbotipoentrega.SelectedValue) == 0)
            {
                MessageBox.Show(Rec.MessageValidacionTipoENTREGA);

                return false;
            }
            else if (Convert.ToInt32(cboTipoCliente.SelectedValue) == 0)
            {
                MessageBox.Show(Rec.MessageValidacionTipoCliente);

                return false;
            }
            return true;

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
            lbtipocompra.Text = Rec.TipodeCompra;
            lbTCliente.Text = Rec.TipodeCliente;
            lbTipodeEntrega.Text = Rec.TipodeEntrega;
            lbDNI.Text = Rec.DNI;
            btnConfirmarVenta.Text = Rec.ConfirmarVenta;
            lbconcretar.Text = Rec.ConcretarVenta;
            lbnombre.Text = Rec.Nombre;
            lbapellido.Text = Rec.Apellido;

            lbcalle.Text = Rec.Calle;
            btnverificar.Text = Rec.BtnVerificar;
            lblocalidad.Text = Rec.localidad;
            lbaltura.Text = Rec.Altura;
            lbpiso.Text = Rec.Piso;
            lbdepartamento.Text = Rec.Departamento;
        }
    }
}
