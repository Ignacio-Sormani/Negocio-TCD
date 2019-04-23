using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class REMITODECOMPRA
    {
        public REMITODECOMPRA()
        {
            itemsrc = new HashSet<ITEMRC>();
        }
        public Int32 codigoRemitoCompra { get; set; }
        public DateTime fechaEntrega { get; set; }
        public DateTime fechaRecibida { get; set; }
        public virtual PROVEEDOR proveedor { get; set; }        
        public virtual ORDENDECOMPRA ordenCompra { get; set; }
        public virtual ICollection<ITEMRC> itemsrc { get; set; }
        public decimal total { get; set; }
    }
}
