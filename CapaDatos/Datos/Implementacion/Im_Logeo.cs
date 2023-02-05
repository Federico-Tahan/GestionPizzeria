using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;

namespace CapaDatos.Datos.Implementacion
{
    public class Im_Logeo : Logeo
    {

        public Usuarios GetUsuario(Usuarios u)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@usuario", u.Alias);
                HelperDB.ObtenerInstancia().LeerDB("");
                HelperDB.ObtenerInstancia().Dr.Read();
                Empleado em = new Empleado();

                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    u.ID_Usuario = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    em.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(1);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    em.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    em.DNI = HelperDB.ObtenerInstancia().Dr.GetInt64(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    em.Direccion = HelperDB.ObtenerInstancia().Dr.GetString(4);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    em.FechaNacimiento = HelperDB.ObtenerInstancia().Dr.GetDateTime(5);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    em.Telefono = HelperDB.ObtenerInstancia().Dr.GetInt64(6);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    em.Baja_logica = HelperDB.ObtenerInstancia().Dr.GetInt32(7);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(8))
                {
                    u.Baja_Logica = HelperDB.ObtenerInstancia().Dr.GetInt32(8);
                }
                u.Empleado = em;
            }
            catch (Exception ex)
            {

            }
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().close();
            return u;
        }

        public bool Logeado(Usuarios u)
        {
            Encriptacion e = new Encriptacion();

            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@alias", u.Alias);
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@contraseña", e.Encriptar(u.Contraseña));
            HelperDB.ObtenerInstancia().LeerDB("SP_Verificar_Login");

            if (HelperDB.ObtenerInstancia().Dr.Read())
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().close();
                return true;
            }
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().close();
            return false;
        }

    }
}
