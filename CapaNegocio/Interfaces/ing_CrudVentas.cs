using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Interfaces
{//las interfaces sirven para crear metodos abstractos y en donde se le aplique la herencia se firma como un contrato en el cual deben estar estos metodos si o si
    public interface ing_CrudVentas
    {
        bool AltaVenta(Factura f,Usuarios u);
        Configuracion TraerConfig();
        bool BuscarClienteSocioDni(Cliente c);
        List<Factura> TraerFactura(int a);
        List<DetalleFactura> TraerDetalles(int a);
        bool CancelarVenta(int i, Usuarios u);
        bool ModVenta(Factura f, Usuarios u);
    }
}
