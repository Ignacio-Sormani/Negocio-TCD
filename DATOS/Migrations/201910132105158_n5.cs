namespace DATOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class n5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ITEM", "precioUnitarioPresupuesto", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.ORDENDECOMPRA", "totalPedido", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.PRODUCTO", "costo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PRODUCTO", "costo", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.ORDENDECOMPRA", "totalPedido");
            DropColumn("dbo.ITEM", "precioUnitarioPresupuesto");
        }
    }
}
