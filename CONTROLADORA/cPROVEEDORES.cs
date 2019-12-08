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

        public System.Collections.IEnumerable obtener_proveedores(string valor)
        {
            var proveedores = from proveedor in oNegocio.PROVEEDORES.Include("localidad").ToList()
                           where proveedor.codigoProveedor.ToString().Contains(valor) || proveedor.cuit.ToString().Contains(valor) || proveedor.razonSocial.ToLower().Contains(valor.ToLower())
                           select new
                           {
                               Codigo = proveedor.codigoProveedor,
                               CUIT = proveedor.cuit,
                               RazonSocial = proveedor.razonSocial,
                               Direccion = (proveedor.direccion + ", " + proveedor.localidad),
                               Telefono = proveedor.telefono,
                               Mail = proveedor.mail
                           };
            return proveedores.ToList();
        }
    }
}
