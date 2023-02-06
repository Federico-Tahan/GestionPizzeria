using CapaDatos.Datos.Implementacion;
using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;
using CapaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Implementacion
{
    public class ng_Cliente : ing_Cliente
    {
        ICliente lg;

        public ng_Cliente()
        {
            lg = new Im_Cliente();
        }

        public bool AltaCliente(Cliente c)
        {
            throw new NotImplementedException();
        }

        public bool ModificacionCliente(Cliente c)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> TraerClientes()
        {
            return lg.TraerClientes();
        }

        public List<Cliente> TraerClientesNoSocios()
        {
            throw new NotImplementedException();
        }

        public List<Cliente> TraerClientesSocios()
        {
            throw new NotImplementedException();
        }
    }
}
