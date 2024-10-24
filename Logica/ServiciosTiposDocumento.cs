using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosTiposDocumento : Icrud<TipoDocumento>
    {
        private RepositorioTiposDocumento repositorioTiposDocumento;
        private List<TipoDocumento> listaTiposDocumento;

        public ServiciosTiposDocumento()
        {
            repositorioTiposDocumento = new RepositorioTiposDocumento(Configuracion.RUTA_TIPOS_DOCUMENTOS);
        }

        public string Eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public string Guardar(TipoDocumento entidad)
        {
            return repositorioTiposDocumento.GuardarDatos(entidad);
        }

        public string Modificar(TipoDocumento entidad)
        {
            throw new NotImplementedException();
        }

        public TipoDocumento ObtenerPorId(string id)
        {
            listaTiposDocumento = repositorioTiposDocumento.CargarDatos();
            return listaTiposDocumento.Find(t => t.Id == id);
        }

        public List<TipoDocumento> ObtenerTodo()
        {
            return repositorioTiposDocumento.CargarDatos();
        }
    }
}
