using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ACCION
    {
        public ACCION()
        {
            grupos = new HashSet<GRUPO>();
        }
        public Int32 codigoAccion { get; set; }
        public string descripcionAccion { get; set; }
        public string control { get; set; }
        public string nombreFormulario { get; set; }
        public string modulo { get; set; }
        public virtual ICollection<GRUPO> grupos { get; set; }

        public override string ToString()
        {
            return descripcionAccion;
        }
    }
}
