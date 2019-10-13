using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cORDENESDECOMPRA
    {
        private static cORDENESDECOMPRA instancia;
        public static cORDENESDECOMPRA obtener_instancia()
        {
            if (instancia == null)
                instancia = new cORDENESDECOMPRA();
            return instancia;
        }

        DATOS.NEGOCIO oNegocio;
        private cORDENESDECOMPRA()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }

        public void agregar_orden(MODELO.ORDENDECOMPRA oORDEN)
        {
            oNegocio.ORDENESDECOMPRA.Add(oORDEN);
            oNegocio.SaveChanges();
        }

        public void modificar_venta(MODELO.ORDENDECOMPRA oORDEN)
        {
            oNegocio.Entry(oORDEN).State = System.Data.Entity.EntityState.Modified;
            oNegocio.SaveChanges();
        }

        public MODELO.ORDENDECOMPRA obtener_orden(Int32 codigo)
        {
            return oNegocio.ORDENESDECOMPRA.Include("proveedor").Include("itemsc").FirstOrDefault(v => v.codigoOrdenCompra == codigo);
        }

        public System.Collections.IEnumerable obtener_ordenes(string proveedor)
        {
            var ordenes = from orden in oNegocio.ORDENESDECOMPRA.Include("cliente").ToList()
                         where orden.proveedor.razonSocial.ToLower().Contains(proveedor.ToLower())
                         select orden;
            return ordenes.ToList();
        }
    }
}
