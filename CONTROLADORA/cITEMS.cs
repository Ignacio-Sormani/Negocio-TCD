using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cITEMS
    {
        private static cITEMS instancia;
        public static cITEMS obtener_instancia()
        {
            if (instancia == null)
                instancia = new cITEMS();
            return instancia;
        }
        DATOS.NEGOCIO oNegocio;
        private cITEMS()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }

        public void agregar_item_venta(MODELO.ITEMV oItem)
        {
            oNegocio.ITEMSV.Add(oItem);
            oNegocio.SaveChanges();
        }

        public void modificar_item_venta(MODELO.ITEMV oItem)
        {
            oNegocio.Entry(oItem).State = System.Data.Entity.EntityState.Modified;
            oNegocio.SaveChanges();
        }

        public void agregar_item_orden(MODELO.ITEMOC oItem)
        {
            oNegocio.ITEMSOC.Add(oItem);
            oNegocio.SaveChanges();
        }

        public void modificar_item_orden(MODELO.ITEMOC oItem)
        {
            oNegocio.Entry(oItem).State = System.Data.Entity.EntityState.Modified;
            oNegocio.SaveChanges();
        }

        public void agregar_item_remito(MODELO.ITEMRC oItem)
        {
            oNegocio.ITEMSRC.Add(oItem);
            oNegocio.SaveChanges();
        }        
    }
}
