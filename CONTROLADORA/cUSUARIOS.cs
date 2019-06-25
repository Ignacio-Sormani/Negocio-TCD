using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cUSUARIOS
    {
        private static cUSUARIOS instancia;
        public static cUSUARIOS obtener_instancia()
        {
            if (instancia == null)
                instancia = new cUSUARIOS();
            return instancia;
        }

        DATOS.NEGOCIO oNegocio;
        private cUSUARIOS()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }

        public void agregar_usuario(MODELO.USUARIO oUsuario)
        {
            oNegocio.USUARIOS.Add(oUsuario);
            oNegocio.SaveChanges();
        }

        public void modificar_usuario(MODELO.USUARIO oUsuario)
        {
            oNegocio.Entry(oUsuario).State = System.Data.Entity.EntityState.Modified;
            oNegocio.SaveChanges();
        }

        public MODELO.USUARIO obtener_usuario(Int32 codigo)
        {
            return oNegocio.USUARIOS.Find(codigo);
        }

        public System.Collections.IEnumerable obtener_usuarios(string nombre)
        {
            var usuarios = from usuario in oNegocio.USUARIOS.Include("grupos").ToList()
                           where usuario.nombreDeUsuario.ToLower().Contains(nombre.ToLower())
                           select usuario;
            return usuarios.ToList();

        }

        public MODELO.USUARIO obtener_usuario_nombre(string usuario)
        {
            return oNegocio.USUARIOS.FirstOrDefault(u => u.nombreDeUsuario.ToLower() == usuario.ToLower());
        }

        public MODELO.USUARIO obtener_usuario_mail(string mail)
        {
            return oNegocio.USUARIOS.FirstOrDefault(u => u.mail == mail);
        }

        public Int32 cantidad_usuarios_conectados()
        {
            return oNegocio.USUARIOS.Count(_ => _.conectado == true);
        }
    }
}
