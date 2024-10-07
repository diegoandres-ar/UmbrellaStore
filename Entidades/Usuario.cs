using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Persona
    {
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public Rol Rol { get; set; }

        public Usuario(string numeroIdentificacion, TipoDocumento tipoDocumento, string primerNombre,
            string segundoNombre, string primerApellido, string segundoApellido, string correoElectronico, string telefono,
            string nombreUsuario, string contrasena, Rol rol) : base(numeroIdentificacion, tipoDocumento, primerNombre,
            segundoNombre, primerApellido, segundoApellido, correoElectronico, telefono)
        {
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            Rol = rol;
        }

        public override string ToString()
        {
            return $"{NumeroIdentificacion};{TipoDocumento.Id};{PrimerNombre};" +
                $"{SegundoNombre};{PrimerApellido};{SegundoApellido};" +
                $"{CorreoElectronico};{Telefono};" +
                $"{NombreUsuario};{Contrasena};{Rol.Id}";
        }
    }
}
