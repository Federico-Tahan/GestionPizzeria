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
        public bool AltaClasificacion(Clasificacion c)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", c.clasificacion);
                HelperDB.ObtenerInstancia().updatear_db("SP_AltaClasificacion");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AltaLocalidad(Localidad md)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", md.NLocalidad);
                HelperDB.ObtenerInstancia().updatear_db("SP_AltaLocalidad");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AltaTipoProducto(TipoProducto tp)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", tp.Tipo_producto);
                HelperDB.ObtenerInstancia().updatear_db("SP_AltaTipoProd");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AltaUnidadMedida(UnidadMedida md)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", md.Unidad_Medida);
                HelperDB.ObtenerInstancia().updatear_db("SP_AltaUnidadMed");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

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

        public List<Localidad> GetLocalidad(int a)
        {
            List<Localidad> lclasificacion = new List<Localidad>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@a", a);
            HelperDB.ObtenerInstancia().LeerDB("SP_GetLocalidad");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {

                Localidad c = new Localidad();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.idLocalidad = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    c.NLocalidad = HelperDB.ObtenerInstancia().Dr.GetString(1);
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

        public bool ModificacionClasificacion(Clasificacion c)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id", c.IdClasificacion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", c.clasificacion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@baja_logica", c.BajaLogica);
                HelperDB.ObtenerInstancia().updatear_db("SP_MODClasificacion");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ModificacionTipoProducto(TipoProducto tp)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id", tp.IdTipoProducto);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", tp.Tipo_producto);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@baja_logica", tp.Baja_logica);
                HelperDB.ObtenerInstancia().updatear_db("SP_MODTipoProd");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ModificacionUnidadMedida(UnidadMedida md)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id", md.IdUnidadMedida);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", md.Unidad_Medida);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@baja_logica", md.Baja_Logica);
                HelperDB.ObtenerInstancia().updatear_db("SP_MODUnidadMed");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ModLocalidad(Localidad md)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id", md.idLocalidad);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", md.NLocalidad);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@baja_logica", md.BajaLogica);
                HelperDB.ObtenerInstancia().updatear_db("SP_ModLocalidad");
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
