namespace HunterGuide.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingFieldIsRejectedToApplicationUserEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ApplicationUsers", "IsRejected", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ApplicationUsers", "IsRejected");
        }
    }
}
