using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cCLIENTES
    {
        private static cCLIENTES instancia;
        public static cCLIENTES obtener_instancia()
        {
            if (instancia == null)
                instancia = new cCLIENTES();
            return instancia;
        }

        DATOS.NEGOCIO oNegocio;
        private cCLIENTES()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }

        public void agregar_cliente(MODELO.CLIENTE oCliente)
        {
            oNegocio.CLIENTES.Add(oCliente);
            oNegocio.SaveChanges();
        }

        public void modificar_cliente(MODELO.CLIENTE oCliente)
        {
            oNegocio.Entry(oCliente).State = System.Data.Entity.EntityState.Modified;
            oNegocio.SaveChanges();
        }

        public MODELO.CLIENTE obtener_cliente(Int32 codigo)
        {
            return oNegocio.CLIENTES.Find(codigo);
        }

        public System.Collections.IEnumerable obtener_clientes(string valor)
        {
            var clientes = from cliente in oNegocio.CLIENTES.Include("localidad").ToList()
                           where cliente.codigoCliente.ToString().Contains(valor) || cliente.dni.ToString().Contains(valor) || cliente.nombreApellido.ToLower().Contains(valor.ToLower())
                           select new
                           {
                               Codigo = cliente.codigoCliente,
                               DNI = cliente.dni,
                               Nombre = cliente.nombreApellido,
                               Direccion = (cliente.direccion + ", " + cliente.localidad),
                               Telefono = cliente.telefono,
                               Mail = cliente.mail
                           };
            return clientes.ToList();
        }
    }
}
