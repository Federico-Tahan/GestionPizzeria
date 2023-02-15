using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;

namespace CapaDatos.Datos.Implementacion
{
    public class Im_Cbos : ICbos
    {
        public List<Clasificacion> ObtenerClasificacion()
        {
            List<Clasificacion> td = new List<Clasificacion>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_ObtenerClasificacion");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Clasificacion rl = new Clasificacion();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    rl.IdClasificacion = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    rl.clasificacion = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                td.Add(rl);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<Roles> ObtenerRoles()
        {
            List<Roles> td = new List<Roles>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_Obtener_Roles");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Roles rl = new Roles();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    rl.Id_Rol = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    rl.Rol = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    rl.Descripcion = HelperDB.ObtenerInstancia().Dr.GetString(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    rl.BajaLogica = HelperDB.ObtenerInstancia().Dr.GetInt32(3);
                }
                td.Add(rl);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<TipoProducto> ObtenerTipoProducto()
        {
            List<TipoProducto> td = new List<TipoProducto>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_ObtenerTipoProducto");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                TipoProducto rl = new TipoProducto();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    rl.IdTipoProducto = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    rl.Tipo_producto = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                td.Add(rl);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<UnidadMedida> ObtenerUnidadMedida()
        {
            List<UnidadMedida> td = new List<UnidadMedida>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_ObtenerUnidadMedida");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                UnidadMedida rl = new UnidadMedida();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    rl.IdUnidadMedida = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    rl.Unidad_Medida = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                td.Add(rl);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<FormaCompra> TipoCompra()
        {
            List<FormaCompra> td = new List<FormaCompra>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_ObtenerFormaCompra");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                FormaCompra rl = new FormaCompra();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    rl.IdFormaCompra = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    rl.Forma_Compra = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                td.Add(rl);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<FormaEntrega> TipoEntregas()
        {
            List<FormaEntrega> td = new List<FormaEntrega>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_ObtenerFormaEntrega");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                FormaEntrega rl = new FormaEntrega();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    rl.IdFormaEntrega = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    rl.Forma_Entrega = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                td.Add(rl);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<Cliente> TraerClientesCbo(int a)
        {
            List<Cliente> td = new List<Cliente>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@socios", a);
            HelperDB.ObtenerInstancia().LeerDB("SP_TraerClientesCbo");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Cliente rl = new Cliente();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    rl.IdCliente = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    rl.NombreCompleto = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }

                td.Add(rl);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

        public List<Tipo_Cliente> TraerTipoClientes()
        {
            List<Tipo_Cliente> td = new List<Tipo_Cliente>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_Traer_TipoCliente");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Tipo_Cliente rl = new Tipo_Cliente();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    rl.Id_TipoCliente = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    rl.TipoCliente = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }

                td.Add(rl);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

    }
}
