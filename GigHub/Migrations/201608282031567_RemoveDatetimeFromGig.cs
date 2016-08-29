namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDatetimeFromGig : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Gigs", "GetDateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Gigs", "GetDateTime", c => c.DateTime(nullable: false));
        }
    }
}
