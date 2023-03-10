using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Interfaces
{    //las interfaces sirven para crear metodos abstractos y en donde se le aplique la herencia se firma como un contrato en el cual deben estar estos metodos si o si

    public interface ITipoProdClasiUnidadMed
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
