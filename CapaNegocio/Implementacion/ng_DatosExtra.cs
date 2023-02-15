using CapaDatos.Datos.Implementacion;
using CapaDatos.Datos.Interfaces;
using CapaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Implementacion
{
    public class ng_DatosExtra : ing_DatosExtra
    {
        IDatosExtra lg;
        public ng_DatosExtra()
        {
            lg = new Im_DatosExtra();
        }

        public decimal RecaudadoDiario()
        {
            return lg.RecaudadoDiario();
        }

        public int VentasdelDia()
        {
           return lg.VentasdelDia();
        }

        public int VentasdelMes()
        {
            return lg.VentasdelMes();
        }
    }
}
