using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cMARCAS
    {
        private static cMARCAS instancia;
        public static cMARCAS obtener_instancia()
        {
            if (instancia == null)
                instancia = new cMARCAS();
            return instancia;
        }

        DATOS.NEGOCIO oNegocio;
        private cMARCAS()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }
        public void agregar_marca(MODELO.MARCA oMarca)
        {
            oNegocio.MARCAS.Add(oMarca);
            oNegocio.SaveChanges();
        }

        public void modificar_marca(MODELO.MARCA oMarca)
        {
            oNegocio.Entry(oMarca).State = System.Data.Entity.EntityState.Modified;
            oNegocio.SaveChanges();
        }

        public MODELO.MARCA obtener_marca(Int32 codigo)
        {
            return oNegocio.MARCAS.Find(codigo);
        }

        public System.Collections.IEnumerable obtener_marcas(string valor)
        {
            var marcas = from marca in oNegocio.MARCAS.ToList()
                         where marca.codigoMarca.ToString().Contains(valor) || marca.marca.ToLower().Contains(valor.ToLower())
                         select new { Codigo = marca.codigoMarca, Marca = marca.marca };
            return marcas.ToList();
        }

        public bool verificar_marca_existente(string nombreMarca) //verificar esta funcion
        {
            if (oNegocio.MARCAS.Count(_ => _.marca == nombreMarca) > 0)
                return false;
            else
                return true;
        }

        
    }
}
