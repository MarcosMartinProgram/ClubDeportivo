using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class NoSocio : Persona
    {
        public DateTime FechaActividad { get; set; }
        public bool Habilitado { get; set; }
        public int IdActividad { get; set; }
    }
}
