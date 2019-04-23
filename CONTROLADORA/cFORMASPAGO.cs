using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cFORMASPAGO
    {
        private static cFORMASPAGO instancia;
        public static cFORMASPAGO obtener_instancia()
        {
            if (instancia == null)
                instancia = new cFORMASPAGO();
            return instancia;
        }

        DATOS.NEGOCIO oNegocio;
        private cFORMASPAGO()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }
    }
}
