using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cUSUARIOS
    {
        private static cUSUARIOS instancia;
        public static cUSUARIOS obtener_instancia()
        {
            if (instancia == null)
                instancia = new cUSUARIOS();
            return instancia;
        }

        DATOS.NEGOCIO oNegocio;
        private cUSUARIOS()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }
    }
}
