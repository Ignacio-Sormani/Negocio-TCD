using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cPAGOS
    {
        private static cPAGOS instancia;
        public static cPAGOS obtener_instancia()
        {
            if (instancia == null)
                instancia = new cPAGOS();
            return instancia;
        }

        DATOS.NEGOCIO oNegocio;
        private cPAGOS()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }
        public void agregar_pago(MODELO.PAGO oPago)
        {
            oNegocio.PAGOS.Add(oPago);
            oNegocio.SaveChanges();
        }

        public void eliminar_pago(MODELO.PAGO oPago)
        {
            oNegocio.PAGOS.Remove(oPago);
            oNegocio.SaveChanges();
        }
    }
}
