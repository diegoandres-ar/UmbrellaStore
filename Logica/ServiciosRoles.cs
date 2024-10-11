using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosRoles : Icrud<Rol>
    {
        private RepositorioRoles repositorioRoles;
        private List<Rol> listaRoles;

        public ServiciosRoles()
        {
            repositorioRoles = new RepositorioRoles(Configuracion.RUTA_ROLES);
        }

        public string Eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public string Guardar(Rol entidad)
        {
            return repositorioRoles.GuardarDatos(entidad);
        }

        public string Modificar(Rol entidad)
        {
            throw new NotImplementedException();
        }

        public Rol ObtenerPorId(string id)
        {
            listaRoles = repositorioRoles.CargarDatos();
            return listaRoles.Find(r => r.Id == id);
        }

        public List<Rol> ObtenerTodo()
        {
            return repositorioRoles.CargarDatos();
        }
    }
}
