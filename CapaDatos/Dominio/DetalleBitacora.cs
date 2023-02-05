using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Dominio
{
    public class DetalleBitacora
    {
        public int IdBitacora { get; set; }
        public Usuarios user { get; set; }
        public DateTime Fecha_accion { get; set; }
        public string Accion { get; set; }
    }
}
