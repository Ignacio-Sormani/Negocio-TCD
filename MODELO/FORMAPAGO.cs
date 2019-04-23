using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public abstract class FORMAPAGO
    {
        public Int32 codigoFormaPago { get; set; }
        public PAGO pago { get; set; }
        public abstract decimal calcular_total(decimal total);
        public abstract Int32 cantidad_cuotas();

        public override string ToString()
        {
            return this.GetType().ToString();
        }
    }//faltan agregar las otras formas de pago, y ver que datos guardo para cada forma de pago (por ejemplo datos de la tarjeta)

    public class EFECTIVO : FORMAPAGO
    {
        public override decimal calcular_total(decimal total)
        {
            return (total * (decimal)0.85);
        }
        public override Int32 cantidad_cuotas()
        {
            return 1;
        }
    }
}
