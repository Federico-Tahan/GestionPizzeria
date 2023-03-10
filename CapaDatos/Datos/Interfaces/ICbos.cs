using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Interfaces
{    //las interfaces sirven para crear metodos abstractos y en donde se le aplique la herencia se firma como un contrato en el cual deben estar estos metodos si o si

    public interface ICbos
    {
        List<Roles> ObtenerRoles();
        List<Tipo_Cliente> TraerTipoClientes();
        List<Clasificacion> ObtenerClasificacion();
        List<TipoProducto> ObtenerTipoProducto();
        List<UnidadMedida> ObtenerUnidadMedida();
        List<FormaCompra> TipoCompra();
        List<FormaEntrega> TipoEntregas();
        List<Localidad> Localidades();

        Cliente TraerClientesCbo(long a, Cliente rl);

    }
}
