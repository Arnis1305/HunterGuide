namespace HunterGuide.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingFieldIsActivatedToApplicationUserEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ApplicationUsers", "IsActivated", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ApplicationUsers", "IsActivated");
        }
    }
}
