using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioCategoriasProductos : RepositorioBase<CategoriaProducto>
    {
        public RepositorioCategoriasProductos(string rutaArchivo) : base(rutaArchivo)
        {
        }

        public override List<CategoriaProducto> CargarDatos()
        {
            try
            {
                List<CategoriaProducto> categoriasProductos = new List<CategoriaProducto>();
                string linea;
                StreamReader reader = new StreamReader(_nombreArchivo);
                while (!reader.EndOfStream)
                {
                    linea = reader.ReadLine();
                    categoriasProductos.Add(Map(linea));
                }
                reader.Close();
                return categoriasProductos;
            }
            catch
            {
                return new List<CategoriaProducto>();
            }
        }

        public CategoriaProducto Map(string linea)
        {
            string[] datos = linea.Split(';');
            return new CategoriaProducto(datos[0], datos[1], datos[2]);
        }

        public CategoriaProducto ObtenerPorId(string id)
        {
            List<CategoriaProducto> categoriaProductos = CargarDatos();
            return categoriaProductos.Find(c => c.Id == id);
        }

    }

}
