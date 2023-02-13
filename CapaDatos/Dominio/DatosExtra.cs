using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Dominio
{
    public class DatosExtra
    {
        public DatosExtra()
        {
            RecaudoDiario = 0;
            VentasDiarias= 0;
            VentasMensuales= 0;
        }

        public decimal RecaudoDiario { get; set; }
        public int VentasDiarias { get; set; }
        public int VentasMensuales { get; set; }
    }
}
