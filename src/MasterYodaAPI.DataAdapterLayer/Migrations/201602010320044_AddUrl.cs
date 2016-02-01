namespace MasterYodaAPI.DataAdapterLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "url", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "url");
        }
    }
}
