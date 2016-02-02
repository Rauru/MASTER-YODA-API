namespace MasterYodaAPI.DataAdapterLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addcarrera : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carreras",
                c => new
                    {
                        carreraID = c.Int(nullable: false, identity: true),
                        carrera = c.String(),
                    })
                .PrimaryKey(t => t.carreraID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Carreras");
        }
    }
}
