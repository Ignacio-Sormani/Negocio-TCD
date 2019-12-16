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
        public abstract decimal calcular_total(decimal total, Int32 cantidad);

        public override string ToString()
        {
            switch (GetType().ToString())
            {
                case "MODELO.EFECTIVO":
                    return "EFECTIVO";
                case "MODELO.CREDITO":
                    return "CREDITO";
                case "MODELO.DEBITO":
                    return "DEBITO";
                default:
                    return "";
            }
        }
    }

    public class EFECTIVO : FORMAPAGO
    {
        public override decimal calcular_total(decimal total, Int32 cantidad)
        {
            return (total * (decimal)0.85);
        }
    }

    public class DEBITO : FORMAPAGO
    {
        public override decimal calcular_total(decimal total, Int32 cantidad)
        {
            return total;
        }
    }

    public class CREDITO : FORMAPAGO
    {
        public override decimal calcular_total(decimal total, Int32 cantidad)
        {
            switch (cantidad)
            {
                case 1:
                    return total;
                case 3:
                    return (total * (decimal)1.05);
                case 6:
                    return (total * (decimal)1.15);
                case 12:
                    return (total * (decimal)1.30);
                default:
                    return (total * (decimal)5);
            }
        }
    }
}
