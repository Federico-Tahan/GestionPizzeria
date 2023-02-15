using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Interfaces
{
    public interface Logeo
    {
        bool Logeado(Usuarios u);
        Usuarios GetUsuario(Usuarios u);

        void RegistroInicio(int usuario);
        void RegistroSalida(int usuario);
    }
}
