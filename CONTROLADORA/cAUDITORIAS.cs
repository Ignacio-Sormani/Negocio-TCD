using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cAUDITORIAS
    {
        private static cAUDITORIAS instancia;
        public static cAUDITORIAS obtener_instancia()
        {
            if (instancia == null)
            {
                instancia = new cAUDITORIAS();
            }
            return instancia;
        }

        DATOS.NEGOCIO oNegocio;
        private cAUDITORIAS()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }

        public void agregar_auditoria(MODELO.AUDITORIACLIENTE oAuditoria)
        {
            oNegocio.AUDITORIASCLIENTE.Add(oAuditoria);
            oNegocio.SaveChanges();
        }
        public System.Collections.IEnumerable obtener_auditorias_cliente(string valor)
        {
            var auditorias = from auditoria in oNegocio.AUDITORIASCLIENTE.Include("auditoriaUsuario").Include("localidad").ToList()
                             where auditoria.dni.ToString().Contains(valor) || auditoria.nombreApellido.ToLower().Contains(valor.ToLower())
                             select new
                             {
                                 Fecha = auditoria.auditoriaFecha,
                                 Movimiento = auditoria.auditoriaMovimiento,
                                 Usuario = auditoria.auditoriaUsuario,
                                 DNI = auditoria.dni,
                                 Nombre = auditoria.nombreApellido,
                                 Direccion = (auditoria.direccion + ", " + auditoria.localidad),
                                 Telefono = auditoria.telefono,
                                 FechaNacimiento = auditoria.fechaNacimiento,
                                 Mail = auditoria.mail
                             };
            var clientes = from cliente in oNegocio.CLIENTES.Include("localidad").ToList()
                           where cliente.dni.ToString().Contains(valor) || cliente.nombreApellido.ToLower().Contains(valor.ToLower())
                           select new
                           {
                               Fecha = cliente.auditoriaFecha,
                               Movimiento = cliente.auditoriaMovimiento,
                               Usuario = cliente.auditoriaUsuario,
                               DNI = cliente.dni,
                               Nombre = cliente.nombreApellido,
                               Direccion = (cliente.direccion + ", " + cliente.localidad),
                               Telefono = cliente.telefono,
                               FechaNacimiento = cliente.fechaNacimiento,
                               Mail = cliente.mail
                           };
            return clientes.Concat(auditorias).ToList();
        }
    }
}
