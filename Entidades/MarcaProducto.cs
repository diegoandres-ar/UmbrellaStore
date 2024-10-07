using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MarcaProducto
    {
        public string Id { get; set; }
        public string Nombre { get; set; }

        public MarcaProducto(string id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return $"{Id};{Nombre}";
        }

    }
}
