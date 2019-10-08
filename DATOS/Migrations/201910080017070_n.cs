namespace DATOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class n : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.PAGO", new[] { "venta_codigoVenta" });
            AlterColumn("dbo.PAGO", "venta_codigoVenta", c => c.Int());
            CreateIndex("dbo.PAGO", "venta_codigoVenta");
        }
        
        public override void Down()
        {
            DropIndex("dbo.PAGO", new[] { "venta_codigoVenta" });
            AlterColumn("dbo.PAGO", "venta_codigoVenta", c => c.Int(nullable: false));
            CreateIndex("dbo.PAGO", "venta_codigoVenta");
        }
    }
}
