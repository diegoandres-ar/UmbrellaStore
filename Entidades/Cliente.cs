using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        public DateTime FechaCreacion { get; set; }

        public Cliente(string numeroIdentificacion, TipoDocumento tipoDocumento, string primerNombre,
                       string segundoNombre, string primerApellido, string segundoApellido,
                       string correoElectronico, string telefono, DateTime fechaCreacion)
            : base(numeroIdentificacion, tipoDocumento, primerNombre, segundoNombre, primerApellido, segundoApellido, correoElectronico, telefono)
        {
            FechaCreacion = fechaCreacion;
        }
    }
}