using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class LOCALIDAD
    {
        public Int32 codigoLocalidad { get; set; }
        public Int32 codigoPostal { get; set; }
        public string localidad { get; set; }

        public override string ToString()
        {
            return this.localidad;
        }
    }
}
