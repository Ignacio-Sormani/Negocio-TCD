namespace DATOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class n4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.VENTA", "estado");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VENTA", "estado", c => c.Boolean(nullable: false));
        }
    }
}
