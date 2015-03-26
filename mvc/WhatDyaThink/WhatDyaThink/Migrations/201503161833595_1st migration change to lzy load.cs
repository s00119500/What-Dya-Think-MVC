namespace WhatDyaThink.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1stmigrationchangetolzyload : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Responces", "questionID", "dbo.Question");
            DropIndex("dbo.Responces", new[] { "questionID" });
            CreateTable(
                "dbo.ResponcesQuestion",
                c => new
                    {
                        Responces_responceID = c.Int(nullable: false),
                        Question_questionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Responces_responceID, t.Question_questionID })
                .ForeignKey("dbo.Responces", t => t.Responces_responceID, cascadeDelete: true)
                .ForeignKey("dbo.Question", t => t.Question_questionID, cascadeDelete: true)
                .Index(t => t.Responces_responceID)
                .Index(t => t.Question_questionID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ResponcesQuestion", "Question_questionID", "dbo.Question");
            DropForeignKey("dbo.ResponcesQuestion", "Responces_responceID", "dbo.Responces");
            DropIndex("dbo.ResponcesQuestion", new[] { "Question_questionID" });
            DropIndex("dbo.ResponcesQuestion", new[] { "Responces_responceID" });
            DropTable("dbo.ResponcesQuestion");
            CreateIndex("dbo.Responces", "questionID");
            AddForeignKey("dbo.Responces", "questionID", "dbo.Question", "questionID", cascadeDelete: true);
        }
    }
}
