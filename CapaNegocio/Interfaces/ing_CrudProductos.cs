using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Interfaces
{
    public interface ing_CrudProductos
    {
        List<Producto> GetProductos(int cond);
        bool AltaProducto(Producto p, Usuarios u);
        bool Modificacion(Producto p, Usuarios u);

    }
}
