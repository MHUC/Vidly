namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCreatedDateToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "CreatedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "CreatedDate");
        }
    }
}
