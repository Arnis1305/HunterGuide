namespace HunterGuide.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateApplicationUserAddStatusTypeFild : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ApplicationUsers", "StatusType", c => c.Int(nullable: false));
            DropColumn("dbo.ApplicationUsers", "IsActivated");
            DropColumn("dbo.ApplicationUsers", "IsRejected");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ApplicationUsers", "IsRejected", c => c.Boolean(nullable: false));
            AddColumn("dbo.ApplicationUsers", "IsActivated", c => c.Boolean(nullable: false));
            DropColumn("dbo.ApplicationUsers", "StatusType");
        }
    }
}
