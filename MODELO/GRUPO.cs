using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class GRUPO
    {
        public GRUPO()
        {
            usuarios = new HashSet<USUARIO>();
            acciones = new HashSet<ACCION>();
        }
        public Int32 codigoGrupo { get; set; }
        public string nombre { get; set; }
        public bool estado { get; set; }
        public virtual ICollection<USUARIO> usuarios { get; set; }
        public virtual ICollection<ACCION> acciones { get; set; }

        public override string ToString()
        {
            return nombre;
        }
    }
}
