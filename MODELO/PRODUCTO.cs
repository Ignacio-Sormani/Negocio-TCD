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
        public bool estadoActivo { get; set; }
        public virtual ICollection<ITEM> items { get; set; }
        public void asignar_estado(bool p)
        {
            if (p == true)
            {
                if (cantidadActual == 0)
                    estado = "Sin Stock";
                else if (cantidadActual < cantidadMinima)
                    estado = "Stock Faltante";
                else if (cantidadActual < cantidadOperativa)
                    estado = "Stock Minimo";
                else
                    estado = "Hay Stock";
            }
            else
                estado = "En pedido";
        }
        public override string ToString()
        {
            return descripcion + " " + marca;
        }
    }
}
