namespace DATOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class negocio1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ACCESO",
                c => new
                    {
                        codigoAcceso = c.Int(nullable: false, identity: true),
                        fechaLogin = c.DateTime(nullable: false),
                        fechaLogout = c.DateTime(nullable: false),
                        usuario_codigoUsuario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.codigoAcceso)
                .ForeignKey("dbo.USUARIO", t => t.usuario_codigoUsuario)
                .Index(t => t.usuario_codigoUsuario);
            
            CreateTable(
                "dbo.USUARIO",
                c => new
                    {
                        codigoUsuario = c.Int(nullable: false, identity: true),
                        nombreDeUsuario = c.String(),
                        nombreApellido = c.String(),
                        clave = c.String(),
                        mail = c.String(),
                        estadoActivo = c.Boolean(nullable: false),
                        conectado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.codigoUsuario);
            
            CreateTable(
                "dbo.GRUPO",
                c => new
                    {
                        codigoGrupo = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        estadoActivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.codigoGrupo);
            
            CreateTable(
                "dbo.ACCION",
                c => new
                    {
                        codigoAccion = c.Int(nullable: false, identity: true),
                        descripcionAccion = c.String(),
                        control = c.String(),
                        nombreFormulario = c.String(),
                        modulo = c.String(),
                    })
                .PrimaryKey(t => t.codigoAccion);
            
            CreateTable(
                "dbo.CATEGORIA",
                c => new
                    {
                        codigoCategoria = c.Int(nullable: false, identity: true),
                        categoria = c.String(),
                    })
                .PrimaryKey(t => t.codigoCategoria);
            
            CreateTable(
                "dbo.CLIENTE",
                c => new
                    {
                        codigoCliente = c.Int(nullable: false, identity: true),
                        dni = c.Int(nullable: false),
                        nombreApellido = c.String(),
                        fechaNacimiento = c.DateTime(nullable: false),
                        direccion = c.String(),
                        telefono = c.Int(nullable: false),
                        mail = c.String(),
                        localidad_codigoLocalidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.codigoCliente)
                .ForeignKey("dbo.LOCALIDAD", t => t.localidad_codigoLocalidad)
                .Index(t => t.localidad_codigoLocalidad);
            
            CreateTable(
                "dbo.LOCALIDAD",
                c => new
                    {
                        codigoLocalidad = c.Int(nullable: false, identity: true),
                        codigoPostal = c.Int(nullable: false),
                        localidad = c.String(),
                    })
                .PrimaryKey(t => t.codigoLocalidad);
            
            CreateTable(
                "dbo.VENTA",
                c => new
                    {
                        codigoVenta = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false),
                        precioTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        pagoTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        cliente_codigoCliente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.codigoVenta)
                .ForeignKey("dbo.CLIENTE", t => t.cliente_codigoCliente)
                .Index(t => t.cliente_codigoCliente);
            
            CreateTable(
                "dbo.ITEM",
                c => new
                    {
                        codigoItem = c.Int(nullable: false, identity: true),
                        cantidad = c.Int(nullable: false),
                        precioUnitarioVenta = c.Decimal(precision: 18, scale: 2),
                        precioUnitarioPresupuesto = c.Decimal(precision: 18, scale: 2),
                        precioUnitarioCompra = c.Decimal(precision: 18, scale: 2),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        venta_codigoVenta = c.Int(),
                        ordenCompra_codigoOrdenCompra = c.Int(),
                        remitoCompra_codigoRemitoCompra = c.Int(),
                        producto_codigoProducto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.codigoItem)
                .ForeignKey("dbo.VENTA", t => t.venta_codigoVenta)
                .ForeignKey("dbo.ORDENDECOMPRA", t => t.ordenCompra_codigoOrdenCompra)
                .ForeignKey("dbo.REMITODECOMPRA", t => t.remitoCompra_codigoRemitoCompra)
                .ForeignKey("dbo.PRODUCTO", t => t.producto_codigoProducto)
                .Index(t => t.venta_codigoVenta)
                .Index(t => t.ordenCompra_codigoOrdenCompra)
                .Index(t => t.remitoCompra_codigoRemitoCompra)
                .Index(t => t.producto_codigoProducto);
            
            CreateTable(
                "dbo.PRODUCTO",
                c => new
                    {
                        codigoProducto = c.Int(nullable: false, identity: true),
                        descripcion = c.String(),
                        precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        cantidadActual = c.Int(nullable: false),
                        cantidadMinima = c.Int(nullable: false),
                        cantidadOperativa = c.Int(nullable: false),
                        estado = c.String(),
                        estadoActivo = c.Boolean(nullable: false),
                        categoria_codigoCategoria = c.Int(nullable: false),
                        marca_codigoMarca = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.codigoProducto)
                .ForeignKey("dbo.CATEGORIA", t => t.categoria_codigoCategoria)
                .ForeignKey("dbo.MARCA", t => t.marca_codigoMarca)
                .Index(t => t.categoria_codigoCategoria)
                .Index(t => t.marca_codigoMarca);
            
            CreateTable(
                "dbo.MARCA",
                c => new
                    {
                        codigoMarca = c.Int(nullable: false, identity: true),
                        marca = c.String(),
                    })
                .PrimaryKey(t => t.codigoMarca);
            
            CreateTable(
                "dbo.PAGO",
                c => new
                    {
                        codigoPago = c.Int(nullable: false),
                        total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        totalFinal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        cantidadCuotas = c.Int(nullable: false),
                        precioCuota = c.Decimal(nullable: false, precision: 18, scale: 2),
                        venta_codigoVenta = c.Int(),
                    })
                .PrimaryKey(t => t.codigoPago)
                .ForeignKey("dbo.FORMAPAGO", t => t.codigoPago)
                .ForeignKey("dbo.VENTA", t => t.venta_codigoVenta)
                .Index(t => t.codigoPago)
                .Index(t => t.venta_codigoVenta);
            
            CreateTable(
                "dbo.FORMAPAGO",
                c => new
                    {
                        codigoFormaPago = c.Int(nullable: false, identity: true),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.codigoFormaPago);
            
            CreateTable(
                "dbo.ORDENDECOMPRA",
                c => new
                    {
                        codigoOrdenCompra = c.Int(nullable: false, identity: true),
                        fechaPedido = c.DateTime(nullable: false),
                        fechaEntrega = c.DateTime(nullable: false),
                        totalPedido = c.Decimal(nullable: false, precision: 18, scale: 2),
                        estado = c.String(),
                        proveedor_codigoProveedor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.codigoOrdenCompra)
                .ForeignKey("dbo.PROVEEDOR", t => t.proveedor_codigoProveedor)
                .Index(t => t.proveedor_codigoProveedor);
            
            CreateTable(
                "dbo.PROVEEDOR",
                c => new
                    {
                        codigoProveedor = c.Int(nullable: false, identity: true),
                        cuit = c.Int(nullable: false),
                        razonSocial = c.String(),
                        direccion = c.String(),
                        telefono = c.Int(nullable: false),
                        mail = c.String(),
                        localidad_codigoLocalidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.codigoProveedor)
                .ForeignKey("dbo.LOCALIDAD", t => t.localidad_codigoLocalidad)
                .Index(t => t.localidad_codigoLocalidad);
            
            CreateTable(
                "dbo.REMITODECOMPRA",
                c => new
                    {
                        codigoRemitoCompra = c.Int(nullable: false, identity: true),
                        fechaEntrega = c.DateTime(nullable: false),
                        fechaRecibida = c.DateTime(nullable: false),
                        total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        proveedor_codigoProveedor = c.Int(),
                        ordenCompra_codigoOrdenCompra = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.codigoRemitoCompra)
                .ForeignKey("dbo.PROVEEDOR", t => t.proveedor_codigoProveedor)
                .ForeignKey("dbo.ORDENDECOMPRA", t => t.ordenCompra_codigoOrdenCompra)
                .Index(t => t.proveedor_codigoProveedor)
                .Index(t => t.ordenCompra_codigoOrdenCompra);
            
            CreateTable(
                "dbo.GRUPO_ACCION",
                c => new
                    {
                        codigoGrupo = c.Int(nullable: false),
                        codigoAccion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.codigoGrupo, t.codigoAccion })
                .ForeignKey("dbo.GRUPO", t => t.codigoGrupo, cascadeDelete: true)
                .ForeignKey("dbo.ACCION", t => t.codigoAccion, cascadeDelete: true)
                .Index(t => t.codigoGrupo)
                .Index(t => t.codigoAccion);
            
            CreateTable(
                "dbo.USUARIO_GRUPO",
                c => new
                    {
                        codigoUsuario = c.Int(nullable: false),
                        codigoGrupo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.codigoUsuario, t.codigoGrupo })
                .ForeignKey("dbo.USUARIO", t => t.codigoUsuario, cascadeDelete: true)
                .ForeignKey("dbo.GRUPO", t => t.codigoGrupo, cascadeDelete: true)
                .Index(t => t.codigoUsuario)
                .Index(t => t.codigoGrupo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ITEM", "producto_codigoProducto", "dbo.PRODUCTO");
            DropForeignKey("dbo.REMITODECOMPRA", "ordenCompra_codigoOrdenCompra", "dbo.ORDENDECOMPRA");
            DropForeignKey("dbo.REMITODECOMPRA", "proveedor_codigoProveedor", "dbo.PROVEEDOR");
            DropForeignKey("dbo.ITEM", "remitoCompra_codigoRemitoCompra", "dbo.REMITODECOMPRA");
            DropForeignKey("dbo.ORDENDECOMPRA", "proveedor_codigoProveedor", "dbo.PROVEEDOR");
            DropForeignKey("dbo.PROVEEDOR", "localidad_codigoLocalidad", "dbo.LOCALIDAD");
            DropForeignKey("dbo.ITEM", "ordenCompra_codigoOrdenCompra", "dbo.ORDENDECOMPRA");
            DropForeignKey("dbo.PAGO", "venta_codigoVenta", "dbo.VENTA");
            DropForeignKey("dbo.PAGO", "codigoPago", "dbo.FORMAPAGO");
            DropForeignKey("dbo.ITEM", "venta_codigoVenta", "dbo.VENTA");
            DropForeignKey("dbo.PRODUCTO", "marca_codigoMarca", "dbo.MARCA");
            DropForeignKey("dbo.PRODUCTO", "categoria_codigoCategoria", "dbo.CATEGORIA");
            DropForeignKey("dbo.VENTA", "cliente_codigoCliente", "dbo.CLIENTE");
            DropForeignKey("dbo.CLIENTE", "localidad_codigoLocalidad", "dbo.LOCALIDAD");
            DropForeignKey("dbo.ACCESO", "usuario_codigoUsuario", "dbo.USUARIO");
            DropForeignKey("dbo.USUARIO_GRUPO", "codigoGrupo", "dbo.GRUPO");
            DropForeignKey("dbo.USUARIO_GRUPO", "codigoUsuario", "dbo.USUARIO");
            DropForeignKey("dbo.GRUPO_ACCION", "codigoAccion", "dbo.ACCION");
            DropForeignKey("dbo.GRUPO_ACCION", "codigoGrupo", "dbo.GRUPO");
            DropIndex("dbo.USUARIO_GRUPO", new[] { "codigoGrupo" });
            DropIndex("dbo.USUARIO_GRUPO", new[] { "codigoUsuario" });
            DropIndex("dbo.GRUPO_ACCION", new[] { "codigoAccion" });
            DropIndex("dbo.GRUPO_ACCION", new[] { "codigoGrupo" });
            DropIndex("dbo.REMITODECOMPRA", new[] { "ordenCompra_codigoOrdenCompra" });
            DropIndex("dbo.REMITODECOMPRA", new[] { "proveedor_codigoProveedor" });
            DropIndex("dbo.PROVEEDOR", new[] { "localidad_codigoLocalidad" });
            DropIndex("dbo.ORDENDECOMPRA", new[] { "proveedor_codigoProveedor" });
            DropIndex("dbo.PAGO", new[] { "venta_codigoVenta" });
            DropIndex("dbo.PAGO", new[] { "codigoPago" });
            DropIndex("dbo.PRODUCTO", new[] { "marca_codigoMarca" });
            DropIndex("dbo.PRODUCTO", new[] { "categoria_codigoCategoria" });
            DropIndex("dbo.ITEM", new[] { "producto_codigoProducto" });
            DropIndex("dbo.ITEM", new[] { "remitoCompra_codigoRemitoCompra" });
            DropIndex("dbo.ITEM", new[] { "ordenCompra_codigoOrdenCompra" });
            DropIndex("dbo.ITEM", new[] { "venta_codigoVenta" });
            DropIndex("dbo.VENTA", new[] { "cliente_codigoCliente" });
            DropIndex("dbo.CLIENTE", new[] { "localidad_codigoLocalidad" });
            DropIndex("dbo.ACCESO", new[] { "usuario_codigoUsuario" });
            DropTable("dbo.USUARIO_GRUPO");
            DropTable("dbo.GRUPO_ACCION");
            DropTable("dbo.REMITODECOMPRA");
            DropTable("dbo.PROVEEDOR");
            DropTable("dbo.ORDENDECOMPRA");
            DropTable("dbo.FORMAPAGO");
            DropTable("dbo.PAGO");
            DropTable("dbo.MARCA");
            DropTable("dbo.PRODUCTO");
            DropTable("dbo.ITEM");
            DropTable("dbo.VENTA");
            DropTable("dbo.LOCALIDAD");
            DropTable("dbo.CLIENTE");
            DropTable("dbo.CATEGORIA");
            DropTable("dbo.ACCION");
            DropTable("dbo.GRUPO");
            DropTable("dbo.USUARIO");
            DropTable("dbo.ACCESO");
        }
    }
}
