using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Interfaces
{//las interfaces sirven para crear metodos abstractos y en donde se le aplique la herencia se firma como un contrato en el cual deben estar estos metodos si o si
    public interface ing_Cliente
    {
        List<Cliente> TraerClientes();
        bool AltaClienteSocio(Cliente c, Usuarios u);
        bool AltaClienteNosocio(Cliente c, Usuarios u);

        bool AltaSocio(Cliente c, Usuarios u);
        bool ModificacionCliente(Cliente c, Usuarios u);

        bool BuscarClienteSocioDni(Cliente c);
        bool BuscarCliente(Cliente c);
        bool EmailSender(Cliente c);
        bool EliminarCliente(int c, Usuarios u);



    }
}
