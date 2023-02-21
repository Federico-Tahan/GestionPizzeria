using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Implementacion
{
    public class Im_Cliente : ICliente
    {
        IConfiguracion lg = new Im_Configuracion();
        Configuracion con = new Configuracion();

        public bool AltaClienteNosocio(Cliente c, Usuarios u)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_tipo_cliente", 2);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", c.Nombre);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@apellido", c.Apellido);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@direccion", c.Direccion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@telefono", c.Telefono);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_usuario", u.ID_Usuario);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@altura", c.Altura);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@piso", c.Piso);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@departamento", c.Departamento);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_localidad", c.locali.idLocalidad);
                HelperDB.ObtenerInstancia().updatear_db("SP_Insertar_Cliente");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AltaClienteSocio(Cliente c, Usuarios u)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_tipo_cliente", 1);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", c.Nombre );
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@apellido",c.Apellido );
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@direccion",c.Direccion );
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@telefono",c.Telefono );
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@DNI",c.socio.DNI );
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@email",c.socio.Email );
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_usuario", u.ID_Usuario);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@altura", c.Altura);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@piso", c.Piso);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@departamento", c.Departamento);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_localidad", c.locali.idLocalidad);
                HelperDB.ObtenerInstancia().updatear_db("SP_Insertar_ClienteSocio");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AltaSocio(Cliente c, Usuarios u)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_cliente", c.IdCliente);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@dni", c.socio.DNI);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@email", c.socio.Email);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_usuario", u.ID_Usuario);
                HelperDB.ObtenerInstancia().updatear_db("SP_Insertar_Socio");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool BuscarCliente(Cliente c)
        {
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id", c.IdCliente);
            HelperDB.ObtenerInstancia().LeerDB("SP_BuscarCliente");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            if (HelperDB.ObtenerInstancia().Dr.Read())
            {
                HelperDB.ObtenerInstancia().close();
                return true;

            }
            HelperDB.ObtenerInstancia().close();
            return false;
        }

        public bool BuscarClienteSocioDni(Cliente c)
        {
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@DNI", c.socio.DNI);
            HelperDB.ObtenerInstancia().LeerDB("SP_BuscarSocioDni");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            if (HelperDB.ObtenerInstancia().Dr.Read())
            {
                HelperDB.ObtenerInstancia().close();
                return true;

            }
            HelperDB.ObtenerInstancia().close();
            return false;
        }

        public bool EmailSender(Cliente c)
        {
            try
            {
                con = lg.TraerConfiguracion();
                // Datos del remitente y del destinatario
                string fromAddress = con.Email;
                string toAddress = c.socio.Email;

                // Credenciales de la cuenta de correo
                string fromPassword = con.Contraseña;

                // Asunto y cuerpo del mensaje
                string subject = "Has Sido dado de alta como socio en El Club Hai Pianto";
                string body = "TÈRMINOS Y CONDICIONES\r\n\r\nSISTEMA DE BENEFICIOS  CLUB HAI PIANTO\r\n\r\nEl Club Hai Pianto se encarga de otorgar beneficios de descuentos a los clientes que esten registrados en su sistema  dentro de la categorìa de “Socios” y realicen compras de forma presencial en el local . Dichos descuentos estaràn  sujetos a los términos y condiciones aquí expresados.\r\n\r\nADHESIÒN AL CLUB\r\n\r\n1.\tLa participación en el sistema es voluntaria por parte de los usuarios.\r\n2.\tSe podrá adherir al club toda persona mayor de 18 años. \r\n3.\tEl registro sòlo se realiza de forma presencial .\r\n4.\tEl socio declara bajo juramento que los datos consignados son verídicos y se hace responsable respecto de la veracidad de los mismos. Ademàs, al momento de su registro deberà presentar de manera obligatoria su documento nacional de identidad (DNI) \r\n5.\tSe establece que cada socio es titular único y no puede compartir su beneficio con ninguna otra persona para que realice compras en su nombre. \r\n6.\tEl porcentaje de descuento varìarà segùn el dìa de la semana. \r\n7.\tLa adhesión al Club implica la aceptación del socio de todas las condiciones estipuladas en el presente Reglamento.\r\n8.\tClub Hai Pianto se reserva el derecho de determinar a quién permite adherirse al programa de beneficios.\r\n\r\nOBTENCIÒN DEL DESCUENTO\r\n\r\n1.\tSe establece que todo socio del Club, que realice la compra de manera presencìal, recibirà un descuento de acuerdo al siguiente criterio:\r\n\r\n*El descuento se realizarà sobre el total de la compra y no sobre cada producto de manera individual*\r\n\r\n2.\tQuedan excluidos para la obtención del descuento aquellos clientes que no sean socios del Club o realicen su compra por otro medio que no sea el presencial\r\n3.\tTanto el valor de los precios como el porcentaje de descuento podrán ser modificados por el local en cualquier momento de acuerdo a lo establecido en este reglamento\r\n4.\tClub Hai Pianto se reserva el derecho de variar los términos y condiciones de este reglamento en tanto fuera necesario\r\n\r\nCOMPROBANTES\r\n\r\nLuego de realizar una compra, el socio recibirá un ticket en el cual se especificarà el valor total de la compra y su descuento agregado. \r\n\r\n\r\nDARSE DE BAJA\r\n\r\nEl socio que  se arrepienta de formar parte del Club y decida darse de baja,  deberá acudir de manera presencial al local para  anular su membresìa. \r\n\r\nPROMOCIONES ESPECIALES\r\n\r\nEl Club se reserva el derecho de crear promociones especiales que no están incluidas dentro de este Reglamento, como así también la caducidad o modificaciòn de las actuales.\r\n\r\nACTUALIZACION DE DATOS\r\n\r\nEs obligación del Socio  informar al local de cualquier cambio en sus datos de registro (correo electrónico, domicilio, nombre, apellido, etc). El proceso de actualizaciòn se hace de manera presencial acudiendo al local\r\n\r\nDATOS PERSONALES\r\n\r\nLos clientes, al momento de presentar la solicitud de adhesión al Club, prestan su consentimiento libre y expreso para que sus datos sean almacenados en la base de datos del local.\r\n\r\n1.\tEl sistema recopila datos para gestionar y facilitar la participación de sus clientes en su negocio y que asì,  puedan acceder a los beneficios establecidos\r\n2.\tSe gestionan las ventas y facturas correspondientes segùn la categoria del cliente (Sòcio o No Socio del Club) para asì incluir, o no, el descuento en sus compras.\r\n3.\tLos clientes mantendrán indemne al Club de las consecuencias de cualquier reclamo de terceros o con motivo del suministro de información personal.\r\n4.\tLa información personal será objeto de tratamiento automatizado en la base de datos precedentemente mencionada conforme a las normas legales vigentes.\r\n5.\tLos clientes podrán solicitar la actualización, rectificación o supresión de su respectiva información personal en la base de datos. \r\n6.\tLa provisión de la información personal por parte del cliente es voluntaria, pero es  un requisito necesario para la activación de su membresìa. En caso que el socio solicitara la supresión de su información personal, perderá el derecho a los beneficios.\r\n7.\tEl titular de los datos personales tiene la facultad de ejercer el derecho de darse de baja del Club en cualquier momento y por cualquier motivo\r\n\nREDES SOCIALES\n" + "Instagram:" +con.Instagram + "\n" + "Facebook:" + con.Facebook + "\n" + "Youtube:" + con.Youtube + "\n" + "Twitter:" + con.Twitter + "\n";

                // Creación del objeto SmtpClient
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress, fromPassword)
                };

                // Creación del objeto MailMessage
                MailMessage message = new MailMessage(fromAddress, toAddress, subject, body);

                // Envío del correo electrónico
                smtp.Send(message);
                return true;
            }catch(Exception ex)
            {

                return false;
            }
            
        }
    

        public bool ModificacionCliente(Cliente c, Usuarios u)  
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_cliente", c.IdCliente);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_tipo_cliente", c.TipoCliente.Id_TipoCliente);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@direccion", c.Direccion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@telefono", c.Telefono);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@email", c.socio.Email);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_usuario", u.ID_Usuario);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@altura", c.Altura);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@piso", c.Piso);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@departamento", c.Departamento);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@localidad", c.locali.idLocalidad);
                HelperDB.ObtenerInstancia().updatear_db("SP_ModificarSocio");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Cliente> TraerClientes()
        {
            List<Cliente> lClientes = new List<Cliente>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_Cargar_TodosCLientes");
            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Cliente c = new Cliente();
                Socio s = new Socio();
                Tipo_Cliente tc = new Tipo_Cliente();
                Localidad loc = new Localidad();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                     c.IdCliente =HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    s.Id_Socio = HelperDB.ObtenerInstancia().Dr.GetInt32(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    c.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    c.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    c.Direccion = HelperDB.ObtenerInstancia().Dr.GetString(4);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    c.Telefono = HelperDB.ObtenerInstancia().Dr.GetString(5);
                }

                    if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                    {
                        s.DNI = HelperDB.ObtenerInstancia().Dr.GetInt64(6);
                    }
                    if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                    {
                        s.Email = HelperDB.ObtenerInstancia().Dr.GetString(7);
                    }
                    if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(8))
                    {
                        s.FechaAdhesion = HelperDB.ObtenerInstancia().Dr.GetDateTime(8);
                    }
                    if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(9))
                    {
                        s.Baja_logica = HelperDB.ObtenerInstancia().Dr.GetInt32(9);
                    }

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(10))
                {
                    tc.Id_TipoCliente= HelperDB.ObtenerInstancia().Dr.GetInt32(10);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(11))
                {
                    c.Altura = HelperDB.ObtenerInstancia().Dr.GetInt32(11);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(12))
                {
                    c.Piso = HelperDB.ObtenerInstancia().Dr.GetInt32(12);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(13))
                {
                    c.Departamento = HelperDB.ObtenerInstancia().Dr.GetString(13);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(14))
                {
                    loc.idLocalidad = HelperDB.ObtenerInstancia().Dr.GetInt32(14);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(15))
                {
                    loc.NLocalidad = HelperDB.ObtenerInstancia().Dr.GetString(15);
                }
                c.socio = s;
                c.TipoCliente= tc;
                c.locali= loc;
                lClientes.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return lClientes;
        }



    }
}
