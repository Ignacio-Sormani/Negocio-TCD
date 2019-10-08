namespace DATOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class negocio07102 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PAGO", "totalFinal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.PAGO", "totalConDescuento");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PAGO", "totalConDescuento", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.PAGO", "totalFinal");
        }
    }
}
