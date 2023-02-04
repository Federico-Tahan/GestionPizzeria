using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;

namespace CapaDatos.Datos.Implementacion
{
    public class Im_Cbos : ICbos
    {
        public List<Roles> ObtenerRoles()
        {
            List<Roles> td = new List<Roles>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_Obtener_Roles");

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Roles rl = new Roles();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    rl.Id_Rol = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    rl.Rol = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    rl.Descripcion = HelperDB.ObtenerInstancia().Dr.GetString(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    rl.BajaLogica = HelperDB.ObtenerInstancia().Dr.GetInt32(3);
                }
                td.Add(rl);
            }
            HelperDB.ObtenerInstancia().close();

            return td;
        }
    }
}
