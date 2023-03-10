using CapaDatos.Dominio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Interfaces
{//las interfaces sirven para crear metodos abstractos y en donde se le aplique la herencia se firma como un contrato en el cual deben estar estos metodos si o si
    public interface ing_Configuracion
    {
        List<Descuento> TraerDescuentos();
        bool ActualizarDescuentosConfig(List<Descuento> d, Configuracion c, Usuarios u);
        Configuracion TraerConfiguracion();
        bool ActualizarRedes(Configuracion c, Usuarios u);
        SqlConnection Conexion();

    }
}
