using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cPRODUCTOS
    {
        private static cPRODUCTOS instancia;
        public static cPRODUCTOS obtener_instancia()
        {
            if (instancia == null)
                instancia = new cPRODUCTOS();
            return instancia;
        }

        DATOS.NEGOCIO oNegocio;
        private cPRODUCTOS()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }
        public void agregar_producto(MODELO.PRODUCTO oProducto)
        {
            oNegocio.PRODUCTOS.Add(oProducto);
            oNegocio.SaveChanges();
        }

        public void modificar_producto(MODELO.PRODUCTO oProducto)
        {
            oNegocio.Entry(oProducto).State = System.Data.Entity.EntityState.Modified;
            oNegocio.SaveChanges();
        }

        public MODELO.PRODUCTO obtener_producto(Int32 codigo)
        {
            return oNegocio.PRODUCTOS.Find(codigo);
        }

        public System.Collections.IEnumerable obtener_productos(string descripcionProducto) //terminar metodo
        {
            var productos = from producto in oNegocio.PRODUCTOS.Include("marca").Include("categoria").ToList()
                            where producto.descripcion.ToLower().Contains(descripcionProducto.ToLower())
                            select new
                            {
                                codigo = producto.codigoProducto,
                                descripcion = producto.descripcion,
                                marca = producto.marca,
                                categoria = producto.categoria,
                                costo = producto.costo,
                                precio = producto.precio,
                                cantidadActual = producto.cantidadActual,
                                cantidadMinima = producto.cantidadMinima,
                                cantidadOperativa = producto.cantidadOperativa,
                                estado = producto.estado,
                                estadoActivo = producto.estadoActivo

                            };
            return productos.ToList();
        }

        


    }
}
