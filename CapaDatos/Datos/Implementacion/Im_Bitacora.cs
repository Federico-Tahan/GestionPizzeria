using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Implementacion
{
    public class Im_Bitacora : IBitacora
    {
        //Trae los datos de la bitacora
        public Bitacora ObtenerBitacora()
        {
            Bitacora td = new Bitacora();
            List<DetalleBitacora> list = new List<DetalleBitacora>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_Obtener_Bitacora");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                DetalleBitacora rl = new DetalleBitacora();
                Usuarios u = new Usuarios();
                Empleado e = new Empleado();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    rl.IdBitacora = HelperDB.ObtenerInstancia().Dr.GetInt32(0);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    u.ID_Usuario= HelperDB.ObtenerInstancia().Dr.GetInt32(1);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    e.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(2);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    e.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(3);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    rl.Fecha_accion = HelperDB.ObtenerInstancia().Dr.GetDateTime(4);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    rl.Accion = HelperDB.ObtenerInstancia().Dr.GetString(5);

                }
                u.Empleado = e;
                rl.user = u;
                list.Add(rl);
            }
            td.DetalleBit = list;
            HelperDB.ObtenerInstancia().close();

            return td;
        }
        

    }
}
