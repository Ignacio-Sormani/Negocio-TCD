using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class PAGO
    {
        public Int32 codigoPago { get; set; }
        public virtual FORMAPAGO formaPago { get; set; }
        public virtual VENTA venta { get; set; }
        public decimal total { get; set; }
        public Int32 cantidadCuotas { get; set; }
        public decimal precioCuota { get; set; }
        
        public void calcular_totales()
        {
            total = formaPago.calcular_total(venta.total);
            cantidadCuotas = formaPago.cantidad_cuotas();
            precioCuota = total / cantidadCuotas;
        }

        public override string ToString()
        {
            return "Pago de un total de $" + total.ToString() + " en forma de pago " + formaPago.GetType().ToString();
        }
    }
}
