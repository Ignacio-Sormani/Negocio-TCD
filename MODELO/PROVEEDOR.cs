using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class PROVEEDOR
    {
        public PROVEEDOR()
        {
            ordenesCompra = new HashSet<ORDENDECOMPRA>();
        }
        public Int32 codigoProveedor { get; set; }
        public Int32 cuit { get; set; }
        public string razonSocial { get; set; }
        public string direccion { get; set; }
        public LOCALIDAD localidad { get; set; }
        public Int32 telefono { get; set; }
        public string mail { get; set; }
        public virtual ICollection<ORDENDECOMPRA> ordenesCompra { get; set; }

        public override string ToString()
        {
            return razonSocial;
        }
    }
}
