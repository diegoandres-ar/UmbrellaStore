using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    internal interface IConsultas<T>
    {
        List<T> ObtenerTodo();
        T ObtenerPorId(string id);
    }
}
