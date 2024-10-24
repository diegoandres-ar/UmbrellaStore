using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosProveedores : Icrud<Proveedor>
    {
        private RepositorioProveedores repositorioProveedores;
        private List<Proveedor> proveedores;

        public ServiciosProveedores()
        {
            repositorioProveedores = new RepositorioProveedores(Configuracion.RUTA_PROVEEDORES);
        }

        public string Eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public string Guardar(Proveedor entidad)
        {
            return repositorioProveedores.GuardarDatos(entidad);
        }

        public string Modificar(Proveedor entidad)
        {
            throw new NotImplementedException();
        }

        public Proveedor ObtenerPorId(string id)
        {
            proveedores = repositorioProveedores.CargarDatos();
            return proveedores.Find(p => p.NumeroIdentificacion == id);
        }

        public List<Proveedor> ObtenerTodo()
        {
            return repositorioProveedores.CargarDatos();
        }

        public List<Producto> ObtenerProductosProveedor(Proveedor proveedor)
        {
            List<Producto> productosProveedor = new List<Producto>();
            foreach (var producto in proveedor.Productos)
            {
                productosProveedor.Add(producto);
            }
            return productosProveedor;
        }

    }
}
