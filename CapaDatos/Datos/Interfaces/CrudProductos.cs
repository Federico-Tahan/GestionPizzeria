using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Interfaces
{
    public interface CrudProductos
    {
        List<Producto> GetProductos(int cond);
        bool AltaProducto(Producto p);
        bool Modificacion(Producto p);


    }
}
