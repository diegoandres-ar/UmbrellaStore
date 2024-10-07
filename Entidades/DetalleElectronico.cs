using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleElectronico
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string FormaPago { get; set; }
        public MedioPago MedioPago { get; set; }
        public double IVA { get; set; }
        public double ImpuestoConsumo { get; set; }

        public DetalleElectronico(string id, string nombre, string formaPago, 
            MedioPago medioPago, double iVA, double impuestoConsumo)
        {
            Id = id;
            Nombre = nombre;
            FormaPago = formaPago;
            MedioPago = medioPago;
            IVA = iVA;
            ImpuestoConsumo = impuestoConsumo;
        }

        public override string ToString()
        {
            return $"{Id};{Nombre};{FormaPago};{MedioPago.Id};{IVA};{ImpuestoConsumo}";
        }

    }
}
