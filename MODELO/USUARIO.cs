using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class USUARIO
    {
        public USUARIO()
        {
            grupos = new HashSet<GRUPO>();
            accesos = new HashSet<ACCESO>();
        }
        public Int32 codigoUsuario { get; set; }
        public string nombreDeUsuario { get; set; }
        public string nombreApellido { get; set; }
        public string clave { get; set; }
        public string mail { get; set; }
        public bool estadoActivo { get; set; }
        public bool conectado { get; set; }
        public virtual ICollection<GRUPO> grupos { get; set; }
        public virtual ICollection<ACCESO> accesos { get; set; }

        public override string ToString()
        {
            return nombreDeUsuario;
        }

        public bool validar_acciones(string control, string form)
        {
            if (this.grupos.Count(u => u.nombre == "Administrador del Sistema") > 0)
            {
                return true;
            }
            else
            {
                foreach (MODELO.GRUPO oGrupo in this.grupos)
                {
                    if (oGrupo.acciones.Count(acc => acc.control == control && acc.nombreFormulario == form) > 0 && oGrupo.estadoActivo == true)
                    {
                        return true;
                    }                    
                }
            }
            return false;
        }
    }
}
