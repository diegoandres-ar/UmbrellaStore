using Datos;
using Entidades;
using System.Collections.Generic;

namespace Logica
{
    public class ServiciosDetallesElectronicos : IConsultas<DetalleElectronico>
    {
        private RepositorioDetallesElectronicos repositorioDetallesElectronicos;
        private List<DetalleElectronico> listaDetallesElectronicos;

        public ServiciosDetallesElectronicos()
        {
            repositorioDetallesElectronicos = new RepositorioDetallesElectronicos(Configuracion.RUTA_DETALLES_ELECTRONICOS);
        }
        public DetalleElectronico ObtenerPorId(string id)
        {
            listaDetallesElectronicos = repositorioDetallesElectronicos.CargarDatos();
            return listaDetallesElectronicos.Find(d => d.Id == id);
        }

        public List<DetalleElectronico> ObtenerTodo()
        {
            return repositorioDetallesElectronicos.CargarDatos();
        }
    }
}
