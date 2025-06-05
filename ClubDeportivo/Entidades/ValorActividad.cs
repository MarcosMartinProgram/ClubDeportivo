using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class ValorActividad
    {
        public int IdValorActividad { get; set; }
        public int IdActividad { get; set; }
        public double Monto { get; set; }
        public DateTime FechaDesde { get; set; }

        public ValorActividad() { }

        public ValorActividad(int idValorActividad, int idActividad, double monto, DateTime fechaDesde)
        {
            IdValorActividad = idValorActividad;
            IdActividad = idActividad;
            Monto = monto;
            FechaDesde = fechaDesde;
        }
    }
}