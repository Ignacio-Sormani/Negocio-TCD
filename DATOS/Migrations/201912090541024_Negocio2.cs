namespace DATOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Negocio2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CLIENTE", "dni", c => c.Long(nullable: false));
            AlterColumn("dbo.CLIENTE", "telefono", c => c.Long(nullable: false));
            AlterColumn("dbo.PROVEEDOR", "cuit", c => c.Long(nullable: false));
            AlterColumn("dbo.PROVEEDOR", "telefono", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PROVEEDOR", "telefono", c => c.Int(nullable: false));
            AlterColumn("dbo.PROVEEDOR", "cuit", c => c.Int(nullable: false));
            AlterColumn("dbo.CLIENTE", "telefono", c => c.Int(nullable: false));
            AlterColumn("dbo.CLIENTE", "dni", c => c.Int(nullable: false));
        }
    }
}
