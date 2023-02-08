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

        public bool AltaVenta(Factura f)
        {
            return lg.AltaVenta(f);
        }
    }
}
