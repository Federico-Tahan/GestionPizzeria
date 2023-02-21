using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Interfaces
{
    public interface ing_TipoProdClasiUnidadMed
    {
        List<TipoProducto> GetTipoProductos(int a);
        List<Clasificacion> GetClasificacion(int a);
        List<UnidadMedida> GetUnidadMedida(int a);
        bool AltaClasificacion(Clasificacion c);
        bool ModificacionClasificacion(Clasificacion c);
        bool AltaTipoProducto(TipoProducto tp);
        bool ModificacionTipoProducto(TipoProducto tp);
        bool AltaUnidadMedida(UnidadMedida md);
        bool ModificacionUnidadMedida(UnidadMedida md);
        List<Localidad> GetLocalidad(int a);

        bool AltaLocalidad(Localidad md);
        bool ModLocalidad(Localidad md);
    }
}
