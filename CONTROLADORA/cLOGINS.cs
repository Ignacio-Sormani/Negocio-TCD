using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cLOGINS
    {
        private static cLOGINS instancia;
        public static cLOGINS obtener_instancia()
        {
            if (instancia == null)
                instancia = new cLOGINS();
            return instancia;
        }

        DATOS.NEGOCIO oNegocio;
        private cLOGINS()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }
    }
}
