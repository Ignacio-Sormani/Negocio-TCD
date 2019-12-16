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

        public List<MODELO.PRODUCTO> listar_productos()
        {
            return oNegocio.PRODUCTOS.ToList();
        }

        public System.Collections.IEnumerable obtener_productos(string valor)
        {
            var productos = from producto in oNegocio.PRODUCTOS.Include("marca").Include("categoria").ToList()
                            where producto.codigoProducto.ToString().Contains(valor) || producto.descripcion.ToLower().Contains(valor.ToLower()) ||
                            producto.estado.ToLower().Contains(valor) || producto.marca.marca.ToLower().Contains(valor) || producto.categoria.categoria.ToLower().Contains(valor)
                            select new
                            {
                                Codigo = producto.codigoProducto,
                                Descripcion = producto.descripcion,
                                Marca = producto.marca,
                                Categoria = producto.categoria,
                                Precio = producto.precio,
                                CantidadActual = producto.cantidadActual,
                                CantidadMinima = producto.cantidadMinima,
                                CantidadOperativa = producto.cantidadOperativa,
                                Estado = producto.estado,
                                EstadoActivo = producto.estadoActivo ? "Activo" : "Inactivo"
                            };
            return productos.ToList();
        }
    }
}
