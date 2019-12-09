using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cACCESOS
    {
        private static cACCESOS instancia;
        public static cACCESOS obtener_instancia()
        {
            if (instancia == null)
                instancia = new cACCESOS();
            return instancia;
        }

        DATOS.NEGOCIO oNegocio;
        private cACCESOS()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }
        public void agregar_acceso(MODELO.ACCESO oAcceso)
        {
            oNegocio.ACCESOS.Add(oAcceso);
            oNegocio.SaveChanges();
        }

        public void modificar_acceso(MODELO.ACCESO oAcceso)
        {
            oNegocio.Entry(oAcceso).State = System.Data.Entity.EntityState.Modified;
            oNegocio.SaveChanges();
        }

        public System.Collections.IEnumerable obtener_accesos(string valor)
        {
            var accesos = from acceso in oNegocio.ACCESOS.Include("usuario").ToList()
                          where acceso.usuario.ToString().Contains(valor)
                          select new
                          {
                              Usuario = acceso.usuario,
                              FechaLogin = acceso.fechaLogin,
                              FechaLogout = acceso.fechaLogout
                          };
            return accesos.ToList();
        }

    }
}
