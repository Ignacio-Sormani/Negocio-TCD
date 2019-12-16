using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace CONTROLADORA
{
    public abstract class DATOSDEREPORTE
    {
        public abstract IEnumerable listar(DateTime fi, DateTime ff);
        public abstract void Cantidades(DateTime fi, DateTime ff, out string nombre, out string nombre2, out string nombre3, out int cant1, out int cant2, out int cant3);
        public abstract IEnumerable GenerarDatosParaGrafico1(DateTime fi, DateTime ff, out string nombre, out List<string> x, out List<int> y);
        public abstract IEnumerable GenerarDatosParaGrafico2(DateTime fi, DateTime ff, out string nombre, out List<string> x, out List<int> y);

    }

    public class DATOSDEVENTAS : DATOSDEREPORTE
    {
        DATOS.NEGOCIO oNegocio;
        public DATOSDEVENTAS()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }

        public override IEnumerable listar(DateTime fi, DateTime ff)
        {
            var ventas = from venta in oNegocio.VENTAS.Include("cliente").ToList()
                         where venta.fecha.Date <= ff.Date && venta.fecha.Date >= fi.Date
                         select new
                         {
                             Codigo = venta.codigoVenta,
                             Cliente = venta.cliente.nombreApellido,
                             Fecha = venta.fecha,
                             Total = venta.precioTotal
                         };
            return ventas.ToList();
        }
        public override void Cantidades(DateTime fi, DateTime ff, out string nombre, out string nombre2, out string nombre3, out int cant1, out int cant2, out int cant3)
        {
            nombre = "Cantidad de Ventas:";
            nombre2 = "Cantidad de Clientes:";
            nombre3 = "Ganancia Total Aprox:";
            cant1 = 0;
            cant2 = 0;
            cant3 = 0;
            var ventas = from venta in oNegocio.VENTAS.ToList()
                         where venta.fecha.Date <= ff.Date && venta.fecha.Date >= fi.Date
                         select venta;
            cant1 = ventas.ToList().Count(); ;
            var cliente = from ventaCliente in oNegocio.VENTAS.Include(_ => _.cliente).ToList()
                          where ventaCliente.fecha.Date <= ff.Date && ventaCliente.fecha.Date >= fi.Date
                          group ventaCliente by ventaCliente.cliente into grupo
                          select new
                          {
                              Nombre = grupo.Key
                          };
            cant2 = cliente.ToList().Count();

            var pago = from venta in oNegocio.VENTAS.ToList()
                       where venta.fecha.Date <= ff.Date && venta.fecha.Date >= fi.Date
                       select venta;
            cant3 = Decimal.ToInt32(pago.Sum(_ => _.pagoTotal));
        }
        public override IEnumerable GenerarDatosParaGrafico1(DateTime fi, DateTime ff, out string nombre, out List<string> x, out List<int> y)
        {
            nombre = "Cantidad de Ventas de Productos por Categoria";
            var ventas = from venta in oNegocio.VENTAS.Include("cliente").Include("itemsv").ToList()
                         where venta.fecha.Date <= ff.Date && venta.fecha.Date >= fi.Date
                         select venta;

            List<MODELO.ITEMV> itemsV = new List<MODELO.ITEMV>();
            foreach (var venta in ventas.ToList())
            {
                var items = from item in oNegocio.ITEMSV.Include("producto").Include("venta").Include(_ => _.producto.categoria).ToList()
                            where item.venta == venta
                            select item;

                foreach (var item in items.ToList())
                {
                    itemsV.Add(item);
                }
            }


            var itemsAgrupados = from itemV in itemsV
                                 group itemV by itemV.producto.categoria into grupo
                                 select new
                                 {
                                     Nombre = grupo.Key,
                                     Cantidad = grupo.Sum(_ => _.cantidad),
                                     Ganancias = grupo.Sum(_ => _.subtotal)
                                 };
            x = new List<string>();
            y = new List<int>();
            foreach (var item in itemsAgrupados)
            {
                x.Add(item.Nombre.ToString());
                y.Add(item.Cantidad);
            }
            return itemsAgrupados.ToList();
        }
        public override IEnumerable GenerarDatosParaGrafico2(DateTime fi, DateTime ff, out string nombre, out List<string> x, out List<int> y)
        {
            nombre = "Cantidad de Ventas por Producto";
            var ventas = from venta in oNegocio.VENTAS.Include("cliente").Include("itemsv").ToList()
                         where venta.fecha.Date <= ff.Date && venta.fecha.Date >= fi.Date
                         select venta;

            List<MODELO.ITEMV> itemsV = new List<MODELO.ITEMV>();
            foreach (var venta in ventas.ToList())
            {
                var items = from item in oNegocio.ITEMSV.Include("producto").Include("venta").Include(_ => _.venta.itemsv).ToList()
                            where item.venta == venta
                            select item;

                foreach (var item in items.ToList())
                {
                    itemsV.Add(item);
                }
            }
            var itemsAgrupados = from itemV in itemsV
                                 group itemV by itemV.producto.descripcion into grupo
                                 select new
                                 {
                                     Nombre = grupo.Key,
                                     Cantidad = grupo.Sum(_ => _.cantidad),
                                     Ganancias = grupo.Sum(_ => _.subtotal)
                                 };
            x = new List<string>();
            y = new List<int>();
            foreach (var item in itemsAgrupados)
            {
                x.Add(item.Nombre);
                y.Add(item.Cantidad);
            }
            return itemsAgrupados.ToList();
        }

    }

    public class DATOSORDENESDECOMPRA : DATOSDEREPORTE
    {
        DATOS.NEGOCIO oNegocio;
        public DATOSORDENESDECOMPRA()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }

        public override IEnumerable listar(DateTime fi, DateTime ff)
        {
            var ordenescompra = from orden in oNegocio.ORDENESDECOMPRA.Include(_ => _.proveedor).ToList()
                                where orden.fechaEntrega.Date <= ff.Date && orden.fechaEntrega.Date >= fi.Date
                                select new
                                {
                                    Codigo = orden.codigoOrdenCompra,
                                    Proveedor = orden.proveedor.razonSocial,
                                    FechaEntrega = orden.fechaEntrega,
                                    Total = orden.totalPedido
                                };
            return ordenescompra.ToList();
        }
        public override void Cantidades(DateTime fi, DateTime ff, out string nombre, out string nombre2, out string nombre3, out int cant1, out int cant2, out int cant3)
        {
            nombre = "Cantided de \n  Ordenes de Compra:";
            nombre2 = "Cant. de \n  Proveedores:";
            nombre3 = "Gasto Total Aprox:";
            cant1 = 0;
            cant2 = 0;
            cant3 = 0;
            var ordenes = from orden in oNegocio.ORDENESDECOMPRA.ToList()
                          where orden.fechaEntrega.Date <= ff.Date && orden.fechaEntrega.Date >= fi.Date
                          select orden;
            cant1 = ordenes.ToList().Count(); ;
            var proveedores = from orden in oNegocio.ORDENESDECOMPRA.ToList()
                              where orden.fechaEntrega.Date <= ff.Date && orden.fechaEntrega.Date >= fi.Date
                              group orden by orden.proveedor into grupo
                              select new
                              {
                                  Proveedor = grupo.Key
                              };
            cant2 = proveedores.ToList().Count();

            var gastos = from orden in oNegocio.ORDENESDECOMPRA.ToList()
                         where orden.fechaEntrega.Date <= ff.Date && orden.fechaEntrega.Date >= fi.Date
                         select orden;
            cant3 = Decimal.ToInt32(gastos.Sum(_ => _.totalPedido));
        }
        public override IEnumerable GenerarDatosParaGrafico1(DateTime fi, DateTime ff, out string nombre, out List<string> x, out List<int> y)
        {
            nombre = "Cantidad de Ordenes de Productos por Categoria";
            var ordenes = from orden in oNegocio.ORDENESDECOMPRA.Include("proveedor").Include(_ => _.itemsoc).ToList()
                          where orden.fechaEntrega.Date <= ff.Date && orden.fechaEntrega.Date >= fi.Date
                          select orden;

            List<MODELO.ITEMOC> itemsOC = new List<MODELO.ITEMOC>();
            foreach (var orden in ordenes.ToList())
            {
                var items = from item in oNegocio.ITEMSOC.Include(_ => _.producto).Include(_ => _.ordenCompra).Include(_ => _.producto.categoria).ToList()
                            where item.ordenCompra == orden
                            select item;

                foreach (var item in items.ToList())
                {
                    itemsOC.Add(item);
                }
            }


            var itemsAgrupados = from i in itemsOC
                                 group i by i.producto.categoria into grupo
                                 select new
                                 {
                                     Nombre = grupo.Key,
                                     Cantidad = grupo.Sum(_ => _.cantidad),
                                     Gastos = grupo.Sum(_=>_.subtotal)
                                 };
            x = new List<string>();
            y = new List<int>();
            foreach (var item in itemsAgrupados)
            {
                x.Add(item.Nombre.ToString());
                y.Add(item.Cantidad);
            }
            return itemsAgrupados.ToList();
        }
        public override IEnumerable GenerarDatosParaGrafico2(DateTime fi, DateTime ff, out string nombre, out List<string> x, out List<int> y)
        {
            nombre = "Cantidad de Ordenes de Compra por Producto";
            var ordenes = from orden in oNegocio.ORDENESDECOMPRA.Include("proveedor").Include(_ => _.itemsoc).ToList()
                          where orden.fechaEntrega.Date <= ff.Date && orden.fechaEntrega.Date >= fi.Date
                          select orden;

            List<MODELO.ITEMOC> itemsOC = new List<MODELO.ITEMOC>();
            foreach (var orden in ordenes.ToList())
            {
                var items = from item in oNegocio.ITEMSOC.Include(_ => _.producto).Include(_ => _.ordenCompra).Include(_ => _.producto.categoria).ToList()
                            where item.ordenCompra == orden
                            select item;

                foreach (var item in items.ToList())
                {
                    itemsOC.Add(item);
                }
            }


            var itemsAgrupados = from i in itemsOC
                                 group i by i.producto.descripcion into grupo
                                 select new
                                 {
                                     Nombre = grupo.Key,
                                     Cantidad = grupo.Sum(_ => _.cantidad),
                                     Gastos = grupo.Sum(_ => _.subtotal)
                                 };
            x = new List<string>();
            y = new List<int>();
            foreach (var item in itemsAgrupados)
            {
                x.Add(item.Nombre);
                y.Add(item.Cantidad);
            }
            return itemsAgrupados.ToList();
        }

    }

    public class DATOSDEPROVEEDORES : DATOSDEREPORTE
    {
        DATOS.NEGOCIO oNegocio;
        public DATOSDEPROVEEDORES()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }

        public override IEnumerable listar(DateTime fi, DateTime ff)
        {
            var ordenescompra = from orden in oNegocio.ORDENESDECOMPRA.Include(_ => _.proveedor).ToList()
                                where orden.fechaEntrega.Date <= ff.Date && orden.fechaEntrega.Date >= fi.Date
                                select new
                                {
                                    Codigo = orden.codigoOrdenCompra,
                                    Proveedor = orden.proveedor.razonSocial,
                                    FechaEntrega = orden.fechaEntrega,
                                    Total = orden.totalPedido
                                };
            return ordenescompra.ToList();
        }
        public override void Cantidades(DateTime fi, DateTime ff, out string nombre, out string nombre2, out string nombre3, out int cant1, out int cant2, out int cant3)
        {
            nombre = "Cantided de \n  Ordenes de Compra:";
            nombre2 = "Cant. de \n  Proveedores:";
            nombre3 = "Gasto Total Aprox:";
            cant1 = 0;
            cant2 = 0;
            cant3 = 0;
            var ordenes = from orden in oNegocio.ORDENESDECOMPRA.ToList()
                          where orden.fechaEntrega.Date <= ff.Date && orden.fechaEntrega.Date >= fi.Date
                          select orden;
            cant1 = ordenes.ToList().Count(); ;
            var proveedores = from orden in oNegocio.ORDENESDECOMPRA.ToList()
                              where orden.fechaEntrega.Date <= ff.Date && orden.fechaEntrega.Date >= fi.Date
                              group orden by orden.proveedor into grupo
                              select new
                              {
                                  Proveedor = grupo.Key
                              };
            cant2 = proveedores.ToList().Count();

            var gastos = from orden in oNegocio.ORDENESDECOMPRA.ToList()
                         where orden.fechaEntrega.Date <= ff.Date && orden.fechaEntrega.Date >= fi.Date
                         select orden;
            cant3 = Decimal.ToInt32(gastos.Sum(_ => _.totalPedido));
        }
        public override IEnumerable GenerarDatosParaGrafico1(DateTime fi, DateTime ff, out string nombre, out List<string> x, out List<int> y)
        {
            nombre = "Cantidad de Ordenes de Compra por proveedor";
            var ordenes = from orden in oNegocio.ORDENESDECOMPRA.Include("proveedor").ToList()
                          where orden.fechaEntrega.Date <= ff.Date && orden.fechaEntrega.Date >= fi.Date
                          select orden;


            var ordenesAgrupadas = from i in ordenes
                                   group i by i.proveedor.razonSocial into grupo
                                   select new
                                   {
                                       Nombre = grupo.Key,
                                       Cantidad_De_OC = grupo.Count(),
                                       Gastos = grupo.Sum(_ => _.totalPedido)
                                   };
            x = new List<string>();
            y = new List<int>();
            foreach (var item in ordenesAgrupadas)
            {
                x.Add(item.Nombre.ToString());
                y.Add(item.Cantidad_De_OC);
            }
            return ordenesAgrupadas.ToList();
        }
        public override IEnumerable GenerarDatosParaGrafico2(DateTime fi, DateTime ff, out string nombre, out List<string> x, out List<int> y)
        {
            nombre = "Cantidad de productos por Proveedor";
            var ordenes = from orden in oNegocio.ORDENESDECOMPRA.Include("proveedor").Include(_ => _.itemsoc).ToList()
                          where orden.fechaEntrega.Date <= ff.Date && orden.fechaEntrega.Date >= fi.Date
                          select orden;

            List<MODELO.ITEMOC> itemsOC = new List<MODELO.ITEMOC>();
            foreach (var orden in ordenes.ToList())
            {
                var items = from item in oNegocio.ITEMSOC.Include(_ => _.producto).Include(_ => _.ordenCompra).Include(_ => _.producto.categoria).ToList()
                            where item.ordenCompra == orden
                            select item;

                foreach (var item in items.ToList())
                {
                    itemsOC.Add(item);
                }
            }


            var itemsAgrupados = from i in itemsOC
                                 group i by new { i.ordenCompra.proveedor.razonSocial } into grupo
                                 select new
                                 {
                                     Proveedor = grupo.Key.razonSocial,
                                     //Categoria = grupo.Key.categoria,
                                     Productos = grupo.Count(),
                                     Items = grupo.Sum(_ => _.cantidad),
                                     Gastos = grupo.Sum(_ => _.subtotal)
                                 };
            x = new List<string>();
            y = new List<int>();
            foreach (var item in itemsAgrupados)
            {
                x.Add(item.Proveedor);
                y.Add(item.Productos);
            }
            return itemsAgrupados.ToList();
        }

    }
    public class DATOSDECLIENTES : DATOSDEREPORTE
    {
        DATOS.NEGOCIO oNegocio;
        public DATOSDECLIENTES()
        {
            oNegocio = DATOS.NEGOCIO.obtener_instancia();
        }

        public override IEnumerable listar(DateTime fi, DateTime ff)
        {
            var clientes = from cliente in oNegocio.CLIENTES.ToList()
                           where cliente.fechaNacimiento.Date <= ff.Date && cliente.fechaNacimiento.Date >= fi.Date
                           select cliente;
            return clientes.ToList();
        }
        public override void Cantidades(DateTime fi, DateTime ff, out string nombre, out string nombre2, out string nombre3, out int cant1, out int cant2, out int cant3)
        {
            nombre = "Cantidad de Clientes:";
            nombre2 = "Cant. de Ventas:";
            nombre3 = "Ganancia total Aprox:";
            cant1 = 0;
            cant2 = 0;
            cant3 = 0;
            var clientes = from venta in oNegocio.VENTAS.Include(_ => _.cliente).Include(_ => _.itemsv).ToList()
                           where venta.fecha.Date <= ff.Date && venta.fecha.Date >= fi.Date
                           group venta by venta.cliente.nombreApellido into cliente
                           select new { Cliente = cliente.Key };

            cant1 = clientes.Count();
            var ventas = from venta in oNegocio.VENTAS.Include(_ => _.cliente).Include(_ => _.itemsv).ToList()
                         where venta.fecha.Date <= ff.Date && venta.fecha.Date >= fi.Date
                         select venta;
            cant2 = ventas.Count();

            var ganancias = ventas.Sum(_ => _.pagoTotal);
            cant3 = Decimal.ToInt32(ganancias);
        }
        public override IEnumerable GenerarDatosParaGrafico1(DateTime fi, DateTime ff, out string nombre, out List<string> x, out List<int> y)
        {
            nombre = "Cantidad de Ventas por Cliente";
            var ventas = from venta in oNegocio.VENTAS.Include(_ => _.cliente).ToList()
                         where venta.fecha.Date <= ff.Date && venta.fecha.Date >= fi.Date
                         select venta;


            var ventasAgrupadas = from i in ventas
                                  group i by i.cliente.nombreApellido into grupo
                                  select new
                                  {
                                      Cliente = grupo.Key,
                                      Cantidad_de_Ventas = grupo.Count(),
                                      Ganancias = grupo.Sum(_ => _.precioTotal)
                                  };
            x = new List<string>();
            y = new List<int>();
            foreach (var item in ventasAgrupadas)
            {
                x.Add(item.Cliente);
                y.Add(item.Cantidad_de_Ventas);
            }
            return ventasAgrupadas.ToList();
        }
        public override IEnumerable GenerarDatosParaGrafico2(DateTime fi, DateTime ff, out string nombre, out List<string> x, out List<int> y)
        {
            nombre = "Cantidad de productos vendidos por venta a Clientes";
            var ventas = from venta in oNegocio.VENTAS.Include(_ => _.cliente).Include(_ => _.itemsv).ToList()
                         where venta.fecha.Date <= ff.Date && venta.fecha.Date >= fi.Date
                         select venta;


            List<MODELO.ITEMV> itemsV = new List<MODELO.ITEMV>();
            foreach (var venta in ventas.ToList())
            {
                var items = from item in oNegocio.ITEMSV.Include("producto").Include("venta").Include(_ => _.venta.itemsv).ToList()
                            where item.venta == venta
                            select item;

                foreach (var item in items.ToList())
                {
                    itemsV.Add(item);
                }
            }

            var ventasAgrupadas = from i in itemsV
                                  group i by new { i.venta.cliente } into grupo
                                  select new
                                  {
                                      Cliente = grupo.Key.cliente.nombreApellido,
                                      Productos = grupo.Count(),
                                      Items = grupo.Sum(_=>_.cantidad),
                                      Ganancia = grupo.Sum(_ => _.subtotal),
                                      Cantidad_de_Ventas = grupo.Key.cliente.ventas.Count
                                  };
            x = new List<string>();
            y = new List<int>();
            foreach (var item in ventasAgrupadas)
            {
                x.Add(item.Cliente);
                y.Add(item.Productos);
            }
            return ventasAgrupadas.ToList();
        }

    }


    public abstract class FACTORYREPORTE
    {
        public abstract DATOSDEREPORTE CrearReporte(TipoReporte tipoReporte);
    }

    public class REPORTE : FACTORYREPORTE
    {
        public REPORTE()
        {
        }
        public override DATOSDEREPORTE CrearReporte(TipoReporte TipoReporte)
        {
            switch (TipoReporte)
            {
                case TipoReporte.Ventas:
                    return new DATOSDEVENTAS();
                case TipoReporte.OrdenesDeCompra:
                    return new DATOSORDENESDECOMPRA();
                case TipoReporte.Proveedores:
                    return new DATOSDEPROVEEDORES();
                case TipoReporte.Clientes:
                    return new DATOSDECLIENTES();
                default:
                    return new DATOSDEVENTAS();
            }
        }
    }

    public enum TipoReporte
    {
        Ventas,
        OrdenesDeCompra,
        Proveedores,
        Clientes
    }
}
