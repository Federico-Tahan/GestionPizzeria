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
        bool AltaProducto(Producto p, Usuarios u);
        bool Modificacion(Producto p, Usuarios u);
        bool ModificacionIngrediente(Producto p, Usuarios u);
        bool AltaIngrediente(Producto p, Usuarios u);


    }
}
