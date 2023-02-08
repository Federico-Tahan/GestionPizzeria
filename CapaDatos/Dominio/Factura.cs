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
        public List<DetalleFactura> DetalleFacturas = new List<DetalleFactura>();

        public bool buscar(int value)
        {
            for (int i = 0; i < DetalleFacturas.Count; i++)
            {
                if (value == DetalleFacturas[i].Prod.Id_producto)
                {
                    return true;
                }
            }
            return false;
        }

        public void remover(DetalleFactura df)
        {
            DetalleFacturas.Remove(df);
        }

        public decimal Calcular_Subtotal()
        {
            decimal SubTotal = 0;
            foreach (DetalleFactura item in DetalleFacturas)
            {
                SubTotal += item.Prod.Precio * item.Cantidad;
            }

            return Math.Round(SubTotal,2);
        }
    }
}
