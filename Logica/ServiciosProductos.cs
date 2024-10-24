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
        private RepositorioProveedores repositorioProveedores;
        private List<Proveedor> proveedores;

        public ServiciosProductos()
        {
            repositorioProductos = new RepositorioProductos(Configuracion.RUTA_PRODUCTOS);
            repositorioProveedores = new RepositorioProveedores(Configuracion.RUTA_PROVEEDORES);
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

        public List<Proveedor> ObtenerProveedoresProducto(Producto producto)
        {
            //List<Proveedor> proveedoresProducto = new List<Proveedor>();
            //foreach (var proveedor in proveedores)
            //{
            //    foreach (var prod in proveedor.Productos)
            //    {
            //        if (prod.Id == producto.Id)
            //        {
            //            proveedoresProducto.Add(proveedor);
            //            break;
            //        }
            //    }
            //}
            proveedores = repositorioProveedores.CargarDatos();
            var proveedoresProducto = proveedores
            .Where(proveedor => proveedor.Productos.Any(prod => prod.Id == producto.Id))
                    .ToList();
            return proveedoresProducto;
        }

    }
}
