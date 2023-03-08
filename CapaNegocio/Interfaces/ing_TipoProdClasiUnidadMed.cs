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
        bool AltaClasificacion(Clasificacion c, Usuarios u);
        bool ModificacionClasificacion(Clasificacion c, Usuarios u);
        bool AltaTipoProducto(TipoProducto tp, Usuarios u);
        bool ModificacionTipoProducto(TipoProducto tp, Usuarios u);
        bool AltaUnidadMedida(UnidadMedida md, Usuarios u);
        bool ModificacionUnidadMedida(UnidadMedida md, Usuarios u);
        List<Localidad> GetLocalidad(int a);

        bool AltaLocalidad(Localidad md, Usuarios u);
        bool ModLocalidad(Localidad md, Usuarios u);
    }
}
