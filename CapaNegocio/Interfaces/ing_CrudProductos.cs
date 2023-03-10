using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Interfaces
{//las interfaces sirven para crear metodos abstractos y en donde se le aplique la herencia se firma como un contrato en el cual deben estar estos metodos si o si
    public interface ing_CrudProductos
    {
        List<Producto> GetProductos(int cond);
        bool AltaProducto(Producto p, Usuarios u);
        bool Modificacion(Producto p, Usuarios u);
        bool ModificacionIngrediente(Producto p, Usuarios u);
        bool AltaIngrediente(Producto p, Usuarios u);

    }
}
