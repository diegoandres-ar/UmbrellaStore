using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioFacturas : RepositorioBase<Factura>
    {
        RepositorioClientes repositorioClientes;
        RepositorioUsuarios repositorioUsuarios;
        RepositorioDetallesFactura repositorioDetallesFactura;
        RepositorioDetallesElectronicos repositorioDetallesElectronicos;

        public RepositorioFacturas(string rutaArchivo) : base(rutaArchivo)
        {
            repositorioClientes = new RepositorioClientes(Configuracion.RUTA_CLIENTES);
            repositorioUsuarios = new RepositorioUsuarios(Configuracion.RUTA_USUARIOS);
            repositorioDetallesFactura = new RepositorioDetallesFactura(Configuracion.RUTA_DETALLES_FACTURAS);
            repositorioDetallesElectronicos = new RepositorioDetallesElectronicos(Configuracion.RUTA_DETALLES_ELECTRONICOS);
        }

        public override List<Factura> CargarDatos()
        {
            try
            {
                List<Factura> facturas = new List<Factura>();
                string linea;
                StreamReader reader = new StreamReader(_nombreArchivo);
                while (!reader.EndOfStream)
                {
                    linea = reader.ReadLine();
                    facturas.Add(Map(linea));
                }
                reader.Close();
                return facturas;
            }
            catch
            {
                return new List<Factura>();
            }
        }

        public Factura Map(string linea)
        {
            string[] datos = linea.Split(';');
            string id = datos[0];
            Persona cliente = repositorioClientes.ObtenerPorId(datos[1]);
            Usuario usuario = repositorioUsuarios.ObtenerPorId(datos[2]);
            DateTime fecha = DateTime.Parse(datos[3]);
            List<DetalleFactura> detalles = repositorioDetallesFactura.ObtenerItems(datos[5]);
            double totalImpuesto = double.Parse(datos[6]);
            double totalAbsoluto = double.Parse(datos[7]);
            DetalleElectronico detalleElectronico = repositorioDetallesElectronicos.ObtenerPorId(datos[8]);
            return new Factura(id, usuario, cliente, fecha, 
                detalles, totalImpuesto, totalAbsoluto, detalleElectronico);
        }
    }
}
