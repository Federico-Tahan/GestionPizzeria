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
        //realiza la transaccion de la venta y si algo no esta bien hace un rollback para que simule como que no paso nada y recibe un Usuario para que se registre en al bitacora
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
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", f.cliente.Nombre);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@apellido", f.cliente.Apellido);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_localidad", f.cliente.locali.idLocalidad);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@calle", f.cliente.Direccion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@altura", f.cliente.Altura);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@piso", f.cliente.Piso);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@departamento", f.cliente.Departamento);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@dni", f.cliente.socio.DNI);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@telefono", f.cliente.tel);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@descuento", f.descuento.PorcentajeDescuento);

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

        //modifca la venta de igual manera que el alta y recibe un Usuario para que se registre en al bitacora
        public bool ModVenta(Factura f, Usuarios u)
        {
            bool bandera = false;
            SqlConnection conn = HelperDB.ObtenerInstancia().conexion();
            SqlTransaction tr = null;
            try
            {
                CancelFacturaVenta(f.IdFactura);
                HelperDB.ObtenerInstancia().open();
                tr = conn.BeginTransaction();
                HelperDB.ObtenerInstancia().Command.Transaction = tr;
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_factura", f.IdFactura);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_cliente", f.cliente.IdCliente);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_usuario", f.Usuario.ID_Usuario);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_forma_compra", f.Forma_Compra.IdFormaCompra);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_forma_entrega", f.FormaEntrega.IdFormaEntrega);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@tienedescuento", f.tieneDescuento);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_usuario_admin", u.ID_Usuario);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", f.cliente.Nombre);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@apellido", f.cliente.Apellido);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_localidad", f.cliente.locali.idLocalidad);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@calle", f.cliente.Direccion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@altura", f.cliente.Altura);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@piso", f.cliente.Piso);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@departamento", f.cliente.Departamento);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@telefono", f.cliente.tel);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@descuento", f.descuento.PorcentajeDescuento);

                HelperDB.ObtenerInstancia().Command.CommandText = "SP_ModVenta";
                HelperDB.ObtenerInstancia().Command.ExecuteNonQuery();

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

        //busca un cliente socio por dni
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

        //cancela la factura con su id y recibe un Usuario para que se registre en al bitacora
        public bool CancelFactura(int i, Usuarios u)
        {
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_fac", i);
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_usuario",u.ID_Usuario);
            HelperDB.ObtenerInstancia().updatear_db("SP_CancelarVenta");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            return true;
        }
        //
        public bool CancelFacturaVenta(int i)
        {
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_fac", i);
            HelperDB.ObtenerInstancia().updatear_db("SP_CancelarVentaMod");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            return true;
        }
        //Trae la configuracion para ver si la venta cumple con el descuento
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
                    rl.PorcentajeDescuentoHoy = HelperDB.ObtenerInstancia().Dr.GetDecimal(2);
                }
            }
               
            HelperDB.ObtenerInstancia().close();

            return rl;
        }
        //trae los detalles en una lista con la condicion de acitvo desactiovo o todos
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
        //trae las facturas en una lista
        public List<Factura> TraerFactura(int a)
        {
            List<Factura> lfactura = new List<Factura>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_vendedor", a);
            HelperDB.ObtenerInstancia().LeerDB("SP_ObtenerFactura");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Factura f = new Factura();
                Cliente c = new Cliente();
                Usuarios u = new Usuarios();
                Socio s = new Socio();
                Empleado e = new Empleado();
                FormaCompra fc = new FormaCompra();
                FormaEntrega fe = new FormaEntrega();
                Descuento d = new Descuento();
                Localidad loc = new Localidad();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    f.IdFactura = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    c.NombreCompleto = HelperDB.ObtenerInstancia().Dr.GetString(3);
                    c.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(16);
                    c.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(17);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                   e.NombreCompleto = HelperDB.ObtenerInstancia().Dr.GetString(4);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    fc.Forma_Compra = HelperDB.ObtenerInstancia().Dr.GetString(5);
                    fc.IdFormaCompra = HelperDB.ObtenerInstancia().Dr.GetInt32(19);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    fe.Forma_Entrega = HelperDB.ObtenerInstancia().Dr.GetString(6);
                    fe.IdFormaEntrega = HelperDB.ObtenerInstancia().Dr.GetInt32(18);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    d.PorcentajeDescuento = Math.Round(HelperDB.ObtenerInstancia().Dr.GetDecimal(7),2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(8))
                {
                    f.Fecha= HelperDB.ObtenerInstancia().Dr.GetDateTime(8);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(9))
                {
                    loc.NLocalidad = HelperDB.ObtenerInstancia().Dr.GetString(9);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(10))
                {
                    c.Altura= HelperDB.ObtenerInstancia().Dr.GetInt32(10);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(11))
                {
                   c.Piso= HelperDB.ObtenerInstancia().Dr.GetInt32(11);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(12))
                {
                    c.Departamento = HelperDB.ObtenerInstancia().Dr.GetString(12);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(13))
                {
                    c.Direccion= HelperDB.ObtenerInstancia().Dr.GetString(13);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(14))
                {
                    f.BajaLogica = HelperDB.ObtenerInstancia().Dr.GetInt32(14);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(15))
                {
                    loc.idLocalidad = HelperDB.ObtenerInstancia().Dr.GetInt32(15);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(20))
                {
                   s.DNI  = HelperDB.ObtenerInstancia().Dr.GetInt64(20);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(21))
                {
                    c.tel = HelperDB.ObtenerInstancia().Dr.GetInt64(21);
                }
                f.descuento = d;
                f.FormaEntrega = fe;
                f.Forma_Compra = fc;
                f.cliente = c;
                f.cliente.locali = loc;
                u.Empleado = e;
                f.Locali = loc;
                f.Usuario = u;
                f.cliente.socio = s;
                lfactura.Add(f);
            }
            HelperDB.ObtenerInstancia().close();
            return lfactura;
        }
    }
}
