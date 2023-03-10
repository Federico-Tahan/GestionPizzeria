using CapaDatos.Datos.Implementacion;
using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;
using CapaNegocio.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Implementacion
{//puente entre el back y el front
    public class ng_Configuracion : ing_Configuracion
    {
        private IConfiguracion lg;

        public ng_Configuracion()
        {
            lg = new Im_Configuracion();
        }

        public bool ActualizarDescuentosConfig(List<Descuento> d, Configuracion c, Usuarios u)
        {
            return lg.ActualizarDescuentosConfig(d,c,u);
        }

        public bool ActualizarRedes(Configuracion c, Usuarios u)
        {
            return lg.ActualizarRedes(c,u);
        }

        public SqlConnection Conexion()
        {
            return lg.Conexion();
        }

        public Configuracion TraerConfiguracion()
        {
            return lg.TraerConfiguracion();
        }

        public List<Descuento> TraerDescuentos()
        {
            return lg.TraerDescuentos();
        }
    }
}
