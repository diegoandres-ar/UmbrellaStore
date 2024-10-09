using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class RepositorioBase <T>
    {
        protected string _nombreArchivo;
        protected RepositorioBase(string nombreArchivo)
        {
            _nombreArchivo = nombreArchivo;
        }
        public string GuardarDatos(T entidad)
        {
            try
            {
                StreamWriter Writer = new StreamWriter(_nombreArchivo, true);
                Writer.WriteLine(entidad.ToString());
                Writer.Close();
                return "Datos almacenados correctamente";
            }
            catch (Exception ex)
            {
                return ("Error al guardar " + ex.Message);
            }

        }
        public abstract List<T> CargarDatos();
    }
}
