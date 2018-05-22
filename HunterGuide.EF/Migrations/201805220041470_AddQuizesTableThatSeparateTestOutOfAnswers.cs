namespace HunterGuide.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuizesTableThatSeparateTestOutOfAnswers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Quizs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstAnswer = c.String(nullable: false),
                        SecondAnswer = c.String(nullable: false),
                        ThirdAnswer = c.String(nullable: false),
                        FourthAnswer = c.String(nullable: false),
                        CorrectAnswerNumber = c.Int(nullable: false),
                        TestId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tests", t => t.TestId, cascadeDelete: true)
                .Index(t => t.TestId);
            
            DropColumn("dbo.Tests", "FirstAnswer");
            DropColumn("dbo.Tests", "SecondAnswer");
            DropColumn("dbo.Tests", "ThirdAnswer");
            DropColumn("dbo.Tests", "FourthAnswer");
            DropColumn("dbo.Tests", "CorrectAnswerNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tests", "CorrectAnswerNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Tests", "FourthAnswer", c => c.String(nullable: false));
            AddColumn("dbo.Tests", "ThirdAnswer", c => c.String(nullable: false));
            AddColumn("dbo.Tests", "SecondAnswer", c => c.String(nullable: false));
            AddColumn("dbo.Tests", "FirstAnswer", c => c.String(nullable: false));
            DropForeignKey("dbo.Quizs", "TestId", "dbo.Tests");
            DropIndex("dbo.Quizs", new[] { "TestId" });
            DropTable("dbo.Quizs");
        }
    }
}
