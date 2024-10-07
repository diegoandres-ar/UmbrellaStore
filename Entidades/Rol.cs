using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rol
    {
        public string Id { get; set; }
        public string Nombre { get; set; }

        public Rol(string id, string nombre)
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
