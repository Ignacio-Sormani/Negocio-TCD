using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class MARCA
    {
        public Int32 codigoMarca { get; set; }
        public string marca { get; set; }

        public override string ToString()
        {
            return this.marca;
        }
    }
}
