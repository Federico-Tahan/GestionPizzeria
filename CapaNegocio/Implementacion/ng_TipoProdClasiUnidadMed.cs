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

        public bool AltaClasificacion(Clasificacion c, Usuarios u)
        {
            return lg.AltaClasificacion(c, u);
        }

        public bool AltaLocalidad(Localidad md, Usuarios u)
        {
            return lg.AltaLocalidad(md, u);
        }

        public bool AltaTipoProducto(TipoProducto tp, Usuarios u)
        {
            return lg.AltaTipoProducto(tp, u);
        }

        public bool AltaUnidadMedida(UnidadMedida md, Usuarios u)
        {
            return lg.AltaUnidadMedida(md, u);
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

        public bool ModificacionClasificacion(Clasificacion c, Usuarios u)
        {
            return lg.ModificacionClasificacion(c, u);
        }

        public bool ModificacionTipoProducto(TipoProducto tp, Usuarios u)
        {
            return lg.ModificacionTipoProducto(tp, u);
        }

        public bool ModificacionUnidadMedida(UnidadMedida md, Usuarios u)
        {
            return lg.ModificacionUnidadMedida(md, u);
        }

        public bool ModLocalidad(Localidad md, Usuarios u)
        {
            return lg.ModLocalidad(md,u);
        }
    }
}
