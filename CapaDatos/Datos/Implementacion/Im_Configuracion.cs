using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Implementacion
{

    public class Im_Configuracion : IConfiguracion
    {

        //Se envian los datos de "Configuracion" para realizar la modificacion de esta y recibe un Usuario para que se registre en la bitacora
        public bool ActualizarDescuentosConfig(List<Descuento> d, Configuracion c, Usuarios u)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@dia1", d[0].PorcentajeDescuento);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@dia2", d[1].PorcentajeDescuento);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@dia3", d[2].PorcentajeDescuento);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@dia4", d[3].PorcentajeDescuento);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@dia5", d[4].PorcentajeDescuento);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@dia6", d[5].PorcentajeDescuento);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@dia7", d[6].PorcentajeDescuento);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@descuentoSocio", c.DescuentoSocios);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@descuentoPresencial", c.DescuentoPresencial);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_usuario", u.ID_Usuario);

                HelperDB.ObtenerInstancia().updatear_db("SP_ActualizarConfigDescuentos");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Actualiza las redes del local
        public bool ActualizarRedes(Configuracion c, Usuarios u)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@email", c.Email);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@instagram", c.Instagram);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@facebook", c.Facebook);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@twitter", c.Twitter);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@youtube", c.Youtube);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@contraseña", c.Contraseña);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("id_usuario", u.ID_Usuario);
                HelperDB.ObtenerInstancia().updatear_db("SP_Actualizar_Redes");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //me envia la conexion a donde la llame, la use para realiar el backup y restore
        public SqlConnection Conexion()
        {
            return HelperDB.ObtenerInstancia().conexion();
        }

        //Trae los dato de la configuracion
        public Configuracion TraerConfiguracion()
        {
            Configuracion c = new Configuracion();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_Obtener_Configuracion");
            
            if (HelperDB.ObtenerInstancia().Dr.Read())
            {
              c.DescuentoSocios = HelperDB.ObtenerInstancia().Dr.GetInt32(1);
              c.DescuentoPresencial = HelperDB.ObtenerInstancia().Dr.GetInt32(2);
              c.Email = HelperDB.ObtenerInstancia().Dr.GetString(3);
              c.Youtube = HelperDB.ObtenerInstancia().Dr.GetString(4);
              c.Instagram = HelperDB.ObtenerInstancia().Dr.GetString(5);
              c.Twitter = HelperDB.ObtenerInstancia().Dr.GetString(6);
              c.Facebook = HelperDB.ObtenerInstancia().Dr.GetString(7);
              c.Contraseña = HelperDB.ObtenerInstancia().Dr.GetString(8);
            }
            HelperDB.ObtenerInstancia().close();
            return c;
        }
        //Trae todos los descuentos
        public List<Descuento> TraerDescuentos()
        {
            List<Descuento> LDescuento = new List<Descuento>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().LeerDB("SP_Obtener_Descuentos");
            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Descuento c = new Descuento();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    c.dia = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    c.PorcentajeDescuento = Math.Round(HelperDB.ObtenerInstancia().Dr.GetDecimal(2),2);
                }

                LDescuento.Add(c);
            }
            HelperDB.ObtenerInstancia().close();
            return LDescuento;
        }
    }
}
