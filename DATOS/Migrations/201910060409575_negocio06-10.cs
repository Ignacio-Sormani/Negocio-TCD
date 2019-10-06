namespace DATOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class negocio0610 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VENTA", "estado", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ORDENDECOMPRA", "estado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ORDENDECOMPRA", "estado", c => c.String());
            DropColumn("dbo.VENTA", "estado");
        }
    }
}
