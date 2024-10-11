using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioClientes : RepositorioBase<Persona>
    {
        RepositorioTiposDocumento repositorioTiposDocumento;
        public RepositorioClientes(string nombreArchivo) : base(nombreArchivo)
        {
            repositorioTiposDocumento = new RepositorioTiposDocumento(Configuracion.RUTA_TIPOS_IDENTIFICACIONES);
        }
        public override List<Persona> CargarDatos()
        {
            try
            {
                List<Persona> personas = new List<Persona>();
                string linea;
                StreamReader reader = new StreamReader(_nombreArchivo);
                while (!reader.EndOfStream)
                {
                    linea = reader.ReadLine();
                    personas.Add(Map(linea));
                }
                reader.Close();
                return personas;
            }
            catch
            {
                return new List<Persona>();
            }
        }

        public Persona ObtenerPorId(string id)
        {
            List<Persona> personas = CargarDatos();
            return personas.Find(c => c.NumeroIdentificacion == id);
        }

        public Persona Map(string linea)
        {
            string[] datos = linea.Split(';');
            TipoDocumento tipoDocumento = repositorioTiposDocumento.ObtenerPorId(datos[1]);
            return new Persona(datos[0], tipoDocumento, datos[2], datos[3], 
                datos[4], datos[5], datos[6], datos[7]);
        }

    }
}
