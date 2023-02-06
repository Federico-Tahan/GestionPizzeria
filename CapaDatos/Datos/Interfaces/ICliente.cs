using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Interfaces
{
    public interface ICliente
    {

        List<Cliente> TraerClientes();
        List<Cliente> TraerClientesSocios();
        List<Cliente> TraerClientesNoSocios();

        bool AltaCliente(Cliente c);
        bool ModificacionCliente(Cliente c);
    }
}
