using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Interfaces
{    //las interfaces sirven para crear metodos abstractos y en donde se le aplique la herencia se firma como un contrato en el cual deben estar estos metodos si o si

    public interface CrudUsuarios
    {
        bool AltaUsuario(Usuarios u, Usuarios admin);
        bool ModificarUsuario(Usuarios u, Usuarios admin);
        List<Usuarios> ObtenerUsuarios(int a);
        bool BuscarUsuario(int id);
        List<Usuarios> ObtenerUsuario(Usuarios u);

        bool BuscarDniUsuario(long dni);
        bool BuscarAliasUsuario(string alias);
        bool buscarId(int id, string alias);

        bool BloquearUsuario(string Alias);
        bool UsuarioAltaoBaja(string Alias);


    }
}
