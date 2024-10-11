using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosMediosPago : Icrud<MedioPago>
    {
        private RepositorioMediosPago repositorioMediosPago;
        private List<MedioPago> listaMediosPago;
        public ServiciosMediosPago()
        {
            repositorioMediosPago = new RepositorioMediosPago(Configuracion.RUTA_MEDIOS_PAGOS);
        }
        public string Eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public string Guardar(MedioPago entidad)
        {
            return repositorioMediosPago.GuardarDatos(entidad);
        }

        public string Modificar(MedioPago entidad)
        {
            throw new NotImplementedException();
        }

        public MedioPago ObtenerPorId(string id)
        {
            listaMediosPago = repositorioMediosPago.CargarDatos();
            return listaMediosPago.Find(m => m.Id == id);
        }

        public List<MedioPago> ObtenerTodo()
        {
            return repositorioMediosPago.CargarDatos();
        }
    }
}
