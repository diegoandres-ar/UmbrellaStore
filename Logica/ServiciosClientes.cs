using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosClientes : Icrud<Cliente>
    {
        private RepositorioClientes repositorioClientes;
        private List<Cliente> clientes;

        public ServiciosClientes()
        {
            repositorioClientes = new RepositorioClientes(Configuracion.RUTA_CLIENTES);
        }

        public string Eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public string Guardar(Cliente entidad)
        {
            return repositorioClientes.GuardarDatos(entidad);
        }

        public string Modificar(Cliente entidad)
        {
            throw new NotImplementedException();
        }

        public Cliente ObtenerPorId(string id)
        {
            clientes = repositorioClientes.CargarDatos();
            return clientes.Find(c => c.NumeroIdentificacion == id);
        }

        public List<Cliente> ObtenerTodo()
        {
            return repositorioClientes.CargarDatos();
        }
    }
}
