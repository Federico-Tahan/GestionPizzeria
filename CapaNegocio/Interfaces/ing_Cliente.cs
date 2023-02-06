using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Interfaces
{
    public interface ing_Cliente
    {
        List<Cliente> TraerClientes();
        bool AltaClienteSocio(Cliente c);
        bool AltaClienteNosocio(Cliente c);

        bool AltaSocio(Cliente c);
        bool ModificacionCliente(Cliente c);

        bool BuscarClienteSocioDni(Cliente c);
        bool BuscarCliente(Cliente c);


    }
}
