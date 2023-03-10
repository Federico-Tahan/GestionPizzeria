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
{//puente entre el back y el front
    public class ng_CrudProductos: ing_CrudProductos
    {
        CrudProductos lg;
        public ng_CrudProductos()
        {
            lg = new Im_CrudProductos();
        }

        public bool AltaIngrediente(Producto p, Usuarios u)
        {
            return lg.AltaIngrediente(p,u);
        }

        public bool AltaProducto(Producto p, Usuarios u)
        {
            return lg.AltaProducto(p,u);
        }

        public List<Producto> GetProductos(int cond)
        {
            return lg.GetProductos(cond);
        }

        public bool Modificacion(Producto p, Usuarios u)
        {
            return lg.Modificacion(p,u);
        }

        public bool ModificacionIngrediente(Producto p, Usuarios u)
        {
            return lg.ModificacionIngrediente(p,u);
        }
    }
}
