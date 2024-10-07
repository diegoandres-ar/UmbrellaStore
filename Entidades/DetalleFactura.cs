using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleFactura
    {
        public string Id { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public double SubTotal { get; set; }

        public DetalleFactura(string id, Producto producto, int cantidad, double subTotal)
        {
            Id = id;
            Producto = producto;
            Cantidad = cantidad;
            SubTotal = subTotal;
        }

        public void CalcularSubTotal()
        {
            SubTotal = Producto.Precio * Cantidad;
        }

        public override string ToString()
        {
            return $"{Id};{Producto.Id};{Cantidad};{SubTotal}";
        }
    }
}
