using CapaDatos.Datos.Implementacion;
using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;
using CapaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Implementacion
{
    public class ng_CrudVentas : ing_CrudVentas
    {
        CrudVentas lg;
        public ng_CrudVentas()
        {
            lg = new Im_CrudVentas();
        }

        public bool AltaVenta(Factura f, Usuarios u)
        {
            return lg.AltaVenta(f, u);
        }

        public bool BuscarClienteSocioDni(Cliente c)
        {
            return lg.BuscarClienteSocioDni(c);
        }

        public Configuracion TraerConfig()
        {
            return lg.TraerConfig();
        }

        public List<DetalleFactura> TraerDetalles(int a)
        {
            return lg.TraerDetalles(a);
        }

        public List<Factura> TraerFactura()
        {
            return lg.TraerFactura();
        }
    }
}
