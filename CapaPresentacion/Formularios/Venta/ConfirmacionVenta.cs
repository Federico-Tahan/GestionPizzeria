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
        int modo;
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
            if (MessageBox.Show(Rec.BtnCerrarConfirmacionVenta, Rec.CapCerrar, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                label6.Visible = true;


            }
            else
            {
                lbDNI.Visible = false;
                txbDNI.Visible = false;
                btnverificar.Visible = false;
                label6.Visible = false;

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

            if (fac.IdFactura == 0)
            {
                modo = 0;
            }
            else
            {
                CargarDatos();
                modo = 1;
            }
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
                        Socio soc = new Socio();
                    Descuento d = new Descuento();
                        loc.idLocalidad = Convert.ToInt32(cboLocalidad.SelectedValue);
                        if (txbDNI.Visible)
                        {
                            soc.DNI = Convert.ToInt64(txbDNI.Text);
                        }
                        else
                        {
                        soc.DNI = 0;

                        }
                    if (tienedescuento)
                        {
                            fac.tieneDescuento = 0;
                        }
                        else { fac.tieneDescuento = 1; }
                        fac.FormaEntrega= fe;
                        fac.Forma_Compra= fc;
                        cliente.locali= loc;
                        if (txbtelefono.Text == string.Empty)
                        {
                        cliente.tel = 0;
                        }
                        else
                        {
                            cliente.tel = Convert.ToInt64(txbtelefono.Text);

                        }
                        cliente.Nombre = txbNombre.Text;
                        cliente.Apellido = txbApelldio.Text;
                        cliente.Direccion = txbCalle.Text;
                        cliente.Altura = Convert.ToInt32(nupAltura.Value);
                        cliente.Piso = Convert.ToInt32(nupPiso.Value);
                        cliente.Departamento = txDepto.Text;
                        cliente.socio = soc;
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
                        d.PorcentajeDescuento = Math.Round(Convert.ToDecimal(txbDescuento.Text), 2);
                        fac.descuento = d;
                      

                    if (modo ==0)
                        {
                            if (lg.AltaVenta(fac, LogIn.u))
                            {
                                if (MessageBox.Show(Rec.MessageVentaConExito, "", MessageBoxButtons.OK) == DialogResult.OK)
                                {
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                            }
                        }
                        else
                        {
                            if (lg.ModVenta(fac, LogIn.u))
                            {
                                if (MessageBox.Show(Rec.MessageModifyExito, "", MessageBoxButtons.OK) == DialogResult.OK)
                                {
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
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
                            txbDescuento.Text = Math.Round(config.PorcentajeDescuentoHoy, 2).ToString();
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
                        txbDescuento.Text = Math.Round(config.PorcentajeDescuentoHoy, 2).ToString();
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
                        txbDescuento.Text = Math.Round(config.PorcentajeDescuentoHoy, 2).ToString();
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
                    txbDescuento.Text = Math.Round(config.PorcentajeDescuentoHoy,2).ToString();
                    txbTotal.Text = Math.Round((fac.Calcular_Subtotal() - (fac.Calcular_Subtotal() * config.PorcentajeDescuentoHoy) / 100), 2).ToString();
                    tienedescuento = true;

                }
            }
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            if (!(txbDNI.Text.Length > 8))
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
                        txbtelefono.Text = clienteSelected.Telefono;
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
            else
            {
                MessageBox.Show(Rec.validacionDNI, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void cbotipocompra_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                CalcularTotal();

            }

        }

        private void cbotipoentrega_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                CalcularTotal();

            }
        }

        private void cbocliente_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            clienteSelected = new Cliente();
            if (modo == 0)
            {
                CalcularTotal();

            }
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
            else if (txbNombre.Text == string.Empty)
            {
                MessageBox.Show(Rec.MessageValidacionNombreCli);

                return false;
            }
            else if (txbApelldio.Text == string.Empty && label6.Visible == true)
            {
                MessageBox.Show(Rec.MessageValidacionApellidoCli);

                return false;
            }
            else if (Convert.ToInt32(cboLocalidad.SelectedValue) == 0)
            {
                MessageBox.Show(Rec.MessageSedebeCargarLoc  );

                return false;
            }
            if (txbNombre.Text.Length > 30)
            {
                MessageBox.Show(Rec.ValidacionLengNombre, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbApelldio.Text.Length > 30)
            {
                MessageBox.Show(Rec.ValidacionLengApellido, Rec.CapError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                if (txbtelefono.Text != string.Empty)
                {
                    Convert.ToInt64(txbtelefono.Text);

                }
            }
            catch(Exception e) 
            {
                MessageBox.Show(Rec.MessageValidacionTelefonoNumero);
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
            lbtelefono.Text = Rec.Telefono;
            lbcalle.Text = Rec.Calle;
            btnverificar.Text = Rec.BtnVerificar;
            lblocalidad.Text = Rec.localidad;
            lbaltura.Text = Rec.Altura;
            lbpiso.Text = Rec.Piso;
            lbdepartamento.Text = Rec.Departamento;
        }

        private void CargarDatos()
        {

            cboLocalidad.SelectedValue = fac.Locali.idLocalidad;
            if (fac.cliente.socio.DNI != 0)
            {
                cboTipoCliente.SelectedValue = 1;
                txbDNI.Visible = true;
                btnverificar.Visible = true;
            }
            else
            {
                cboTipoCliente.SelectedValue = 2;

            }
            cbotipocompra.SelectedValue = fac.Forma_Compra.IdFormaCompra;
            cbotipoentrega.SelectedValue = fac.FormaEntrega.IdFormaEntrega;
            txbNombre.Text = fac.cliente.Nombre;
            txbApelldio.Text = fac.cliente.Apellido;
            txbCalle.Text = fac.cliente.Direccion;
            txbDNI.Text = fac.cliente.socio.DNI.ToString();
            txDepto.Text = fac.cliente.Departamento;
            nupAltura.Value = fac.cliente.Altura;
            if (fac.cliente.tel == 0)
            {
                txbtelefono.Text = "";
            }
            else
            {
                txbtelefono.Text = fac.cliente.tel.ToString();

            }
            nupPiso.Value= fac.cliente.Piso;
            txbTotal.Text = fac.Calcular_total().ToString();
            txbDescuento.Text = fac.descuento.PorcentajeDescuento.ToString();
            txbSubtotal.Text = fac.Calcular_Subtotal().ToString();

        }

        private void txbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar < 0 || e.KeyChar > 127)
            {
                e.Handled = true;
            }
        }

        private void txbApelldio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar < 0 || e.KeyChar > 127)
            {
                e.Handled = true;
            }
        }

        private void txbCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar < 0 || e.KeyChar > 127)
            {
                e.Handled = true;
            }
        }

        private void txbDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbtelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
