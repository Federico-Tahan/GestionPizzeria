using CapaDatos.Datos;
using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaCapaNegocio.Interfaces
{//las interfaces sirven para crear metodos abstractos y en donde se le aplique la herencia se firma como un contrato en el cual deben estar estos metodos si o si
    public interface ing_Cbos
    {
        List<Roles> ObtenerRoles();
        List<Tipo_Cliente> TipoClientes();
        List<FormaCompra> TipoCompra();
        List<FormaEntrega> TipoEntregas();

        List<Clasificacion> ObtenerClasificacion();
        List<TipoProducto> ObtenerTipoProducto();
        List<Localidad> Localidad();

        List<UnidadMedida> ObtenerUnidadMedida();
        Cliente TraerClientesCbo(long a, Cliente rl);

    }
}
