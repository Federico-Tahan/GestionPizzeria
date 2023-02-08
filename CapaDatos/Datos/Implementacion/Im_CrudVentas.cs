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
        public bool AltaVenta(Factura f)
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
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@fecha_reserva", f.Fecha);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_cliente", f.cliente.IdCliente);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_usuario", f.Usuario.ID_Usuario);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_forma_compra", f.Forma_Compra.IdFormaCompra);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_forma_entrega", f.FormaEntrega.IdFormaEntrega);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_descuento", f.descuento);

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
    }
}
