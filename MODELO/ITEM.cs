using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public abstract class ITEM
    {
        public Int32 codigoItem { get; set; }
        public virtual PRODUCTO producto { get; set; }
        public Int32 cantidad { get; set; }

        public override string ToString()
        {
            return producto.descripcion + " x " + cantidad;
        }
    }

    public class ITEMV : ITEM
    {
        public virtual VENTA venta { get; set; }
        public decimal precioUnitarioVenta { get; set; }
        public decimal subtotal { get { return precioUnitarioVenta * cantidad; } }
    }

    public class ITEMOC : ITEM
    {
        public virtual ORDENDECOMPRA ordenCompra { get; set; }
        public decimal precioUnitarioPresupuesto { get; set; }
        public decimal subtotal { get { return precioUnitarioPresupuesto * cantidad; } }
    }

    public class ITEMRC : ITEM
    {
        public virtual REMITODECOMPRA remitoCompra { get; set; }
        public decimal precioUnitarioCompra { get; set; }
        public decimal subtotal { get { return precioUnitarioCompra * cantidad; } }
    }
}
