using Datos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Logica
{
    public class ServiciosCategoriaProducto : Icrud<CategoriaProducto>
    {
        private RepositorioCategoriasProductos repositorioCategoriasProductos;
        private List<CategoriaProducto> listaCategoriasProductos;

        public ServiciosCategoriaProducto()
        {
            repositorioCategoriasProductos = new RepositorioCategoriasProductos(Configuracion.RUTA_CATEGORIAS);
        }

        public string Eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public string Guardar(CategoriaProducto entidad)
        {
            return repositorioCategoriasProductos.GuardarDatos(entidad);
        }

        public string Modificar(CategoriaProducto entidad)
        {
            throw new NotImplementedException();
        }

        public CategoriaProducto ObtenerPorId(string id)
        {
            listaCategoriasProductos = repositorioCategoriasProductos.CargarDatos();
            return listaCategoriasProductos.Find(c => c.Id == id);
        }

        public List<CategoriaProducto> ObtenerTodo()
        {
            return repositorioCategoriasProductos.CargarDatos();
        }
    }
}
