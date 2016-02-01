namespace MasterYodaAPI.DataAdapterLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userId = c.Int(nullable: false, identity: true),
                        correo = c.String(),
                        numero_de_cuenta = c.String(),
                        primer_numbre = c.String(),
                        segundo_numbre = c.String(),
                        primer_apellido = c.String(),
                        segundo_apellido = c.String(),
                        contraseña = c.String(),
                        telefono = c.String(),
                    })
                .PrimaryKey(t => t.userId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
