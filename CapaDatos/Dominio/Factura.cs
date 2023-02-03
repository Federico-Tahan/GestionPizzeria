using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Dominio
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente cliente { get; set; }
        public Usuarios Usuario { get; set; }
        public FormaCompra Forma_Compra { get; set; }
        public FormaEntrega FormaEntrega { get; set; }
        public Descuento descuento { get; set; }
    }
}
