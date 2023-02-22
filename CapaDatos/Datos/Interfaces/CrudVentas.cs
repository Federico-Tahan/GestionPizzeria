using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Interfaces
{
    public interface CrudVentas
    {
        bool AltaVenta(Factura f, Usuarios u);
        Configuracion TraerConfig();
        bool BuscarClienteSocioDni(Cliente c);

        List<DetalleFactura> TraerDetalles(int a);
        List<Factura> TraerFactura();
        bool CancelFactura(int i);
        bool ModVenta(Factura f, Usuarios u);
    }
}
