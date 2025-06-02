using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class PagoSocio
    {
        public int IdSocio { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string TipoPago { get; set; }
        public int CantidadCuotas { get; set; }
        public double Monto { get; set; }
    }
}
