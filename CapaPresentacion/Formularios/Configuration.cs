using CapaDatos.Dominio;
using CapaNegocio.Implementacion;
using CapaNegocio.Interfaces;
using CapaPresentacion.Formularios_es;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CapaPresentacion.RecursoIdioma;

namespace CapaPresentacion.Formularios
{
    public partial class Configuration : Form
    {
        ing_Configuracion lg = new ng_Configuracion();
        Configuracion c = new Configuracion();

        public Configuration()
        {
            InitializeComponent();
            //this.toolTip1.SetToolTip(this.picpreguntaguardar, "Debe seleccionar en donde quiere guardar el Back-Up de la Base de Datos.");
            //this.toolTip1.SetToolTip(this.picpreguntarestablecer, "Debe seleccionar el Back-Up de la base de datos para restablecerla.");
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            c= lg.TraerConfiguracion();
            CargarRedes();
            DetectarIdioma();
            AplicarIdioma();
            aplicarRoles();
        }

        private void CargarRedes()
        {
            TxbEmail.Text = c.Email;
            TxbFacebook.Text = c.Facebook;
            TxbInstagram.Text = c.Instagram;
            TxbTwitter.Text = c.Twitter;
            TxbYoutube.Text = c.Youtube;
            txbContraseña.Text = c.Contraseña;

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            AbstraerRedes();
            if (lg.ActualizarRedes(c, LogIn.u))
            {
                MessageBox.Show(Rec.MessageRedesActualizadas);
                c = lg.TraerConfiguracion();
                CargarRedes();
            }
            else
            {
                MessageBox.Show(Rec.MessageRedesNoActualizadas);

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
            c.Contraseña = txbContraseña.Text;
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            FrmBitacora b = new FrmBitacora();
            b.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txbRespaldo.Text = fbd.SelectedPath;
                BtnRespaldo.Enabled = true;
                BtnRespaldo.Show();
            }
        }

        private void BtnRespaldo_Click(object sender, EventArgs e)
        {
            lg.Conexion().Open();
            String database = lg.Conexion().Database.ToString() ;
            try
            {
                string q = "BACKUP DATABASE [" + database + "] TO DISK='" + txbRespaldo.Text + "\\" + "Pizzeria" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                SqlCommand cmd = new SqlCommand(q, lg.Conexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show(Rec.MessageBackupExito, Rec.CapBackup, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnRespaldo.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                lg.Conexion().Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL SERVER database backup files|*.bak";
            ofd.Title = "Database Restore";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtRestauracion.Text = ofd.FileName;
                btnRestauracion.Show();
            }
        }

        private void btnRestauracion_Click(object sender, EventArgs e)
        {
            lg.Conexion().Open();
            String database = lg.Conexion().Database.ToString();
            try
            {
                string sql1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(sql1, lg.Conexion());
                cmd1.ExecuteNonQuery();

                string sql2 = string.Format("USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + txtRestauracion.Text + "' WITH REPLACE;");
                SqlCommand cmd2 = new SqlCommand(sql2, lg.Conexion());
                cmd2.ExecuteNonQuery();

                string sql3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(sql3, lg.Conexion());
                cmd3.ExecuteNonQuery();

                MessageBox.Show(Rec.MessageRestauracionExito, Rec.CapRestore, MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRestauracion.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                lg.Conexion().Close();
            }
        }

        private void picpass_Click(object sender, EventArgs e)
        {
            {
                if (picpass.Tag != "Desactivar")
                {
                    picpass.Tag = "Desactivar";
                    txbContraseña.UseSystemPasswordChar = false;
                    picpass.Image = Properties.Resources.esconder__1_;
                }
                else
                {
                    picpass.Tag = "activar";
                    txbContraseña.UseSystemPasswordChar = true;
                    picpass.Image = Properties.Resources.mostrar;
                }
            }
        }

        public void AplicarIdioma()
        {
            lbConfiguracion.Text = Rec.Configuracion;
            lbredes.Text = Rec.Redes;
            BtnVer.Text = Rec.Ver;
            lbcontraseña.Text = Rec.Contraseña;
            lbrutaguardado.Text = Rec.RutadeGuardado;
            BtnRespaldo.Text = Rec.Respaldo;
            button3.Text = Rec.Seleccionar;
            lbrutarestauracion.Text = Rec.RutadeRestauracion;
            btnRestauracion.Text = Rec.Restauracion;
            button4.Text = Rec.Seleccionar;
            lbbitacora.Text = Rec.Bitacora;
            BtnGuardar.Text = Rec.Guardar;

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

        private void aplicarRoles()
        {
            if (LogIn.u.Rol.Id_Rol != 1 && LogIn.u.Rol.Id_Rol != 2)
            {
                panel1.Visible= false;
            }
        }
    }
}
