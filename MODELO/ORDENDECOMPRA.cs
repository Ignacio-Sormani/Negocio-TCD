using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ORDENDECOMPRA
    {
        public ORDENDECOMPRA()
        {
            itemsoc = new HashSet<ITEMOC>();
            remitosCompra = new HashSet<REMITODECOMPRA>();
        }

        public Int32 codigoOrdenCompra { get; set; }
        public DateTime fechaPedido { get; set; }
        public DateTime fechaEntrega { get; set; }
        public virtual PROVEEDOR proveedor { get; set; }
        public virtual ICollection<ITEMOC> itemsoc { get; set; }
        public virtual ICollection<REMITODECOMPRA> remitosCompra { get; set; }
        public decimal totalPedido { get; set; }
        public string estado { get; set; }

        public override string ToString()
        {
            return "Pedido a " + proveedor.razonSocial + ", hecho el dia " + fechaPedido.ToShortDateString();
        }
    }
}
