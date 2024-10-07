using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MedioPago
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public MedioPago(string id, string nombre, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return $"{Id};{Nombre};{Descripcion}";
        }

    }
}
