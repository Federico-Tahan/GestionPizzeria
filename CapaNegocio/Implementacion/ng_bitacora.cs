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
    public class ng_bitacora:ing_Bitacora
    {
        IBitacora lg;
        public ng_bitacora()
        {
            lg = new Im_Bitacora();
        }

        public Bitacora ObtenerBitacora()
        {
            return lg.ObtenerBitacora();
        }
    }
}
