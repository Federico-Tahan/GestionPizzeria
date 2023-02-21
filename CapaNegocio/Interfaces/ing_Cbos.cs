using CapaDatos.Datos;
using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaCapaNegocio.Interfaces
{
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
        List<Cliente> TraerClientesCbo(int a);
    }
}
