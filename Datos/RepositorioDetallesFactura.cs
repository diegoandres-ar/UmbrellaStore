using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioDetallesFactura : RepositorioBase<DetalleFactura>
    {
        RepositorioProductos repositorioProductos;
        public RepositorioDetallesFactura(string rutaArchivo) : base(rutaArchivo)
        {
            repositorioProductos = new RepositorioProductos(Configuracion.RUTA_PRODUCTOS);
        }

        public override List<DetalleFactura> CargarDatos()
        {
            try
            {
                List<DetalleFactura> detallesFactura = new List<DetalleFactura>();
                string linea;
                StreamReader reader = new StreamReader(_nombreArchivo);
                while (!reader.EndOfStream)
                {
                    linea = reader.ReadLine();
                    detallesFactura.Add(Map(linea));
                }
                reader.Close();
                return detallesFactura;
            }
            catch
            {
                return new List<DetalleFactura>();
            }

        }

        public DetalleFactura ObtenerPorId(string id)
        {
            List<DetalleFactura> detallesFactura = CargarDatos();
            return detallesFactura.Find(d => d.Id == id);
        }

        public List<DetalleFactura> ObtenerItems(string linea)
        {
            string[] datos = linea.Split('-');
            List<DetalleFactura> detallesFactura = new List<DetalleFactura>();
            foreach (string item in datos)
            {
                detallesFactura.Add(Map(item));
            }
            return detallesFactura;
        }

        public DetalleFactura Map(string linea)
        {
            string[] datos = linea.Split(';');
            string id = datos[0];
            Producto producto = repositorioProductos.ObtenerPorId(datos[1]);
            int cantidad = int.Parse(datos[2]);
            double subtotal = double.Parse(datos[3]);
            return new DetalleFactura(id, producto, cantidad, subtotal);
        }

    }
}
