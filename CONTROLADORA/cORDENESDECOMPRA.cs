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


    }
}
