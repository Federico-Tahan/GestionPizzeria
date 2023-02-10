using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Interfaces
{
    public interface ing_CrudVentas
    {
        bool AltaVenta(Factura f);
        Configuracion TraerConfig();
        bool BuscarClienteSocioDni(Cliente c);
        List<Factura> TraerFactura();
        List<DetalleFactura> TraerDetalles(int a);
    }
}
