using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Interfaces
{
    public interface ICbos
    {
        List<Roles> ObtenerRoles();
        List<Tipo_Cliente> TraerTipoClientes();
    }
}
