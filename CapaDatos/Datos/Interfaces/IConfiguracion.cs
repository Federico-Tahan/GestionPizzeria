using CapaDatos.Dominio;
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
    }
}
