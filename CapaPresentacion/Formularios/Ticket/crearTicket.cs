using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using CapaDatos.Dominio;
using CapaPresentacion.RecursoIdioma;

namespace ticket_o_factura
{
    public class crearTicket
    {
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Cuit { get; set; }
        public string NombreEmpresa { get; set; }
        public string Empleado { get; set; }
        public string Total { get; set; }
        public string Subtotal { get; set; }
        public string Descuento { get; set; }
        public string InfoCuit { get; set; }
        public string NroFac { get; set; }
        public  Image logotipo { get; set; }
        public string Localidad { get; set; }
        public string Calle { get; set; }
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public string TipoCommpra { get; set; }
        public string FomraEntrega { get; set; }
        public string Altura { get; set; }
        public string Piso { get; set; }
        public string Departamento { get; set; }

        public List<DetalleFactura> listaProducto = new List<DetalleFactura>();   

        private PrintDocument doc = new PrintDocument();
        private PrintPreviewDialog vista = new PrintPreviewDialog();

        //crea la pagina de la factura y te la muestra
        public void imprimir(crearTicket  p)
        {
            doc.PrinterSettings.PrinterName = doc.DefaultPageSettings.PrinterSettings.PrinterName;
            doc.PrintPage += new PrintPageEventHandler(imprimeticket);

            vista.Document = doc;
            vista.Show();
        }
        // dibuja sobre la hoja creada y pone los datos de la factura
        public void imprimeticket(object sender, PrintPageEventArgs e)
        {

            int posX, posY;
            Font fuente = new Font("consola", 8, FontStyle.Bold);
            try
            {

                posX = 10;
                posY = 10;
                e.Graphics.DrawImage(logotipo, 700, 20, 100, 100);
                posX += 435;
                posY += 100;
                e.Graphics.DrawString(NombreEmpresa, fuente, Brushes.Black, posX, posY);
                posY += 20;
                e.Graphics.DrawString(Cuit, fuente, Brushes.Black, posX, posY);
                posY -= 20;

                posX -= 435;
                posY -= 100;

                posY += 20;
                posY += 20;
                fuente = new Font("consola", 10, FontStyle.Bold);
                e.Graphics.DrawString(Rec.NroFactura+": " +NroFac, fuente, Brushes.Black, posX, posY);
                posY += 20;
                e.Graphics.DrawString(Fecha, fuente, Brushes.Black, posX, posY);
                posX += 250;
                e.Graphics.DrawString(Hora, fuente, Brushes.Black, posX, posY);
                posX -= 250;
                posY += 20;
                e.Graphics.DrawString(Rec.DGVNombreVendedor + ": "+ Empleado, fuente, Brushes.Black, posX, posY);
                posY += 20;
                e.Graphics.DrawString(Rec.NombreCliente + ": " + Nombre, fuente, Brushes.Black, posX, posY);
                posY += 20;
                e.Graphics.DrawString(Rec.DNI + ": " + DNI, fuente, Brushes.Black, posX, posY);
                posY += 20;
                e.Graphics.DrawString(Rec.localidad + ": "+Localidad, fuente, Brushes.Black, posX, posY);
                posY += 20;
                e.Graphics.DrawString(Rec.Calle + ": " + Calle, fuente, Brushes.Black, posX, posY);
                posY += 20;
                e.Graphics.DrawString(Rec.Altura + ": " + Altura, fuente, Brushes.Black, posX, posY);
                posY += 20;
                e.Graphics.DrawString(Rec.Piso + ": " + Piso, fuente, Brushes.Black, posX, posY);
                posX += 150;
                e.Graphics.DrawString(Rec.Departamento + ": " + Departamento, fuente, Brushes.Black, posX, posY);
                posX -= 150;
                posY += 20;

                e.Graphics.DrawString(Rec.Telefono + ": " + Telefono, fuente, Brushes.Black, posX, posY);
                posY += 20;
                e.Graphics.DrawString(Rec.TipodeCompra + ": " + TipoCommpra, fuente, Brushes.Black, posX, posY);
                posX += 280;

                e.Graphics.DrawString(Rec.TipodeEntrega + ": " + FomraEntrega, fuente, Brushes.Black, posX, posY);
                posX -= 280;

                posY += 30;

                fuente = new Font("consola", 9, FontStyle.Bold);
                e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", fuente, Brushes.Black, posX, posY);
                posY += 15;
                e.Graphics.DrawString("CANT.                PRODUCTO                                                                                        PRECIO                                      SUBTOTAL ", fuente, Brushes.Black, posX, posY);
                posY += 15;
                e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", fuente, Brushes.Black, posX, posY);
                posY += 25;
                fuente = new Font("consola", 8, FontStyle.Bold);

                for (int i =0; i < listaProducto.Count; i++)
                {

                    if (listaProducto[i].Cantidad < 10)
                    {
                        e.Graphics.DrawString("0"+Convert.ToString(listaProducto[i].Cantidad), fuente, Brushes.Black, posX, posY);
                        posX += 100;
                        e.Graphics.DrawString(Convert.ToString(listaProducto[i].Prod.Nombre), fuente, Brushes.Black, posX, posY);
                        posX += 375;
                        e.Graphics.DrawString("$" + Convert.ToString(listaProducto[i].Precio), fuente, Brushes.Black, posX, posY);
                        posX += 180;
                        e.Graphics.DrawString("$" + Convert.ToString(listaProducto[i].Precio * listaProducto[i].Cantidad), fuente, Brushes.Black, posX, posY);
                        posY += 25;
                        posX -= 375;
                        posX -= 180;
                        posX -= 100;
                    }
                    else
                    {
                        e.Graphics.DrawString(Convert.ToString(listaProducto[i].Cantidad),fuente, Brushes.Black, posX, posY);
                        posX += 100;
                        e.Graphics.DrawString( Convert.ToString(listaProducto[i].Prod.Nombre), fuente, Brushes.Black, posX, posY);
                        posX += 375;
                        e.Graphics.DrawString("$" + Convert.ToString(listaProducto[i].Precio), fuente, Brushes.Black, posX, posY);
                        posX += 180;
                        e.Graphics.DrawString("$" + Convert.ToString(listaProducto[i].Precio * listaProducto[i].Cantidad), fuente, Brushes.Black, posX, posY);
                        posY += 25;
                        posX -= 375;
                        posX -= 180;
                        posX -= 100;

                    }


                }


                e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", fuente, Brushes.Black, posX, posY);

                posY += 20;
                e.Graphics.DrawString("                                                                                                                                                                                                       SUBTOTAL :  $" + Subtotal, fuente, Brushes.Black, posX, posY); posY += 20;
                e.Graphics.DrawString("                                                                                                                                                                                                       DTO % :  " + Descuento, fuente, Brushes.Black, posX, posY); posY += 20;
                e.Graphics.DrawString("                                                                                                                                                                                                       TOTAL :  $" + Total, fuente, Brushes.Black, posX, posY);
                posY += 45;

                fuente = new Font("consola", 10, FontStyle.Bold);
                e.Graphics.DrawString("                                                                              GRACIAS POR SU COMPRA. ", fuente, Brushes.Black, posX, posY);
                posY += 25;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        //espaciado
    
        public string espaciar(int tamaño, int valor)
        {
            string espacio = "";
            int subvalor = 0;
            subvalor = valor - tamaño;

            for(int i = 0; i < subvalor; i++)
            {
                espacio  += " ";
            }

            return espacio;

        }
        

    }

}
