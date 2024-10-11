using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosClientes : Icrud<Persona>
    {
        private RepositorioClientes repositorioClientes;
        private List<Persona> listaClientes;

        public ServiciosClientes()
        {
            repositorioClientes = new RepositorioClientes(Configuracion.RUTA_CLIENTES);
        }

        public string Eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public string Guardar(Persona entidad)
        {
            return repositorioClientes.GuardarDatos(entidad);
        }

        public string Modificar(Persona entidad)
        {
            throw new NotImplementedException();
        }

        public Persona ObtenerPorId(string id)
        {
            listaClientes = repositorioClientes.CargarDatos();
            return listaClientes.Find(c => c.NumeroIdentificacion == id);
        }

        public List<Persona> ObtenerTodo()
        {
            return repositorioClientes.CargarDatos();
        }
    }
}
