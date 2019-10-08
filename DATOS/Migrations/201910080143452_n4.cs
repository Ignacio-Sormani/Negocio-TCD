namespace DATOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class n4 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.ITEM", new[] { "venta_codigoVenta" });
            RenameColumn(table: "dbo.ITEM", name: "ordenCompra_codigoOrdenCompra", newName: "ORDENDECOMPRA_codigoOrdenCompra");
            RenameColumn(table: "dbo.ITEM", name: "remitoCompra_codigoRemitoCompra", newName: "REMITODECOMPRA_codigoRemitoCompra");
            RenameIndex(table: "dbo.ITEM", name: "IX_ordenCompra_codigoOrdenCompra", newName: "IX_ORDENDECOMPRA_codigoOrdenCompra");
            RenameIndex(table: "dbo.ITEM", name: "IX_remitoCompra_codigoRemitoCompra", newName: "IX_REMITODECOMPRA_codigoRemitoCompra");
            CreateIndex("dbo.ITEM", "VENTA_codigoVenta");
        }
        
        public override void Down()
        {
            DropIndex("dbo.ITEM", new[] { "VENTA_codigoVenta" });
            RenameIndex(table: "dbo.ITEM", name: "IX_REMITODECOMPRA_codigoRemitoCompra", newName: "IX_remitoCompra_codigoRemitoCompra");
            RenameIndex(table: "dbo.ITEM", name: "IX_ORDENDECOMPRA_codigoOrdenCompra", newName: "IX_ordenCompra_codigoOrdenCompra");
            RenameColumn(table: "dbo.ITEM", name: "REMITODECOMPRA_codigoRemitoCompra", newName: "remitoCompra_codigoRemitoCompra");
            RenameColumn(table: "dbo.ITEM", name: "ORDENDECOMPRA_codigoOrdenCompra", newName: "ordenCompra_codigoOrdenCompra");
            CreateIndex("dbo.ITEM", "venta_codigoVenta");
        }
    }
}
