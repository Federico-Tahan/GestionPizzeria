using CapaDatos.Datos.Implementacion;
using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;
using CapaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Implementacion
{
    public class ng_TipoProdClasiUnidadMed : ing_TipoProdClasiUnidadMed
    {
        ITipoProdClasiUnidadMed lg;
        public ng_TipoProdClasiUnidadMed()
        {
            lg = new Im_TipoProdClasiUnidadMed();
        }

        public bool AltaClasificacion(Clasificacion c)
        {
            return lg.AltaClasificacion(c);
        }

        public bool AltaLocalidad(Localidad md)
        {
            return lg.AltaLocalidad(md);
        }

        public bool AltaTipoProducto(TipoProducto tp)
        {
            return lg.AltaTipoProducto(tp);
        }

        public bool AltaUnidadMedida(UnidadMedida md)
        {
            return lg.AltaUnidadMedida(md);
        }

        public List<Clasificacion> GetClasificacion(int a)
        {
            return lg.GetClasificacion(a);
        }

        public List<Localidad> GetLocalidad(int a)
        {
            return lg.GetLocalidad(a);
        }

        public List<TipoProducto> GetTipoProductos(int a)
        {
            return lg.GetTipoProductos(a);
        }

        public List<UnidadMedida> GetUnidadMedida(int a)
        {
            return lg.GetUnidadMedida(a);
        }

        public bool ModificacionClasificacion(Clasificacion c)
        {
            return lg.ModificacionClasificacion(c);
        }

        public bool ModificacionTipoProducto(TipoProducto tp)
        {
            return lg.ModificacionTipoProducto(tp);
        }

        public bool ModificacionUnidadMedida(UnidadMedida md)
        {
            return lg.ModificacionUnidadMedida(md);
        }

        public bool ModLocalidad(Localidad md)
        {
            return lg.ModLocalidad(md);
        }
    }
}
