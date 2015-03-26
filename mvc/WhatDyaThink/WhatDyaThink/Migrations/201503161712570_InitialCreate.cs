namespace WhatDyaThink.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        questionID = c.Int(nullable: false, identity: true),
                        surveyID = c.Int(nullable: false),
                        questionType = c.Int(nullable: false),
                        questionText = c.String(),
                    })
                .PrimaryKey(t => t.questionID)
                .ForeignKey("dbo.Survey", t => t.surveyID, cascadeDelete: true)
                .Index(t => t.surveyID);
            
            CreateTable(
                "dbo.Responces",
                c => new
                    {
                        responceID = c.Int(nullable: false, identity: true),
                        questionID = c.Int(nullable: false),
                        responceType = c.Int(nullable: false),
                        responceText = c.String(),
                        responceCSS = c.String(),
                        responceValue = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.responceID)
                .ForeignKey("dbo.Question", t => t.questionID, cascadeDelete: true)
                .Index(t => t.questionID);
            
            CreateTable(
                "dbo.Survey",
                c => new
                    {
                        surveyID = c.Int(nullable: false, identity: true),
                        surveyName = c.String(),
                    })
                .PrimaryKey(t => t.surveyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Question", "surveyID", "dbo.Survey");
            DropForeignKey("dbo.Responces", "questionID", "dbo.Question");
            DropIndex("dbo.Responces", new[] { "questionID" });
            DropIndex("dbo.Question", new[] { "surveyID" });
            DropTable("dbo.Survey");
            DropTable("dbo.Responces");
            DropTable("dbo.Question");
        }
    }
}
