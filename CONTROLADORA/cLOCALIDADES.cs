using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cLOCALIDADES
    {
        private static cLOCALIDADES instancia;
        public static cLOCALIDADES obtener_instancia() {
            if(instancia == null)
            {
                instancia = new cLOCALIDADES();
            }
            return instancia;
        }


        DATOS.NEGOCIO oNegocio;
        private cLOCALIDADES() {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }


        public void agregar_localidad(MODELO.LOCALIDAD oLocalidad)
        {
            oNegocio.LOCALIDADES.Add(oLocalidad);
            oNegocio.SaveChanges();
        }

        public void modificar_localidad(MODELO.LOCALIDAD oLocalidad)
        {
            oNegocio.Entry(oLocalidad).State = System.Data.Entity.EntityState.Modified;
            oNegocio.SaveChanges();
        }

        public void eliminar_localidad(MODELO.LOCALIDAD oLocalidad)
        {
            oNegocio.LOCALIDADES.Remove(oLocalidad);
            oNegocio.SaveChanges();
        }

        public System.Collections.IEnumerable obtener_localidades(string nombreLocalidad)
        {
            var localidades = from localidad in oNegocio.LOCALIDADES.ToList()
                             where localidad.localidad.ToLower().Contains(nombreLocalidad.ToLower())
                             select localidad;
            return localidades.ToList();
        }

        public MODELO.LOCALIDAD obtener_localidad(Int32 codigo)
        {
            return oNegocio.LOCALIDADES.Find(codigo);
        }


        public bool verificar_localidad_existente(Int32 cp, string localidad)
        {
            if (oNegocio.LOCALIDADES.Count(e => (e.codigoPostal == cp) && (e.localidad == localidad)) > 0)
                return true;
            else
                return false;
        }

    }
}
