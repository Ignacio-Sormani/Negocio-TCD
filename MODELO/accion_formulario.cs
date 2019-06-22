using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    [System.AttributeUsage(System.AttributeTargets.Class |
                  System.AttributeTargets.Struct,
                  AllowMultiple = true)]
    public class accion : System.Attribute
    {
        public string control { get; set; }
        public string descripcion { get; set; }
        public string formulario { get; set; }
        public string modulo { get; set; }
    }
    public class formulario : System.Attribute
    {
        public formulario()
        {
            acciones = new List<accion>();
        }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string modulo { get; set; }
        public List<accion> acciones { get; set; }

        
    }


}
