using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaCapaNegocio.Interfaces;
using CapaDatos.Datos;
using CapaDatos.Datos.Implementacion;
using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;

namespace CapaNegocio.Implementacion
{
    public class ng_Cbos : ing_Cbos
    {

        private ICbos lg;

        public ng_Cbos()
        {
            lg = new Im_Cbos();
        }

        public List<Localidad> Localidad()
        {
            return lg.Localidades();
        }

        public List<Clasificacion> ObtenerClasificacion()
        {
            return lg.ObtenerClasificacion();
        }

        public List<Roles> ObtenerRoles()
        {
            return lg.ObtenerRoles();
        }

        public List<TipoProducto> ObtenerTipoProducto()
        {
            return lg.ObtenerTipoProducto();
        }

        public List<UnidadMedida> ObtenerUnidadMedida()
        {
            return lg.ObtenerUnidadMedida();
        }

        public List<Tipo_Cliente> TipoClientes()
        {
            return lg.TraerTipoClientes();
        }

        public List<FormaCompra> TipoCompra()
        {
            return lg.TipoCompra();
        }

        public List<FormaEntrega> TipoEntregas()
        {
            return lg.TipoEntregas();
        }


        public Cliente TraerClientesCbo(long a, Cliente rl)
        {
            return lg.TraerClientesCbo(a,rl);
        }
    }
}
