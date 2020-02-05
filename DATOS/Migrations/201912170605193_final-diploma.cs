namespace DATOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finaldiploma : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AUDITORIACLIENTE",
                c => new
                    {
                        codigoAuditoriaCliente = c.Int(nullable: false, identity: true),
                        dni = c.Long(nullable: false),
                        nombreApellido = c.String(),
                        fechaNacimiento = c.DateTime(nullable: false),
                        direccion = c.String(),
                        telefono = c.Long(nullable: false),
                        mail = c.String(),
                        auditoriaFecha = c.DateTime(nullable: false),
                        auditoriaMovimiento = c.String(),
                        auditoriaUsuario_codigoUsuario = c.Int(),
                        localidad_codigoLocalidad = c.Int(),
                    })
                .PrimaryKey(t => t.codigoAuditoriaCliente)
                .ForeignKey("dbo.USUARIO", t => t.auditoriaUsuario_codigoUsuario)
                .ForeignKey("dbo.LOCALIDAD", t => t.localidad_codigoLocalidad)
                .Index(t => t.auditoriaUsuario_codigoUsuario)
                .Index(t => t.localidad_codigoLocalidad);
            
            AddColumn("dbo.CLIENTE", "auditoriaFecha", c => c.DateTime(nullable: false));
            AddColumn("dbo.CLIENTE", "auditoriaMovimiento", c => c.String());
            AddColumn("dbo.CLIENTE", "auditoriaUsuario_codigoUsuario", c => c.Int());
            CreateIndex("dbo.CLIENTE", "auditoriaUsuario_codigoUsuario");
            AddForeignKey("dbo.CLIENTE", "auditoriaUsuario_codigoUsuario", "dbo.USUARIO", "codigoUsuario");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CLIENTE", "auditoriaUsuario_codigoUsuario", "dbo.USUARIO");
            DropForeignKey("dbo.AUDITORIACLIENTE", "localidad_codigoLocalidad", "dbo.LOCALIDAD");
            DropForeignKey("dbo.AUDITORIACLIENTE", "auditoriaUsuario_codigoUsuario", "dbo.USUARIO");
            DropIndex("dbo.CLIENTE", new[] { "auditoriaUsuario_codigoUsuario" });
            DropIndex("dbo.AUDITORIACLIENTE", new[] { "localidad_codigoLocalidad" });
            DropIndex("dbo.AUDITORIACLIENTE", new[] { "auditoriaUsuario_codigoUsuario" });
            DropColumn("dbo.CLIENTE", "auditoriaUsuario_codigoUsuario");
            DropColumn("dbo.CLIENTE", "auditoriaMovimiento");
            DropColumn("dbo.CLIENTE", "auditoriaFecha");
            DropTable("dbo.AUDITORIACLIENTE");
        }
    }
}
