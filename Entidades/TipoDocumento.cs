using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoDocumento
    {
        public string Id { get; set; }
        public string Nombre {  get; set; }
        public string Descripcion { get; set; }

        public TipoDocumento(string id, string nombre, string descripcion)
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
