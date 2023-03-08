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
        public List<Localidad> Localidades()
        {
            List<Localidad> td = new List<Localidad>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_TRAER_Localidad");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Localidad rl = new Localidad();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    rl.idLocalidad = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    rl.NLocalidad = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                td.Add(rl);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }

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
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    rl.RolesEN = HelperDB.ObtenerInstancia().Dr.GetString(4);
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

        public Cliente TraerClientesCbo(long a,Cliente rl)
        {
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@dni", a);
            HelperDB.ObtenerInstancia().LeerDB("SP_TraerClientesCbo");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            if(HelperDB.ObtenerInstancia().Dr.Read())
            {

            
                Localidad l = new Localidad();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    rl.IdCliente = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    rl.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    rl.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    l.idLocalidad = HelperDB.ObtenerInstancia().Dr.GetInt32(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    rl.Direccion = HelperDB.ObtenerInstancia().Dr.GetString(4);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    rl.Altura = HelperDB.ObtenerInstancia().Dr.GetInt32(5);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    rl.Piso = HelperDB.ObtenerInstancia().Dr.GetInt32(6);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    rl.Departamento = HelperDB.ObtenerInstancia().Dr.GetString(7);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(8))
                {
                    rl.socio.Baja_logica = HelperDB.ObtenerInstancia().Dr.GetInt32(8);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(9))
                {
                    rl.Telefono= HelperDB.ObtenerInstancia().Dr.GetString(9);
                }
            rl.locali = l;
            HelperDB.ObtenerInstancia().close();
            }
            return rl;
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
