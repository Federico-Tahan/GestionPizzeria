﻿using CapaCapaNegocio.Interfaces;
using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;
using CapaNegocio.Implementacion;
using CapaNegocio.Interfaces;
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
                cbocliente.Enabled = false;
                cbocliente.SelectedIndex = -1;
                cargar_cboCliente(cbocliente, "NombreCompleto", "IdCliente", 0);

            }
            else
            {
                lbDNI.Visible = false;
                txbDNI.Visible = false;
                btnverificar.Visible = false;
                cbocliente.Enabled = true;
                cargar_cboCliente(cbocliente, "NombreCompleto", "IdCliente", 1);

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
        private void cargar_cboCliente(ComboBox cbo, string display, string value,int con)
        {
            cbo.DataSource = cb.TraerClientesCbo(con);
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
        }
        private void ConfirmacionVenta_Load(object sender, EventArgs e)
        {
            cargar_cboTipOclIENTE(cboTipoCliente, "TipoCliente", "Id_TipoCliente");
            cargar_cboTipoEntrega(cbotipoentrega, "Forma_Entrega", "IdFormaEntrega");
            cargar_cboTipoCompra(cbotipocompra, "Forma_Compra", "IdFormaCompra");
            cargar_cboCliente(cbocliente, "NombreCompleto", "IdCliente",1);
            config = lg.TraerConfig();
            lclientes = lc.TraerClientes();
            cbocliente.SelectedIndex= -1;
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbocliente.SelectedValue) != 0)
            {
                clienteSelected = (Cliente)cbocliente.SelectedItem;
                if (validacion())
                {
                    FormaEntrega fe = new FormaEntrega();
                    FormaCompra fc = new FormaCompra();
                    if (tienedescuento)
                    {
                        fac.tieneDescuento = 0;
                    }
                    else { fac.tieneDescuento = 1; }
                    fac.FormaEntrega= fe;
                    fac.Forma_Compra= fc;
                    fac.cliente = clienteSelected;
                    fac.FormaEntrega.IdFormaEntrega = Convert.ToInt32(cbotipoentrega.SelectedValue);
                    fac.Usuario = LogIn.u;
                    fac.Forma_Compra.IdFormaCompra = Convert.ToInt32(cbotipocompra.SelectedValue);
                    if (lg.AltaVenta(fac))
                    {
                        if (MessageBox.Show("Venta realizada con Exito", "", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe cargar un cliente");
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
                            txbTotal.Text = (fac.Calcular_Subtotal() - ((fac.Calcular_Subtotal() * config.PorcentajeDescuentoHoy) / 100)).ToString();
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
                        txbTotal.Text = (fac.Calcular_Subtotal() - ((fac.Calcular_Subtotal() * config.PorcentajeDescuentoHoy) / 100)).ToString();
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
                        txbTotal.Text = (fac.Calcular_Subtotal() - ((fac.Calcular_Subtotal() * config.PorcentajeDescuentoHoy) / 100)).ToString();
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
                    txbTotal.Text = (fac.Calcular_Subtotal() - ((fac.Calcular_Subtotal() * config.PorcentajeDescuentoHoy) / 100)).ToString();
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
                CargarCliente(clienteSelected.socio.DNI);
                if (clienteSelected.socio.Baja_logica == 0)
                {
                    cargar_cboCliente(cbocliente, "NombreCompleto", "IdCliente", 0);
                    cbocliente.SelectedValue = clienteSelected.IdCliente;
                    CalcularTotal();
                }
                else
                {
                    MessageBox.Show("El DNI no pertenece a un Socio Activo.");
                }

            }
            else
            {
                MessageBox.Show("El DNI no pertenece a un Socio.");

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

        private void CargarCliente(long dni)
        {
            foreach (Cliente u in lclientes)
            {
                if (u.socio.DNI == dni)
                {
                    clienteSelected = u;
                    break;
                }
            }
        }

        private void cbocliente_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            clienteSelected = new Cliente();
            CalcularTotal();
            cbocliente.SelectedIndex = -1;
            txbDNI.Text = string.Empty;


        }

        private void cbocliente_SelectedIndexChanged(object sender, EventArgs e)
        {                
        }


        private bool validacion()
        {
            if (Convert.ToInt32(cbotipocompra.SelectedValue) == 0)
            {
                MessageBox.Show("Debe seleccionar un tipo de compra");
                return false;
            }
            else if (Convert.ToInt32(cbotipoentrega.SelectedValue) == 0)
            {
                MessageBox.Show("Debe seleccionar un tipo de entrega");

                return false;
            }
            else if (Convert.ToInt32(cboTipoCliente.SelectedValue) == 0)
            {
                MessageBox.Show("Debe seleccionar un tipo de cliente");

                return false;
            }
            else if (Convert.ToInt32(cbocliente.SelectedValue) == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente");

                return false;
            }
            return true;

        }
    }
}
