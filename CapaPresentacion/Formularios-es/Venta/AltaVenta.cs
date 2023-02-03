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
        public AltaVenta()
        {
            InitializeComponent();
        }

        private void BtnSig_Click(object sender, EventArgs e)
        {
            ConfirmacionVenta form = new ConfirmacionVenta();
            form.ShowDialog();
        }
    }
}
