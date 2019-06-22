namespace DATOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.ACCESO", new[] { "usuario_codigoUsuario" });
            AddColumn("dbo.USUARIO", "estadoActivo", c => c.Boolean(nullable: false));
            AddColumn("dbo.GRUPO", "estadoActivo", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ACCESO", "usuario_codigoUsuario", c => c.Int(nullable: false));
            CreateIndex("dbo.ACCESO", "usuario_codigoUsuario");
            DropColumn("dbo.USUARIO", "estado");
            DropColumn("dbo.GRUPO", "estado");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GRUPO", "estado", c => c.Boolean(nullable: false));
            AddColumn("dbo.USUARIO", "estado", c => c.String());
            DropIndex("dbo.ACCESO", new[] { "usuario_codigoUsuario" });
            AlterColumn("dbo.ACCESO", "usuario_codigoUsuario", c => c.Int());
            DropColumn("dbo.GRUPO", "estadoActivo");
            DropColumn("dbo.USUARIO", "estadoActivo");
            CreateIndex("dbo.ACCESO", "usuario_codigoUsuario");
        }
    }
}
