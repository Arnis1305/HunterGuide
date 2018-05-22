namespace HunterGuide.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestsAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserTestResults",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Mark = c.Int(nullable: false),
                        CompletionDate = c.DateTime(nullable: false),
                        ApplicationUserId = c.Guid(nullable: false),
                        TestId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUserId, cascadeDelete: true)
                .ForeignKey("dbo.Tests", t => t.TestId, cascadeDelete: true)
                .Index(t => t.ApplicationUserId)
                .Index(t => t.TestId);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TestTypeId = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        FirstAnswer = c.String(nullable: false),
                        SecondAnswer = c.String(nullable: false),
                        ThirdAnswer = c.String(nullable: false),
                        FourthAnswer = c.String(nullable: false),
                        CorrectAnswerNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TestTypes", t => t.TestTypeId, cascadeDelete: true)
                .Index(t => t.TestTypeId);
            
            CreateTable(
                "dbo.TestTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserTestResults", "TestId", "dbo.Tests");
            DropForeignKey("dbo.Tests", "TestTypeId", "dbo.TestTypes");
            DropForeignKey("dbo.UserTestResults", "ApplicationUserId", "dbo.ApplicationUsers");
            DropIndex("dbo.Tests", new[] { "TestTypeId" });
            DropIndex("dbo.UserTestResults", new[] { "TestId" });
            DropIndex("dbo.UserTestResults", new[] { "ApplicationUserId" });
            DropTable("dbo.TestTypes");
            DropTable("dbo.Tests");
            DropTable("dbo.UserTestResults");
        }
    }
}
