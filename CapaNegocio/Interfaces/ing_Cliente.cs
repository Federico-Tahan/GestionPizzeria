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
        List<Cliente> TraerClientesSocios();
        List<Cliente> TraerClientesNoSocios();

        bool AltaCliente(Cliente c);
        bool ModificacionCliente(Cliente c);
    }
}
