using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class Socio : Persona
    {
        public DateTime FechaAlta { get; set; }
        public bool Carnet { get; set; }
        public double PrecioCuota { get; set; }
    }
}
