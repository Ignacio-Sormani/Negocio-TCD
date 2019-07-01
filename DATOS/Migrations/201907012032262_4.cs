namespace DATOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PRODUCTO", "estadoActivo", c => c.Boolean(nullable: false));
            DropColumn("dbo.PRODUCTO", "Activo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PRODUCTO", "Activo", c => c.Boolean(nullable: false));
            DropColumn("dbo.PRODUCTO", "estadoActivo");
        }
    }
}
