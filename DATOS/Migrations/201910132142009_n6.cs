namespace DATOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class n6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ORDENDECOMPRA", "estado", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ORDENDECOMPRA", "estado", c => c.Boolean(nullable: false));
        }
    }
}
