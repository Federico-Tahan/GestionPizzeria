using CapaDatos.Datos;
using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaCapaNegocio.Interfaces
{
    public interface ing_Cbos
    {
        List<Roles> ObtenerRoles();
        List<Tipo_Cliente> TipoClientes();

    }
}
