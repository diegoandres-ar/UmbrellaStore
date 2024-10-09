using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioTiposDocumento : RepositorioBase<TipoDocumento>
    {
        public RepositorioTiposDocumento(string rutaArchivo) : base(rutaArchivo)
        {
        }

        public override List<TipoDocumento> CargarDatos()
        {
            try
            {
                List<TipoDocumento> tiposIdentificaciones = new List<TipoDocumento>();
                string linea;
                StreamReader reader = new StreamReader(_nombreArchivo);
                while (!reader.EndOfStream)
                {
                    linea = reader.ReadLine();
                    tiposIdentificaciones.Add(Map(linea));
                }
                reader.Close();
                return tiposIdentificaciones;
            }
            catch
            {
                return new List<TipoDocumento>();
            }

        }

        public TipoDocumento ObtenerPorId(string id)
        {
            List<TipoDocumento> tiposIdentificaciones = CargarDatos();
            return tiposIdentificaciones.Find(t => t.Id == id);
        }

        public TipoDocumento Map(string linea)
        {
            string[] datos = linea.Split(';');
            return new TipoDocumento(datos[0], datos[1], datos[2]);
        }

    }
}
