using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Dominio
{
    public class Configuracion
    {
        public Configuracion()
        {
            Email = string.Empty;
            Contraseña = string.Empty;
            Youtube = string.Empty;
            Twitter = string.Empty;
            Instagram = string.Empty;
            Facebook = string.Empty;
            DescuentoSocios = 0;
            DescuentoPresencial = 0;
            PorcentajeDescuentoHoy = 0;
        }

        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string Youtube { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }
        public int DescuentoSocios { get; set; }
        public int DescuentoPresencial { get; set; }
        public int PorcentajeDescuentoHoy { get; set; }

    }
}
