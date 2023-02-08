using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Dominio
{
    public class Producto
    {
        public int Id_producto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Detalle { get; set; }
        public int Stock { get; set; }
        public UnidadMedida Unidadmedida { get; set; }
        public Clasificacion clasificacion { get; set; }
        public TipoProducto Tipo_producto { get; set; }
        public int Baja_logica { get; set; }
    }
}
