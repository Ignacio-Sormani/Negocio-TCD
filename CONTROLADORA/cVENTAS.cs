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

        public MODELO.VENTA obtener_venta(Int32 codigo)
        {
            return oNegocio.VENTAS.Find(codigo);
        }
        
        public System.Collections.IEnumerable obtener_ventas() //falta agregar filtros
        {
            var ventas = from venta in oNegocio.VENTAS.ToList()
                          select venta;
            return ventas.ToList();
        }

        /*public Int32 obtener_nro() // obtener el siguiente numero de factura
        {
            Int32 nro = 1;
            foreach (var venta in oNegocio.VENTAS)
            {
                if (venta.nroFactura > nro)
                {
                    nro = venta.nroFactura;
                }
            }
            return (nro + 1);
        }
        
       
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
