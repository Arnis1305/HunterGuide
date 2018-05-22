namespace HunterGuide.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuestionFieldToQuizEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Quizs", "Question", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Quizs", "Question");
        }
    }
}
