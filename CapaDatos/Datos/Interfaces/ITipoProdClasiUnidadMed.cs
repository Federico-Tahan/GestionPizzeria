using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Interfaces
{
    public interface ITipoProdClasiUnidadMed
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




    }
}
