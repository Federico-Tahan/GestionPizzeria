using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Interfaces
{
    public interface ing_Logeo
    {
        bool Logeado(Usuarios u);
        Usuarios GetUsuario(Usuarios u);
    }
}
