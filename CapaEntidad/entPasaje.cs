using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPasaje
    {
        public int idPasasje { get; set; }
        public string tipoPasaje { get; set; }
        public string asiento { get; set; }
        public int valor { get; set; }
        public int idCliente { get; set; }
        public int idViaje { get; set; }

    }
}
