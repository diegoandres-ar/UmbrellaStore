using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public MarcaProducto MarcaProducto { get; set; }
        public CategoriaProducto CategoriaProducto { get; set; }
        public string Descripcion { get; set; }

        public Producto(string id, string nombre, double precio, 
            int stock, MarcaProducto marcaProducto, CategoriaProducto categoriaProducto, 
            string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            MarcaProducto = marcaProducto;
            CategoriaProducto = categoriaProducto;
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return $"{Id};{Nombre};{Precio};{Stock};{MarcaProducto.Id};" +
                $"{CategoriaProducto.Id};{Descripcion}";
        }

    }
}
