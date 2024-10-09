using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioRoles : RepositorioBase<Rol>
    {
        public RepositorioRoles(string rutaArchivo) : base(rutaArchivo)
        {
        }

        public override List<Rol> CargarDatos()
        {
            try
            {
                List<Rol> roles = new List<Rol>();
                string linea;
                StreamReader reader = new StreamReader(_nombreArchivo);
                while (!reader.EndOfStream)
                {
                    linea = reader.ReadLine();
                    roles.Add(Map(linea));
                }
                reader.Close();
                return roles;
            }
            catch
            {
                return new List<Rol>();
            }
        }

        public Rol ObtenerPorId(string id)
        {
            List<Rol> roles = CargarDatos();
            return roles.Find(r => r.Id == id);
        }
        public Rol Map(string linea)
        {
            string[] datos = linea.Split(';');
            return new Rol(datos[0], datos[1]);
        }
    }
}
