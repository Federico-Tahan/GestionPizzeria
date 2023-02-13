using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Implementacion
{
    public class Im_DatosExtra : IDatosExtra
    {
        public decimal RecaudadoDiario()
        {
            DatosExtra dt = new DatosExtra();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_RecaudoDiario");

            if (HelperDB.ObtenerInstancia().Dr.Read())
            {

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    dt.RecaudoDiario = HelperDB.ObtenerInstancia().Dr.GetDecimal(0);

                }
            }
            HelperDB.ObtenerInstancia().close();

            return Math.Round(dt.RecaudoDiario,2);
        }

        public int VentasdelDia()
        {
            DatosExtra dt = new DatosExtra();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_VentasHoy");

            if (HelperDB.ObtenerInstancia().Dr.Read())
            {

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    dt.VentasDiarias = HelperDB.ObtenerInstancia().Dr.GetInt32(0);

                }
            }
            HelperDB.ObtenerInstancia().close();
            return dt.VentasDiarias;
        }

        public int VentasdelMes()
        {
            DatosExtra dt = new DatosExtra();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_VentasMes");

            if (HelperDB.ObtenerInstancia().Dr.Read())
            {

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    dt.VentasMensuales = HelperDB.ObtenerInstancia().Dr.GetInt32(0);

                }
            }
            HelperDB.ObtenerInstancia().close();
            return dt.VentasMensuales;
        }
    }
}
