using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proveedor : Persona
    {
        public List<Producto> Productos { get; set; }

        public Proveedor(string numeroIdentificacion, TipoDocumento tipoDocumento, string primerNombre,
                         string segundoNombre, string primerApellido, string segundoApellido,
                         string correoElectronico, string telefono, List<Producto> productos)
            : base(numeroIdentificacion, tipoDocumento, primerNombre, segundoNombre, primerApellido, 
                  segundoApellido, correoElectronico, telefono)
        {
            Productos = productos;
        }

        public string RecorrerProductos()
        {
            string productos = string.Empty;
            foreach (var item in Productos)
            {
                productos += $"{item.Id}-";
            }
            return productos;
        }

        public override string ToString()
        {
            return $"{NumeroIdentificacion};{TipoDocumento.Id};{PrimerNombre};" +
                $"{SegundoNombre};{PrimerApellido};{SegundoApellido};" +
                $"{CorreoElectronico};{Telefono}; + {RecorrerProductos()}";
        }
    }
}