using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Dominio
{
    public class DetalleFactura
    {
        public int IdDetalleFactura { get; set; }
        public int NroFactura { get; set; }
        public Producto Prod { get; set; }
        public int Cantidad { get; set; }
        public decimal Importe { get; set; }
        public string Descripcion { get; set; }
        public int BajaLogica { get; set; }
    }
}
