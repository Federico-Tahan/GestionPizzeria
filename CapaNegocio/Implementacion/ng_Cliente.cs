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

        public bool AltaClienteNosocio(Cliente c, Usuarios u)
        {
            return lg.AltaClienteNosocio(c, u);
        }

        public bool AltaClienteSocio(Cliente c, Usuarios u)
        {
            return lg.AltaClienteSocio(c, u);
        }

        public bool AltaSocio(Cliente c, Usuarios u)
        {
            return lg.AltaSocio(c,u);
        }

        public bool BuscarCliente(Cliente c)
        {
            return lg.BuscarCliente(c);
        }

        public bool BuscarClienteSocioDni(Cliente c)
        {
            return lg.BuscarClienteSocioDni(c);
        }

        public bool EliminarCliente(int c, Usuarios u)
        {
            return lg.EliminarCliente(c,u);
        }

        public bool EmailSender(Cliente c)
        {
            return lg.EmailSender(c);
        }

        public bool ModificacionCliente(Cliente c, Usuarios u)
        {
            return lg.ModificacionCliente(c,u);
        }

        public List<Cliente> TraerClientes()
        {
            return lg.TraerClientes();

        }
    }
}
