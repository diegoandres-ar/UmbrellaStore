using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        public string Id { get; set; }
        public Usuario Vendedor { get; set; }
        public Persona Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public List<DetalleFactura> Detalles { get; set; }
        public double TotalImpuesto { get; set; }
        public double TotalAbsoluto { get; set; }
        public DetalleElectronico DetalleElectronico { get; set; }

        public Factura(string id, Usuario vendedor, Persona cliente, DateTime fecha, 
            List<DetalleFactura> detalles, double totalImpuesto, double totalAbsoluto, 
            DetalleElectronico detalleElectronico)
        {
            Id = id;
            Vendedor = vendedor;
            Cliente = cliente;
            Fecha = fecha;
            Detalles = detalles;
            TotalImpuesto = totalImpuesto;
            TotalAbsoluto = totalAbsoluto;
            DetalleElectronico = detalleElectronico;
        }

        public override string ToString()
        {
            return $"{Id};{Vendedor.NumeroIdentificacion};{Cliente.NumeroIdentificacion};" +
                $"{Fecha};{TotalImpuesto};{TotalAbsoluto};{DetalleElectronico.Id}";
        }
    }
}
