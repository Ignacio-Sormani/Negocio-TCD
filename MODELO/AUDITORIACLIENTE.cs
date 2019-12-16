using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class AUDITORIACLIENTE
    {
        public Int32 codigoAuditoriaCliente { get; set; }
        public Int64 dni { get; set; }
        public string nombreApellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string direccion { get; set; }
        public LOCALIDAD localidad { get; set; }
        public Int64 telefono { get; set; }
        public string mail { get; set; }
        public virtual USUARIO auditoriaUsuario { get; set; }
        public DateTime auditoriaFecha { get; set; }
        public string auditoriaMovimiento { get; set; }
    }
}
