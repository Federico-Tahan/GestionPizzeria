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

        public List<Clasificacion> GetClasificacion(int a)
        {
            return lg.GetClasificacion(a);
        }

        public List<TipoProducto> GetTipoProductos(int a)
        {
            return lg.GetTipoProductos(a);
        }

        public List<UnidadMedida> GetUnidadMedida(int a)
        {
            return lg.GetUnidadMedida(a);
        }
    }
}
