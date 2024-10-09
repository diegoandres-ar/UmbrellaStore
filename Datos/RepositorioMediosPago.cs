using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioMediosPago : RepositorioBase<MedioPago>
    {
        public RepositorioMediosPago(string rutaArchivo) : base(rutaArchivo)
        {
        }

        public override List<MedioPago> CargarDatos()
        {
            try
            {
                List<MedioPago> mediosPagos = new List<MedioPago>();
                string linea;
                StreamReader reader = new StreamReader(_nombreArchivo);
                while (!reader.EndOfStream)
                {
                    linea = reader.ReadLine();
                    mediosPagos.Add(Map(linea));
                }
                reader.Close();
                return mediosPagos;
            }
            catch
            {
                return new List<MedioPago>();
            }
        }

        public MedioPago ObtenerPorId(string id)
        {
            List<MedioPago> medioPagos = CargarDatos();
            return medioPagos.Find(medioPago => medioPago.Id == id);
        }

        public MedioPago Map(string linea)
        {
            string[] datos = linea.Split(';');
            return new MedioPago(datos[0], datos[1], datos[1]);
        }

    }
}
