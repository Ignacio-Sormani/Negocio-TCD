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
    }
}
