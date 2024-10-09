using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioMarcas : RepositorioBase<MarcaProducto>
    {
        public RepositorioMarcas(string rutaArchivo) : base(rutaArchivo)
        {
        }

        public override List<MarcaProducto> CargarDatos()
        {
            try
            {
                List<MarcaProducto> marcas = new List<MarcaProducto>();
                string linea;
                StreamReader reader = new StreamReader(_nombreArchivo);
                while (!reader.EndOfStream)
                {
                    linea = reader.ReadLine();
                    marcas.Add(Map(linea));
                }
                reader.Close();
                return marcas;
            }
            catch
            {
                return new List<MarcaProducto>();
            }
        }

        public MarcaProducto ObtenerPorId(string id)
        {
            List<MarcaProducto> marcaProductos = CargarDatos();
            return marcaProductos.Find(c => c.Id == id);
        }

        public MarcaProducto Map(string linea)
        {
            string[] datos = linea.Split(';');
            return new MarcaProducto(datos[0], datos[1]);
        }
    }
}
