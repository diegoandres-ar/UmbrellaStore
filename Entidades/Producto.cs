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
        public bool Estado { get; set; }
        public List<Proveedor> Proveedores { get; set; }

        public Producto(string id, string nombre, double precio, int stock, 
            MarcaProducto marcaProducto, CategoriaProducto categoriaProducto, 
            string descripcion, bool estado, List<Proveedor> proveedores)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            MarcaProducto = marcaProducto;
            CategoriaProducto = categoriaProducto;
            Descripcion = descripcion;
            Estado = estado;
            Proveedores = proveedores;
        }

        public string RecorrerProveedores()
        {
            string proveedores = string.Empty;
            foreach (var item in Proveedores)
            {
                proveedores += $"{item.NumeroIdentificacion}-";
            }
            return proveedores;
        }

        public override string ToString()
        {
            return $"{Id};{Nombre};{Precio};{Stock};{MarcaProducto.Id};" +
                $"{CategoriaProducto.Id};{Descripcion};{Estado};{RecorrerProveedores()}";
        }

    }
}
