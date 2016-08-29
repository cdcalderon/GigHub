namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateTimeToGig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gigs", "GetDateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Gigs", "GetDateTime");
        }
    }
}
