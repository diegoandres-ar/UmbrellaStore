using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioProveedores : RepositorioBase<Proveedor>
    {
        RepositorioTiposDocumento repositorioTiposDocumento;
        RepositorioProductos repositorioProductos;
        public RepositorioProveedores(string rutaArchivo) : base(rutaArchivo)
        {
            repositorioTiposDocumento = new RepositorioTiposDocumento(Configuracion.RUTA_TIPOS_DOCUMENTOS);
            repositorioProductos = new RepositorioProductos(Configuracion.RUTA_PRODUCTOS);
        }

        public override List<Proveedor> CargarDatos()
        {
            try
            {
                List<Proveedor> proveedores = new List<Proveedor>();
                string linea;
                StreamReader reader = new StreamReader(_nombreArchivo);
                while (!reader.EndOfStream)
                {
                    linea = reader.ReadLine();
                    proveedores.Add(Map(linea));
                }
                reader.Close();
                return proveedores;
            }
            catch
            {
                return new List<Proveedor>();
            }
        }

        public Proveedor ObtenerPorId(string id)
        {
            return CargarDatos().Find(p => p.NumeroIdentificacion == id);
        }
        public List<Proveedor> ObtenerProveedores(string linea)
        {
            return linea.Split('-').Select(id => ObtenerPorId(id)).ToList();
        }

        public Proveedor Map(string linea)
        {
            string[] datos = linea.Split(';');
            TipoDocumento tipoDocumento = repositorioTiposDocumento.ObtenerPorId(datos[1]);
            List<Producto> productos = repositorioProductos.ObtenerProductos(datos[8]);
            return new Proveedor(datos[0], tipoDocumento, datos[2], datos[3], 
                datos[4], datos[5], datos[6], datos[7], productos);
        }

    }
}
