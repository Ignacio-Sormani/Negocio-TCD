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

        public System.Collections.IEnumerable obtener_usuarios(string valor)
        {
            var usuarios = from usuario in oNegocio.USUARIOS.Include("grupos").ToList()
                           where usuario.codigoUsuario.ToString().Contains(valor) || usuario.nombreApellido.ToLower().Contains(valor) || 
                           usuario.nombreDeUsuario.ToLower().Contains(valor) || usuario.grupos.Count(_ => _.nombre.Contains(valor)) > 0 || 
                           usuario.estadoActivo.ToString().ToLower().Contains(valor)
                           select new
                           {
                               Codigo = usuario.codigoUsuario,
                               Usuario = usuario.nombreDeUsuario,
                               NombreCompleto = usuario.nombreApellido,
                               Mail = usuario.mail,
                               Activo = (usuario.estadoActivo ? "Activo" : "Inactivo"),
                               Grupos = usuario.grupos.Count()
                           };
            return usuarios.ToList();
        }

        public MODELO.USUARIO obtener_usuario_nombre(string usuario)
        {
            return oNegocio.USUARIOS.Include("grupos").FirstOrDefault(u => u.nombreDeUsuario.ToLower() == usuario.ToLower());
        }

        public MODELO.USUARIO obtener_usuario_mail(string mail)
        {
            return oNegocio.USUARIOS.FirstOrDefault(u => u.mail == mail);
        }

        public Int32 cantidad_usuarios_conectados()
        {
            return oNegocio.USUARIOS.Count(_ => _.conectado == true);
        }

        public MODELO.GRUPO obtener_grupo_admin()
        {
            return oNegocio.GRUPOS.FirstOrDefault(g => g.nombre == "Administrador del Sistema");
        }

        public System.Collections.IEnumerable obtener_grupos()
        {
            var grupos = from grupo in oNegocio.GRUPOS.ToList()
                         where grupo.estadoActivo == true
                         select grupo;
            return grupos.ToList();
        }
        public bool verificar_usuario_existente(string nombreUsuario)
        {
            if (oNegocio.USUARIOS.Count(_ => _.nombreDeUsuario == nombreUsuario) > 0)
                return false;
            else
                return true;
        }
    }
}
