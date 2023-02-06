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
        public bool AltaCliente(Cliente c)
        {
            throw new NotImplementedException();
        }

        public bool ModificacionCliente(Cliente c)
        {
            throw new NotImplementedException();
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
                if (HelperDB.ObtenerInstancia().Dr.GetInt32(10) == 1)
                {
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

        public List<Cliente> TraerClientesNoSocios()
        {
            throw new NotImplementedException();
        }

        public List<Cliente> TraerClientesSocios()
        {
            throw new NotImplementedException();
        }
    }
}
