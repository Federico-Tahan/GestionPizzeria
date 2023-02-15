using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaCapaNegocio.Interfaces;
using CapaDatos.Datos.Implementacion;
using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;
using CapaNegocio.Interfaces;

namespace CapaNegocio.Implementacion
{
    public class ng_Logeo : ing_Logeo
    {
        public Logeo lg;
        public ng_Logeo()
        {
            lg = new Im_Logeo();
        }
        public Usuarios GetUsuario(Usuarios u)
        {
            return lg.GetUsuario(u);
        }

        public bool Logeado(Usuarios u)
        {
            return lg.Logeado(u);
        }

        public void RegistroInicio(int usuario)
        {
            lg.RegistroInicio(usuario);
        }

        public void RegistroSalida(int usuario)
        {
            lg.RegistroSalida(usuario);
        }
    }
}
