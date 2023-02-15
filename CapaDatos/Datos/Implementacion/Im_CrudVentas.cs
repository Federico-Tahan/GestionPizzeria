using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Implementacion
{
    public class Im_CrudVentas : CrudVentas
    {
        public bool AltaVenta(Factura f, Usuarios u)
        {
            bool bandera = false;
            SqlConnection conn = HelperDB.ObtenerInstancia().conexion();
            SqlTransaction tr = null;
            try
            {
                HelperDB.ObtenerInstancia().open();
                tr = conn.BeginTransaction();
                HelperDB.ObtenerInstancia().Command.Transaction = tr;
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_cliente", f.cliente.IdCliente);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_usuario", f.Usuario.ID_Usuario);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_forma_compra", f.Forma_Compra.IdFormaCompra);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_forma_entrega", f.FormaEntrega.IdFormaEntrega);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@tienedescuento", f.tieneDescuento);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_usuario_admin", u.ID_Usuario);



                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@IDFACTURA";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                HelperDB.ObtenerInstancia().Command.Parameters.Add(pOut);
                HelperDB.ObtenerInstancia().Command.CommandText = "SP_AltaVenta";
                HelperDB.ObtenerInstancia().Command.ExecuteNonQuery();
                f.IdFactura = (int)pOut.Value;

                HelperDB.ObtenerInstancia().Command.Parameters.Clear();

                for (int i = 0; i < f.DetalleFacturas.Count; i++)
                {
                    HelperDB.ObtenerInstancia().Command.Transaction = tr;

                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_nrofactura", f.IdFactura);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_producto", f.DetalleFacturas[i].Prod.Id_producto);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@cantidad", f.DetalleFacturas[i].Cantidad);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@importe", f.DetalleFacturas[i].Precio);
                    HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@descripcion", f.DetalleFacturas[i].Descripcion);

                    HelperDB.ObtenerInstancia().Command.CommandText = "SP_DetalleVenta";
                    HelperDB.ObtenerInstancia().Command.ExecuteNonQuery();
                    HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                }
                tr.Commit();
                bandera = true;
            }
            catch (Exception)
            {
                tr.Rollback();
                bandera = false;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    HelperDB.ObtenerInstancia().close();
                }
            }
            return bandera;
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

        public Configuracion TraerConfig()
        {
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_ObtenerCondicionesDescuento");

            Configuracion rl = new Configuracion();
            if (HelperDB.ObtenerInstancia().Dr.Read())
            {
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    rl.DescuentoSocios = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    rl.DescuentoPresencial = HelperDB.ObtenerInstancia().Dr.GetInt32(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    rl.PorcentajeDescuentoHoy = HelperDB.ObtenerInstancia().Dr.GetInt32(2);
                }
            }
               
            HelperDB.ObtenerInstancia().close();

            return rl;
        }

        public List<DetalleFactura> TraerDetalles(int a)
        {
            List<DetalleFactura> ldetalles = new List<DetalleFactura>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_f", a);
            HelperDB.ObtenerInstancia().LeerDB("SP_ObtenerDetalles");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                DetalleFactura df = new DetalleFactura();
                Producto prod = new Producto();
                UnidadMedida um = new UnidadMedida();
                Clasificacion c = new Clasificacion();
                TipoProducto tp = new TipoProducto();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    prod.Id_producto = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    prod.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    prod.Detalle = HelperDB.ObtenerInstancia().Dr.GetString(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    um.IdUnidadMedida = HelperDB.ObtenerInstancia().Dr.GetInt32(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    um.Unidad_Medida = HelperDB.ObtenerInstancia().Dr.GetString(4);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    c.IdClasificacion = HelperDB.ObtenerInstancia().Dr.GetInt32(5);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    c.clasificacion = HelperDB.ObtenerInstancia().Dr.GetString(6);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    tp.IdTipoProducto = HelperDB.ObtenerInstancia().Dr.GetInt32(7);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(8))
                {
                    tp.Tipo_producto = HelperDB.ObtenerInstancia().Dr.GetString(8);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(9))
                {
                    df.Cantidad = HelperDB.ObtenerInstancia().Dr.GetInt32(9);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(10))
                {
                    df.Descripcion = HelperDB.ObtenerInstancia().Dr.GetString(10);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(11))
                {
                    df.Precio = Math.Round(HelperDB.ObtenerInstancia().Dr.GetDecimal(11),2);
                }
                prod.Unidadmedida = um;
                prod.clasificacion = c;
                prod.Tipo_producto = tp;
                df.Prod = prod;
                ldetalles.Add(df);
            }
            HelperDB.ObtenerInstancia().close();
            return ldetalles;

        }

        public List<Factura> TraerFactura()
        {
            List<Factura> lfactura = new List<Factura>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_ObtenerFactura");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Factura f = new Factura();
                Cliente c = new Cliente();
                Usuarios u = new Usuarios();
                Empleado e = new Empleado();
                FormaCompra fc = new FormaCompra();
                FormaEntrega fe = new FormaEntrega();
                Descuento d = new Descuento();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    f.IdFactura = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    c.NombreCompleto = HelperDB.ObtenerInstancia().Dr.GetString(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                   e.NombreCompleto = HelperDB.ObtenerInstancia().Dr.GetString(4);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    fc.Forma_Compra = HelperDB.ObtenerInstancia().Dr.GetString(5);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    fe.Forma_Entrega = HelperDB.ObtenerInstancia().Dr.GetString(6);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    d.PorcentajeDescuento = HelperDB.ObtenerInstancia().Dr.GetInt32(7);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(8))
                {
                    f.Fecha= HelperDB.ObtenerInstancia().Dr.GetDateTime(8);
                }
                f.descuento = d;
                f.FormaEntrega = fe;
                f.Forma_Compra = fc;
                f.cliente = c;
                u.Empleado = e;
                f.Usuario = u;
                lfactura.Add(f);
            }
            HelperDB.ObtenerInstancia().close();
            return lfactura;
        }
    }
}
