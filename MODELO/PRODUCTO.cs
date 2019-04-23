using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class PRODUCTO
    {
        public PRODUCTO()
        {
            items = new HashSet<ITEM>();
        }
        public Int32 codigoProducto { get; set; }
        public string descripcion { get; set; }
        public MARCA marca { get; set; }
        public CATEGORIA categoria { get; set; }
        public decimal costo { get; set; }
        public decimal precio { get; set; }        
        public Int32 cantidadActual { get; set; }
        public Int32 cantidadMinima { get; set; }
        public Int32 cantidadOperativa { get; set; }
        public string estado { get; set; }
        public bool Activo { get; set; }
        public virtual ICollection<ITEM> items { get; set; }
        public string asignar_estado(bool p)
        {
            if (p == true)
            {
                if (cantidadActual == 0)
                    return "Sin Stock";
                else if (cantidadActual < cantidadMinima)
                    return "Stock Faltante";
                else if (cantidadActual < cantidadOperativa)
                    return "Stock Minimo";
                else
                    return "Hay Stock";
            }
            else
                return "En pedido";
        }
        public override string ToString()
        {
            return descripcion + " " + marca;
        }
    }
}
