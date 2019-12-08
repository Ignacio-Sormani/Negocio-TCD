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

        public void modificar_orden(MODELO.ORDENDECOMPRA oORDEN)
        {
            oNegocio.Entry(oORDEN).State = System.Data.Entity.EntityState.Modified;
            oNegocio.SaveChanges();
        }

        public MODELO.ORDENDECOMPRA obtener_orden(Int32 codigo)
        {
            var items = from item in oNegocio.ITEMSOC.Include("producto").ToList()
                        select item;
            return oNegocio.ORDENESDECOMPRA.Include("proveedor").Include("itemsoc").FirstOrDefault(v => v.codigoOrdenCompra == codigo);            
        }

        public System.Collections.IEnumerable obtener_ordenes(string valor)
        {
            var ordenes = from orden in oNegocio.ORDENESDECOMPRA.Include("proveedor").ToList()
                          where orden.codigoOrdenCompra.ToString().Contains(valor) || orden.proveedor.razonSocial.ToLower().Contains(valor.ToLower()) ||
                          orden.proveedor.codigoProveedor.ToString().Contains(valor) || orden.estado.ToLower().Contains(valor)
                          select new
                          {
                              Codigo = orden.codigoOrdenCompra,
                              Proveedor = orden.proveedor.razonSocial,
                              FechaPedido = orden.fechaPedido,
                              Estado = orden.estado,
                              FechaEntrega = orden.fechaEntrega,
                              PresupuestoTotal = orden.totalPedido
                          };
            return ordenes.ToList();
        }
    }
}
