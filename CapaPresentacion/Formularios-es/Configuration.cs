using CapaDatos.Dominio;
using CapaNegocio.Implementacion;
using CapaNegocio.Interfaces;
using CapaPresentacion.Formularios_es;
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
    public partial class Configuration : Form
    {
        ing_Configuracion lg = new ng_Configuracion();
        Configuracion c = new Configuracion();
        public Configuration()
        {
            InitializeComponent();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            c= lg.TraerConfiguracion();
            CargarRedes();
        }

        private void CargarRedes()
        {
            TxbEmail.Text = c.Email;
            TxbFacebook.Text = c.Facebook;
            TxbInstagram.Text = c.Instagram;
            TxbTwitter.Text = c.Twitter;
            TxbYoutube.Text = c.Youtube;

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            AbstraerRedes();
            if (lg.ActualizarRedes(c))
            {
                MessageBox.Show("Redes acutalizadas con Exito");
                c = lg.TraerConfiguracion();
                CargarRedes();
            }
            else
            {
                MessageBox.Show("Las redes no se pudieron actualizar.");

            }
        }

        public void AbstraerRedes()
        {
            c = new Configuracion();
            c.Email= TxbEmail.Text;
            c.Facebook= TxbFacebook.Text;
            c.Twitter= TxbTwitter.Text;
            c.Instagram= TxbInstagram.Text;
            c.Youtube= TxbYoutube.Text;
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            FrmBitacora b = new FrmBitacora();
            b.ShowDialog();
        }
    }
}
