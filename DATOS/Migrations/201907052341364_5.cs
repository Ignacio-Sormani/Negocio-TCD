namespace DATOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ACCION", "descripcionFormulario");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ACCION", "descripcionFormulario", c => c.String());
        }
    }
}
