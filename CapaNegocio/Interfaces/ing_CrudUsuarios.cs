using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio.Interfaces
{
    public interface ing_CrudUsuarios
    {
        bool AltaUsuario(Usuarios u);
        bool ModificarUsuario(Usuarios u);
        List<Usuarios> ObtenerUsuarios();
    }
}
