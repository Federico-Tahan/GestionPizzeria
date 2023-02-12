using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Implementacion
{
    public class Im_TipoProdClasiUnidadMed : ITipoProdClasiUnidadMed
    {
        public List<Clasificacion> GetClasificacion(int a)
        {
            List<Clasificacion> lclasificacion = new List<Clasificacion>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@a", a);
            HelperDB.ObtenerInstancia().LeerDB("SP_GetClasificacion");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {

                Clasificacion c = new Clasificacion();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.IdClasificacion = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.clasificacion = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    c.BajaLogica = HelperDB.ObtenerInstancia().Dr.GetInt32(2);
                }
                lclasificacion.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return lclasificacion;
        }

        public List<TipoProducto> GetTipoProductos(int a)
        {
            List<TipoProducto> ltipoprod= new List<TipoProducto>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@a", a);
            HelperDB.ObtenerInstancia().LeerDB("SP_GetTipoProducto");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {

                TipoProducto c = new TipoProducto();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.IdTipoProducto = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.Tipo_producto = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    c.Baja_logica = HelperDB.ObtenerInstancia().Dr.GetInt32(2);
                }
                ltipoprod.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return ltipoprod;
        }

        public List<UnidadMedida> GetUnidadMedida(int a)
        {
            List<UnidadMedida> lunidadmed = new List<UnidadMedida>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@a", a);
            HelperDB.ObtenerInstancia().LeerDB("SP_GetUnidadMedida");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {

                UnidadMedida c = new UnidadMedida();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.IdUnidadMedida = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.Unidad_Medida = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    c.Baja_Logica = HelperDB.ObtenerInstancia().Dr.GetInt32(2);
                }
                lunidadmed.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return lunidadmed;
        }
    }
}
