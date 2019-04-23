using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cGRUPOS
    {
        private static cGRUPOS instancia;
        public static cGRUPOS obtener_instancia()
        {
            if (instancia == null)
                instancia = new cGRUPOS();
            return instancia;
        }

        DATOS.NEGOCIO oNegocio;
        private cGRUPOS()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }
    }
}
