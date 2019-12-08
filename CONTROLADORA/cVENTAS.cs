using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cVENTAS
    {
        private static cVENTAS instancia;
        public static cVENTAS obtener_instancia()
        {
            if (instancia == null)
                instancia = new cVENTAS();
            return instancia;
        }

        DATOS.NEGOCIO oNegocio;
        private cVENTAS()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }
        public void agregar_venta(MODELO.VENTA oVENTA)
        {
            oNegocio.VENTAS.Add(oVENTA);
            oNegocio.SaveChanges();
        }

        public void modificar_venta(MODELO.VENTA oVENTA)
        {
            oNegocio.Entry(oVENTA).State = System.Data.Entity.EntityState.Modified;
            oNegocio.SaveChanges();
        }
        public MODELO.VENTA obtener_venta(Int32 codigo)
        {
            oNegocio.ITEMSV.Include("producto").ToList();
            oNegocio.PAGOS.Include("formaPago").ToList();
            return oNegocio.VENTAS.Include("cliente").Include("pagos").Include("itemsv").FirstOrDefault(v => v.codigoVenta == codigo);
        }
        
        public System.Collections.IEnumerable obtener_ventas(string valor)
        {
            var ventas = from venta in oNegocio.VENTAS.Include("cliente").ToList()
                         where venta.cliente.nombreApellido.ToLower().Contains(valor.ToLower()) || venta.codigoVenta.ToString().Contains(valor)
                         select new
                         {
                             Codigo = venta.codigoVenta,
                             Cliente = venta.cliente.nombreApellido,
                             Fecha = venta.fecha,
                             Total = venta.precioTotal
                         };
            return ventas.ToList();
        }
        /*
        public string verificar_stock(MODELO.VENTA oMovimiento)
        {
            string msj = string.Empty;
            foreach(var detalle in oMovimiento.detalleMovimiento)
            {
                if(detalle.cantidad < detalle.insumo.cantidadActual)
                {
                    msj += "El insumo " + detalle.insumo.nombre + " tiene una cantidad actual de " + detalle.insumo.cantidadActual + " " + detalle.insumo.unidadMedida.nombre + ". ";
                    msj += "No se le puedes disminuir " + detalle.cantidad + " " + detalle.insumo.unidadMedida.nombre + ".\n";
                }
            }
            return msj;
        }

        public void actualizar_stock() //no se si actualiza directamente en insumos
        {
                     
        }
        
        */
    }
}
