using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entItinerario
    {
        public int idItinerario { get; set; }
        public DateTime hora { get; set; }
        public DateTime fecha { get; set; }
        public int idOrigen { get; set; }
        public int idDestino { get; set; }
    }
}
