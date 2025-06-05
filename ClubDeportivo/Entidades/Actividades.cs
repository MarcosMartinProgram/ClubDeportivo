using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class Actividades
    {
        public int IdActividad { get; set; }
        public string Nombre { get; set; }
        public string Dias { get; set; }
        public string Horarios { get; set; }
        public int Cupo { get; set; }

        
    }
}
