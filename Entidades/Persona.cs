using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public string NumeroIdentificacion { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }

        public Persona(string numeroIdentificacion, TipoDocumento tipoDocumento, string primerNombre, 
            string segundoNombre, string primerApellido, string segundoApellido, string correoElectronico, string telefono)
        {
            NumeroIdentificacion = numeroIdentificacion;
            TipoDocumento = tipoDocumento;
            PrimerNombre = primerNombre;
            SegundoNombre = segundoNombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
        }
    }
}
