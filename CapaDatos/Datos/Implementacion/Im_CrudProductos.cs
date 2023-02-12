using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Implementacion
{
    public class Im_CrudProductos : CrudProductos
    {
        public bool AltaProducto(Producto p, Usuarios u)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", p.Nombre);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@precio", Math.Round(p.Precio,2));
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@detalle", p.Detalle);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@stock", p.Stock);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_unidad_medida", p.Unidadmedida.IdUnidadMedida);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_tipo_producto", p.Tipo_producto.IdTipoProducto);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_clasificacion", p.clasificacion.IdClasificacion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@baja_logica", p.Baja_logica);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_usuario", u.ID_Usuario);
                HelperDB.ObtenerInstancia().updatear_db("SP_AltaProducto");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Producto> GetProductos(int cond)
        {
            List<Producto> lproducto = new List<Producto>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@codicion", cond);
            HelperDB.ObtenerInstancia().LeerDB("SP_ObtenerProducto");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
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
                    prod.Precio = Math.Round(HelperDB.ObtenerInstancia().Dr.GetDecimal(2),2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    prod.Detalle = HelperDB.ObtenerInstancia().Dr.GetString(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    prod.Stock = HelperDB.ObtenerInstancia().Dr.GetInt32(4);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    um.IdUnidadMedida = HelperDB.ObtenerInstancia().Dr.GetInt32(5);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    um.Unidad_Medida = HelperDB.ObtenerInstancia().Dr.GetString(6);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    c.IdClasificacion = HelperDB.ObtenerInstancia().Dr.GetInt32(7);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(8))
                {
                    c.clasificacion = HelperDB.ObtenerInstancia().Dr.GetString(8);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(9))
                {
                    tp.IdTipoProducto = HelperDB.ObtenerInstancia().Dr.GetInt32(9);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(10))
                {
                    tp.Tipo_producto = HelperDB.ObtenerInstancia().Dr.GetString(10);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(11))
                {
                    prod.Baja_logica = HelperDB.ObtenerInstancia().Dr.GetInt32(11);
                }
                prod.Unidadmedida = um;
                prod.clasificacion = c;
                prod.Tipo_producto = tp;
                lproducto.Add(prod);
            }
            HelperDB.ObtenerInstancia().close();
            return lproducto;
        }

        public bool Modificacion(Producto p,Usuarios u)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_producto", p.Id_producto);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", p.Nombre);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@precio", Math.Round(p.Precio, 2));
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@detalle", p.Detalle);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@stock", p.Stock);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_unidad_medida", p.Unidadmedida.IdUnidadMedida);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_tipo_producto", p.Tipo_producto.IdTipoProducto);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_clasificacion", p.clasificacion.IdClasificacion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@baja_logica", p.Baja_logica);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_usuario", u.ID_Usuario);
                HelperDB.ObtenerInstancia().updatear_db("SP_ModificarProducto");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
