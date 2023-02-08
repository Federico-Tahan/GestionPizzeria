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
    public class ng_CrudProductos: ing_CrudProductos
    {
        CrudProductos lg;
        public ng_CrudProductos()
        {
            lg = new Im_CrudProductos();
        }

        public bool AltaProducto(Producto p)
        {
            return lg.AltaProducto(p);
        }

        public List<Producto> GetProductos(int cond)
        {
            return lg.GetProductos(cond);
        }

        public bool Modificacion(Producto p)
        {
            return lg.Modificacion(p);
        }
    }
}
