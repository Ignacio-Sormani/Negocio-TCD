using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cGRUPOS
    {
        private static cGRUPOS instancia;
        public static cGRUPOS obtener_instancia()
        {
            if (instancia == null)
                instancia = new cGRUPOS();
            return instancia;
        }

        DATOS.NEGOCIO oNegocio;
        private cGRUPOS()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }

        public void agregar_grupo(MODELO.GRUPO oGrupo)
        {
            oNegocio.GRUPOS.Add(oGrupo);
            oNegocio.SaveChanges();
        }

        public void modificar_grupo(MODELO.GRUPO oGrupo)
        {
            oNegocio.Entry(oGrupo).State = System.Data.Entity.EntityState.Modified;
            oNegocio.SaveChanges();
        }

        public MODELO.GRUPO obtener_grupo(Int32 codigo)
        {
            return oNegocio.GRUPOS.Find(codigo);
        }

        public System.Collections.IEnumerable obtener_grupos(string nombre)
        {
            var grupos = from grupo in oNegocio.GRUPOS.Include("usuarios").Include("acciones").ToList()
                           where grupo.nombre.ToLower().Contains(nombre.ToLower())
                           select grupo;
            return grupos.ToList();
        }

        public System.Collections.IEnumerable obtener_usuarios()
        {
            var usuarios = from usuario in oNegocio.USUARIOS.ToList()
                         where usuario.estadoActivo == true
                         select usuario;
            return usuarios.ToList();
        }

        public List<MODELO.ACCION> obtener_acciones()
        {
            return oNegocio.ACCIONES.ToList();
        }

        public bool verificar_grupo_existente(string nombreGrupo) //verificar esta funcion
        {
            if (oNegocio.GRUPOS.Count(_ => _.nombre == nombreGrupo) > 0)
                return false;
            else
                return true;
        }
    }
}
