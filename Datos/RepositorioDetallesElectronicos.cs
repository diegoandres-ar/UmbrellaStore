using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioDetallesElectronicos : RepositorioBase<DetalleElectronico>
    {
        RepositorioMediosPago repositorioMediosPagos;
        public RepositorioDetallesElectronicos(string rutaArchivo) : base(rutaArchivo)
        {
            repositorioMediosPagos = new RepositorioMediosPago(Configuracion.RUTA_MEDIOS_PAGOS);
        }

        public override List<DetalleElectronico> CargarDatos()
        {
            try
            {
                List<DetalleElectronico> detallesElectronicos = new List<DetalleElectronico>();
                string linea;
                StreamReader reader = new StreamReader(_nombreArchivo);
                while (!reader.EndOfStream)
                {
                    linea = reader.ReadLine();
                    detallesElectronicos.Add(Map(linea));
                }
                reader.Close();
                return detallesElectronicos;
            }
            catch
            {
                return new List<DetalleElectronico>();
            }
        }

        public DetalleElectronico Map(string linea)
        {
            string[] datos = linea.Split(';');
            string id = datos[0];
            string formaPago = datos[1];
            MedioPago medioPago = repositorioMediosPagos.ObtenerPorId(datos[2]);
            double iva = double.Parse(datos[3]);
            double impuestoConsumo = double.Parse(datos[4]);
            return new DetalleElectronico(id, formaPago, medioPago, iva, impuestoConsumo);
        }
    }
}
