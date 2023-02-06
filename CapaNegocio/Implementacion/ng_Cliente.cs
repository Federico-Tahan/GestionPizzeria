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

        public bool AltaClienteNosocio(Cliente c)
        {
            return lg.AltaClienteNosocio(c);
        }

        public bool AltaClienteSocio(Cliente c)
        {
            return lg.AltaClienteSocio(c);
        }

        public bool AltaSocio(Cliente c)
        {
            return lg.AltaSocio(c);
        }

        public bool BuscarCliente(Cliente c)
        {
            return lg.BuscarCliente(c);
        }

        public bool BuscarClienteSocioDni(Cliente c)
        {
            return lg.BuscarClienteSocioDni(c);
        }

        public bool ModificacionCliente(Cliente c)
        {
            return lg.ModificacionCliente(c);
        }

        public List<Cliente> TraerClientes()
        {
            return lg.TraerClientes();

        }
    }
}
