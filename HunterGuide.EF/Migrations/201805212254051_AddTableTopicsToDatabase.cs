namespace HunterGuide.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableTopicsToDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TestTopics",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TopicName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Tests", "TestTopicId", c => c.Guid(nullable: false));
            AddColumn("dbo.TestTypes", "TypeName", c => c.String(nullable: false));
            CreateIndex("dbo.Tests", "TestTopicId");
            AddForeignKey("dbo.Tests", "TestTopicId", "dbo.TestTopics", "Id", cascadeDelete: true);
            DropColumn("dbo.TestTypes", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TestTypes", "Name", c => c.String(nullable: false));
            DropForeignKey("dbo.Tests", "TestTopicId", "dbo.TestTopics");
            DropIndex("dbo.Tests", new[] { "TestTopicId" });
            DropColumn("dbo.TestTypes", "TypeName");
            DropColumn("dbo.Tests", "TestTopicId");
            DropTable("dbo.TestTopics");
        }
    }
}
