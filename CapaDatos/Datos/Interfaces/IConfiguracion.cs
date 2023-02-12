using CapaDatos.Dominio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Interfaces
{
    public interface IConfiguracion
    {
        List<Descuento> TraerDescuentos();
        bool ActualizarDescuentosConfig(List<Descuento> d, Configuracion c);
        Configuracion TraerConfiguracion();
        bool ActualizarRedes(Configuracion c);

        SqlConnection Conexion();
    }
}
