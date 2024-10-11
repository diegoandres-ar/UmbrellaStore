using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface Icrud <T>
    {
        string Guardar(T entidad);
        List<T> ObtenerTodo();
        T ObtenerPorId(string id);
        string Eliminar(string id);
        string Modificar(T entidad);
    }
}
