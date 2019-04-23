using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ACCESO
    {
        public Int32 codigoAcceso { get; set; }
        public virtual USUARIO usuario { get; set; }
        public DateTime fechaLogin { get; set; }
        public DateTime fechaLogout { get; set; }
    }
}
