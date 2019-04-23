using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cREMITOSDECOMPRA
    {
        private static cREMITOSDECOMPRA instancia;
        public static cREMITOSDECOMPRA obtener_instancia()
        {
            if (instancia == null)
                instancia = new cREMITOSDECOMPRA();
            return instancia;
        }

        DATOS.NEGOCIO oNegocio;
        private cREMITOSDECOMPRA()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }

        public System.Collections.IEnumerable calcular_items_faltantes(MODELO.ORDENDECOMPRA oORDEN)
     {
         var itemsoc = from itemoc in oNegocio.ITEMSOC.Include("producto").ToList()
                       where itemoc.ordenCompra == oORDEN
                       select itemoc;

         var remitos = from remito in oNegocio.REMITOSDECOMPRA.Include("ordenCompra").ToList()
                       where remito.ordenCompra == oORDEN
                       select remito;

         List<MODELO.ITEMRC> items_faltantes = new List<MODELO.ITEMRC>();
         foreach (MODELO.ITEMOC item in itemsoc.ToList())
         {
             MODELO.ITEMRC oItem = new MODELO.ITEMRC();
             oItem.producto = item.producto;
             oItem.cantidad = item.cantidad;
             items_faltantes.Add(oItem);
         }

         foreach (MODELO.REMITODECOMPRA remito in remitos.ToList())
         {
             var itemsrc = from itemrc in oNegocio.ITEMSRC.Include("remitoCompra").ToList()
                           where itemrc.remitoCompra == remito
                           select itemrc;

             foreach (MODELO.ITEMRC item in itemsrc.ToList())
             {
                 MODELO.ITEMRC oItem = items_faltantes.Find(_ => _.producto == item.producto);
                 oItem.cantidad -= item.cantidad;
                 if (oItem.cantidad == 0)
                     items_faltantes.Remove(oItem);
             }
         }
         return items_faltantes.ToList();
     }
    }
}
