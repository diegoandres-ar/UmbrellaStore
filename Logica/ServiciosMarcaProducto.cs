using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosMarcaProducto : Icrud<MarcaProducto>
    {
        private RepositorioMarcas repositorioMarcas;
        private List<MarcaProducto> listaMarcas;

        public ServiciosMarcaProducto()
        {
            repositorioMarcas = new RepositorioMarcas(Configuracion.RUTA_MARCAS);
        }

        public string Eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public string Guardar(MarcaProducto entidad)
        {
            return repositorioMarcas.GuardarDatos(entidad);
        }

        public string Modificar(MarcaProducto entidad)
        {
            throw new NotImplementedException();
        }

        public MarcaProducto ObtenerPorId(string id)
        {
            listaMarcas = repositorioMarcas.CargarDatos();
            return listaMarcas.Find(m => m.Id == id);
        }

        public List<MarcaProducto> ObtenerTodo()
        {
            return repositorioMarcas.CargarDatos();
        }
    }
}
