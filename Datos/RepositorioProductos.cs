using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioProductos : RepositorioBase<Producto>
    {
        RepositorioCategoriasProductos repositorioCategoriasProductos;
        RepositorioMarcas repositorioMarcas;
        public RepositorioProductos(string rutaArchivo) : base(rutaArchivo)
        {
            repositorioCategoriasProductos = new RepositorioCategoriasProductos(Configuracion.RUTA_CATEGORIAS);
            repositorioMarcas = new RepositorioMarcas(Configuracion.RUTA_MARCAS);
        }

        public override List<Producto> CargarDatos()
        {
            try
            {
                List<Producto> productos = new List<Producto>();
                string linea;
                StreamReader reader = new StreamReader(_nombreArchivo);
                while (!reader.EndOfStream)
                {
                    linea = reader.ReadLine();
                    productos.Add(Map(linea));
                }
                reader.Close();
                return productos;
            }
            catch
            {
                return new List<Producto>();
            }
        }

        public Producto ObtenerPorId(string id)
        {
            List<Producto> productos = CargarDatos();
            return productos.Find(c => c.Id == id);
        }

        public Producto Map(string linea)
        {
            string[] datos = linea.Split(';');
            string codigo = datos[0];
            string nombre = datos[1];
            double precio = double.Parse(datos[2]);
            int cantidad = int.Parse(datos[3]);
            MarcaProducto marca = repositorioMarcas.ObtenerPorId(datos[4]);
            CategoriaProducto categoria = repositorioCategoriasProductos.ObtenerPorId(datos[5]);
            string descripcion = datos[6];
            bool estado = bool.Parse(datos[7]);
            return new Producto(codigo, nombre, precio, cantidad, marca, categoria, descripcion, estado);
        }

    }
}
