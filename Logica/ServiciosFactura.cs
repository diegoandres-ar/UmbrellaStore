using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosFactura : Icrud<Factura>
    {
        private RepositorioFacturas repositorioFacturas;
        private List<Factura> listaFacturas;

        public ServiciosFactura()
        {
            repositorioFacturas = new RepositorioFacturas(Configuracion.RUTA_FACTURAS);
        }

        public string Eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public string Guardar(Factura entidad)
        {
            return repositorioFacturas.GuardarDatos(entidad);
        }

        public string Modificar(Factura entidad)
        {
            throw new NotImplementedException();
        }

        public Factura ObtenerPorId(string id)
        {
            listaFacturas = repositorioFacturas.CargarDatos();
            return listaFacturas.Find(f => f.Id == id);
        }

        public List<Factura> ObtenerTodo()
        {
            return repositorioFacturas.CargarDatos();
        }

        public List<Factura> FiltrarPorFecha(DateTime FechaInicio, DateTime FechaFin)
        {
            listaFacturas = repositorioFacturas.CargarDatos();
            return listaFacturas.FindAll(f => f.Fecha >= FechaInicio && f.Fecha <= FechaFin);
        }

    }
}
