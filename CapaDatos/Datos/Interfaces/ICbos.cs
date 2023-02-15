using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Interfaces
{
    public interface ICbos
    {
        List<Roles> ObtenerRoles();
        List<Tipo_Cliente> TraerTipoClientes();
        List<Clasificacion> ObtenerClasificacion();
        List<TipoProducto> ObtenerTipoProducto();
        List<UnidadMedida> ObtenerUnidadMedida();
        List<FormaCompra> TipoCompra();
        List<FormaEntrega> TipoEntregas();
        List<Cliente> TraerClientesCbo(int a);

    }
}
