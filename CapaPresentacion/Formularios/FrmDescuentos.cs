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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class FrmDescuentos : Form
    {
        ing_Configuracion lg = new ng_Configuracion();
        List<Descuento> ld = new List<Descuento>();
        Configuracion c = new Configuracion();
        public FrmDescuentos()
        {
            InitializeComponent();
        }

        private void pnlDescento_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Descuentos_Load(object sender, EventArgs e)
        {
            ld = lg.TraerDescuentos();
            c = lg.TraerConfiguracion();
            cargarConfiguracion();
            DetectarIdioma();
            AplicarIdioma();
        }

        private void cargarConfiguracion()
        {
            np1.Value = ld[0].PorcentajeDescuento;
            np2.Value = ld[1].PorcentajeDescuento;
            np3.Value = ld[2].PorcentajeDescuento;
            np4.Value = ld[3].PorcentajeDescuento;
            np5.Value = ld[4].PorcentajeDescuento;
            np6.Value = ld[5].PorcentajeDescuento;
            np7.Value = ld[6].PorcentajeDescuento;
            ld.Clear();

            if (c.DescuentoSocios == 1)
            {
                chkSocio.Checked = false;
            }
            else
            {
                chkSocio.Checked = true;

            }

            if (c.DescuentoPresencial == 1)
            {
                ChkCompraspresenciales.Checked = false;
            }
            else
            {
                ChkCompraspresenciales.Checked = true;

            }
        }

        private void BtnRestablecer_Click(object sender, EventArgs e)
        {
            ld = lg.TraerDescuentos();
            c = lg.TraerConfiguracion();
            cargarConfiguracion();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            List<Descuento> lDescuento = new List<Descuento>();

            AbstraerInfo(lDescuento);
            if (lg.ActualizarDescuentosConfig(lDescuento, c))
            {
                MessageBox.Show(Rec.MessageDescuentoActualizado);
                ld = lg.TraerDescuentos();
                c = lg.TraerConfiguracion();
                cargarConfiguracion();
            }
        }

        public void AbstraerInfo(List<Descuento> lDescuento)
        {
            lDescuento.Clear();
            Descuento d = new Descuento();
            c = new Configuracion();
            d.PorcentajeDescuento = Convert.ToInt32(np1.Value);
            lDescuento.Add(d);
            d = new Descuento();

            d.PorcentajeDescuento = Convert.ToInt32(np2.Value);
            lDescuento.Add(d); d = new Descuento();

            d.PorcentajeDescuento = Convert.ToInt32(np3.Value);
            lDescuento.Add(d); d = new Descuento();

            d.PorcentajeDescuento = Convert.ToInt32(np4.Value);
            lDescuento.Add(d); d = new Descuento();

            d.PorcentajeDescuento = Convert.ToInt32(np5.Value);
            lDescuento.Add(d); d = new Descuento();

            d.PorcentajeDescuento = Convert.ToInt32(np6.Value);
            lDescuento.Add(d); d = new Descuento();

            d.PorcentajeDescuento = Convert.ToInt32(np7.Value);
            lDescuento.Add(d); d = new Descuento();


            if (chkSocio.Checked == false)
            {
                c.DescuentoSocios = 1;
            }
            else
            {
                c.DescuentoSocios = 0;

            }

            if (ChkCompraspresenciales.Checked == false)
            {
                c.DescuentoPresencial = 1;
            }
            else
            {
                c.DescuentoPresencial = 0;

            }
        }

        public void AplicarIdioma()
        {
            lblunes.Text = Rec.Lunes;
            lbMartes.Text = Rec.Martes;
            lbMiercoles.Text = Rec.Miercoles;
            lbJueves.Text = Rec.Jueves;
            lbViernes.Text = Rec.Viernes;
            lbSabado.Text = Rec.Sabado;
            lbDomingo.Text = Rec.Domingo;
            lbdescuento.Text = Rec.Descuento;
            lbdescuentosdelasemana.Text = Rec.DescuentodelaSemana;
            lbobtencion.Text = Rec.ObtenciondelBeneficio;
            BtnConfirmar.Text = Rec.Confirmar;
            BtnRestablecer.Text = Rec.Restablecer;
            chkSocio.Text = Rec.Socios;
            ChkCompraspresenciales.Text = Rec.ComprasPresenciales;

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
    
    }
}
