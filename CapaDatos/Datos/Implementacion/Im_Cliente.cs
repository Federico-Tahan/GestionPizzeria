using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Implementacion
{
    public class Im_Cliente : ICliente
    {
        public bool AltaClienteNosocio(Cliente c)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_tipo_cliente", 2);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", c.Nombre);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@apellido", c.Apellido);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@direccion", c.Direccion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@telefono", c.Telefono);
                HelperDB.ObtenerInstancia().updatear_db("SP_Insertar_Cliente");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AltaClienteSocio(Cliente c)
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
                HelperDB.ObtenerInstancia().updatear_db("SP_Insertar_ClienteSocio");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AltaSocio(Cliente c)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_cliente", c.IdCliente);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@dni", c.socio.DNI);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@email", c.socio.Email);
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

        public bool ModificacionCliente(Cliente c)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_cliente", c.IdCliente);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_tipo_cliente", c.TipoCliente.Id_TipoCliente);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@direccion", c.Direccion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@telefono", c.Telefono);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@email", c.socio.Email);
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
                    c.Telefono = HelperDB.ObtenerInstancia().Dr.GetInt64(5);
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
                c.socio = s;
                c.TipoCliente= tc;
                lClientes.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return lClientes;
        }

    }
}
