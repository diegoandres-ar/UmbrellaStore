using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosUsuarios : Icrud<Usuario>
    {
        private RepositorioUsuarios repositorioUsuarios;
        private List<Usuario> listaUsuarios;

        public ServiciosUsuarios()
        {
            repositorioUsuarios = new RepositorioUsuarios(Configuracion.RUTA_USUARIOS);
        }

        public string Eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public string Guardar(Usuario entidad)
        {
            return repositorioUsuarios.GuardarDatos(entidad);
        }

        public string Modificar(Usuario entidad)
        {
            throw new NotImplementedException();
        }

        public Usuario ObtenerPorId(string id)
        {
            listaUsuarios = repositorioUsuarios.CargarDatos();
            return listaUsuarios.Find(u => u.NumeroIdentificacion == id);
        }

        public List<Usuario> ObtenerTodo()
        {
            return repositorioUsuarios.CargarDatos();
        }
    }
}
