using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosDetallesFactura : IConsultas<DetalleFactura>
    {
        private RepositorioDetallesFactura repositorioDetallesFactura;
        private List<DetalleFactura> listaDetallesFactura;

        public ServiciosDetallesFactura()
        {
            repositorioDetallesFactura = new RepositorioDetallesFactura(Configuracion.RUTA_DETALLES_FACTURAS);
        }

        public string Guardar(DetalleFactura entidad)
        {
            return repositorioDetallesFactura.GuardarDatos(entidad);
        }

        public DetalleFactura ObtenerPorId(string id)
        {
            listaDetallesFactura = repositorioDetallesFactura.CargarDatos();
            return listaDetallesFactura.Find(d => d.Id == id);
        }

        public List<DetalleFactura> ObtenerTodo()
        {
            return repositorioDetallesFactura.CargarDatos();
        }
    }
}
