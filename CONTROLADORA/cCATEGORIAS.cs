using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cCATEGORIAS
    {
        private static cCATEGORIAS instancia;
        public static cCATEGORIAS obtener_instancia()
        {
            if (instancia == null)
                instancia = new cCATEGORIAS();
            return instancia;
        }

        DATOS.NEGOCIO oNegocio;
        private cCATEGORIAS()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }
        public void agregar_categoria(MODELO.CATEGORIA oCategoria)
        {
            oNegocio.CATEGORIAS.Add(oCategoria);
            oNegocio.SaveChanges();
        }

        public void modificar_categoria(MODELO.CATEGORIA oCategoria)
        {
            oNegocio.Entry(oCategoria).State = System.Data.Entity.EntityState.Modified;
            oNegocio.SaveChanges();
        }

        public MODELO.CATEGORIA obtener_categoria(Int32 codigo)
        {
            return oNegocio.CATEGORIAS.Find(codigo);
        }

        public System.Collections.IEnumerable obtener_categorias(string valor)
        {
            var categorias = from categoria in oNegocio.CATEGORIAS.ToList()
                         where categoria.codigoCategoria.ToString().Contains(valor) || categoria.categoria.ToLower().Contains(valor.ToLower())
                         select new { Codigo = categoria.codigoCategoria, Categoria = categoria.categoria };
            return categorias.ToList();
        }

        public bool verificar_categoria_existente(string nombreCategoria) //falta hacerlo
        {
            if (oNegocio.CATEGORIAS.Count(_ => _.categoria == nombreCategoria) > 0)
                return false;
            else
                return true;
        }
    }
}
