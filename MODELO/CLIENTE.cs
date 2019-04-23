using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class CLIENTE
    {
        public CLIENTE()
        {
            ventas = new HashSet<MODELO.VENTA>();
        }
        public Int32 codigoCliente { get; set; }
        public Int32 dni { get; set; }
        public string nombreApellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string direccion { get; set; }
        public LOCALIDAD localidad { get; set; }
        public Int32 telefono { get; set; }
        public string mail { get; set; }
        public virtual ICollection<MODELO.VENTA> ventas { get; set; }

        public override string ToString()
        {
            return nombreApellido + " - DNI: " + dni;
        }
    }
}
