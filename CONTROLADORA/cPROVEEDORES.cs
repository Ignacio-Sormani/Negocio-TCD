using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cPROVEEDORES
    {

        private static cPROVEEDORES instancia;
        public static cPROVEEDORES obtener_instancia()
        {
            if (instancia == null)
                instancia = new cPROVEEDORES();
            return instancia;
        }

        DATOS.NEGOCIO oNegocio;
        private cPROVEEDORES()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }

        public void agregar_proveedor(MODELO.PROVEEDOR oProveedor)
        {
            oNegocio.PROVEEDORES.Add(oProveedor);
            oNegocio.SaveChanges();
        }

        public void modificar_proveedor(MODELO.PROVEEDOR oProveedor)
        {
            oNegocio.Entry(oProveedor).State = System.Data.Entity.EntityState.Modified;
            oNegocio.SaveChanges();
        }

        public MODELO.PROVEEDOR obtener_proveedor(Int32 codigo)
        {
            return oNegocio.PROVEEDORES.Find(codigo);
        }

        public System.Collections.IEnumerable obtener_proveedores(Int32 numero, Int32 cuit, string razon)
        {
            var proveedores = from proveedor in oNegocio.PROVEEDORES.ToList()
                           where proveedor.codigoProveedor.ToString().Contains(numero.ToString()) || proveedor.cuit.ToString().Contains(cuit.ToString()) || proveedor.razonSocial.ToLower().Contains(razon.ToLower())
                           select new { CUIT = proveedor.cuit, RazonSocial = proveedor.razonSocial, Direccion = (proveedor.direccion + ", " + proveedor.localidad), Telefono = proveedor.telefono, Mail = proveedor.mail };
            return proveedores.ToList();
        }
    }
}
