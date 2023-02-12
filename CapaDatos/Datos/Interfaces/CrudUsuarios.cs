using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Interfaces
{
    public interface CrudUsuarios
    {
        bool AltaUsuario(Usuarios u, Usuarios admin);
        bool ModificarUsuario(Usuarios u, Usuarios admin);
        List<Usuarios> ObtenerUsuarios(int a);
        bool BuscarUsuario(int id);

        bool BuscarDniUsuario(long dni);
        bool BuscarAliasUsuario(string alias);
        bool buscarId(int id, string alias);


    }
}
