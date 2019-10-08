namespace DATOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class negocio0710 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VENTA", "precioTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.VENTA", "pagoTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.PAGO", "totalConDescuento", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.FORMAPAGO", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.VENTA", "total");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VENTA", "total", c => c.Int(nullable: false));
            DropColumn("dbo.FORMAPAGO", "Discriminator");
            DropColumn("dbo.PAGO", "totalConDescuento");
            DropColumn("dbo.VENTA", "pagoTotal");
            DropColumn("dbo.VENTA", "precioTotal");
        }
    }
}
