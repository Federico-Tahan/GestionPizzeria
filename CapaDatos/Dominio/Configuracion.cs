using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Dominio
{
    public class Configuracion
    {
        public string Email { get; set; }
        public string Youtube { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }
        public int DescuentoSocios { get; set; }
        public int DescuentoPresencial { get; set; }

    }
}
