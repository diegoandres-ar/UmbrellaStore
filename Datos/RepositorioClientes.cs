using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioClientes : RepositorioBase<Cliente>
    {
        RepositorioTiposDocumento repositorioTiposDocumento;
        public RepositorioClientes(string rutaArchivo) : base(rutaArchivo)
        {
            repositorioTiposDocumento = new RepositorioTiposDocumento(Configuracion.RUTA_TIPOS_DOCUMENTOS);
        }

        public override List<Cliente> CargarDatos()
        {
            try
            {
                List<Cliente> clientes = new List<Cliente>();
                string linea;
                System.IO.StreamReader reader = new System.IO.StreamReader(_nombreArchivo);
                while (!reader.EndOfStream)
                {
                    linea = reader.ReadLine();
                    clientes.Add(Map(linea));
                }
                reader.Close();
                return clientes;
            }
            catch
            {
                return new List<Cliente>();
            }
        }

        public Cliente ObtenerPorId(string id)
        {
            List<Cliente> clientes = CargarDatos();
            return clientes.Find(c => c.NumeroIdentificacion == id);
        }

        public Cliente Map(string linea)
        {
            string[] datos = linea.Split(';');
            TipoDocumento tipoDocumento = repositorioTiposDocumento.ObtenerPorId(datos[1]);
            DateTime fechaCreacion = DateTime.Parse(datos[8]);
            return new Cliente(datos[0], tipoDocumento, datos[2], datos[3], datos[4],
                datos[5], datos[6], datos[7], fechaCreacion);
        }

    }
}
