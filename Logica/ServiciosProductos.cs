using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosProductos : Icrud<Producto>
    {
        private RepositorioProductos repositorioProductos;
        private List<Producto> listaProductos;

        public ServiciosProductos()
        {
            repositorioProductos = new RepositorioProductos(Configuracion.RUTA_PRODUCTOS);
        }

        public string Eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public string Guardar(Producto entidad)
        {
            return repositorioProductos.GuardarDatos(entidad);
        }

        public string Modificar(Producto entidad)
        {
            throw new NotImplementedException();
        }

        public Producto ObtenerPorId(string id)
        {
            listaProductos = repositorioProductos.CargarDatos();
            return listaProductos.Find(p => p.Id == id);
        }

        public List<Producto> ObtenerTodo()
        {
            return repositorioProductos.CargarDatos();
        }
    }
}
