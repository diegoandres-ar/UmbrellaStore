using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioUsuarios : RepositorioBase<Usuario>
    {
        RepositorioTiposDocumento repositorioTiposDocumento;
        RepositorioRoles repositorioRoles;
        public RepositorioUsuarios(string rutaArchivo) : base(rutaArchivo)
        {
            repositorioTiposDocumento = new RepositorioTiposDocumento(Configuracion.RUTA_TIPOS_IDENTIFICACIONES);
            repositorioRoles = new RepositorioRoles(Configuracion.RUTA_ROLES);
        }

        public override List<Usuario> CargarDatos()
        {
            try
            {
                List<Usuario> usuarios = new List<Usuario>();
                string linea;
                StreamReader reader = new StreamReader(_nombreArchivo);
                while (!reader.EndOfStream)
                {
                    linea = reader.ReadLine();
                    usuarios.Add(Map(linea));
                }
                reader.Close();
                return usuarios;
            }
            catch
            {
                return new List<Usuario>();
            }
        }

        public Usuario ObtenerPorId(string id)
        {
            List<Usuario> usuarios = CargarDatos();
            return usuarios.Find(u => u.NumeroIdentificacion == id);
        }

        public Usuario Map(string linea)
        {
            string[] datos = linea.Split(';');
            string numeroIdentificacion = datos[0];
            TipoDocumento tipoDocumento = repositorioTiposDocumento.ObtenerPorId(datos[1]);
            string primerNombre = datos[2];
            string segundoNombre = datos[3];
            string primerApellido = datos[4];
            string segundoApellido = datos[5];
            string correoElectronico = datos[6];
            string telefono = datos[7];
            string nombreUsuario = datos[8];
            string contrasena = datos[9];
            Rol rol = repositorioRoles.ObtenerPorId(datos[10]);
            return new Usuario(numeroIdentificacion, tipoDocumento, primerNombre, 
                segundoNombre, primerApellido, segundoApellido, correoElectronico, 
                telefono, nombreUsuario, contrasena, rol);
        }

    }
}
