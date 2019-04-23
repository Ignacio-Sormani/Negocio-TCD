using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class VENTA
    {
        public VENTA()
        {
            itemsv = new HashSet<ITEMV>();
            pagos = new HashSet<PAGO>();
        }
        public Int32 codigoVenta { get; set; }
        public DateTime fecha { get; set; }
        public CLIENTE cliente { get; set; }
        public Int32 total { get; set; }
        public virtual ICollection<ITEMV> itemsv { get; set; }
        public virtual ICollection<PAGO> pagos { get; set; }

        public override string ToString()
        {
            return "Compra de " + cliente.nombreApellido + " del dia" + fecha.ToShortDateString();
        }
    }
}