namespace WhatDyaThink.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2edfixedseed : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ResponcesQuestion", "Responces_responceID", "dbo.Responces");
            DropForeignKey("dbo.ResponcesQuestion", "Question_questionID", "dbo.Question");
            DropIndex("dbo.ResponcesQuestion", new[] { "Responces_responceID" });
            DropIndex("dbo.ResponcesQuestion", new[] { "Question_questionID" });
            CreateIndex("dbo.Responces", "questionID");
            AddForeignKey("dbo.Responces", "questionID", "dbo.Question", "questionID", cascadeDelete: true);
            DropTable("dbo.ResponcesQuestion");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ResponcesQuestion",
                c => new
                    {
                        Responces_responceID = c.Int(nullable: false),
                        Question_questionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Responces_responceID, t.Question_questionID });
            
            DropForeignKey("dbo.Responces", "questionID", "dbo.Question");
            DropIndex("dbo.Responces", new[] { "questionID" });
            CreateIndex("dbo.ResponcesQuestion", "Question_questionID");
            CreateIndex("dbo.ResponcesQuestion", "Responces_responceID");
            AddForeignKey("dbo.ResponcesQuestion", "Question_questionID", "dbo.Question", "questionID", cascadeDelete: true);
            AddForeignKey("dbo.ResponcesQuestion", "Responces_responceID", "dbo.Responces", "responceID", cascadeDelete: true);
        }
    }
}
