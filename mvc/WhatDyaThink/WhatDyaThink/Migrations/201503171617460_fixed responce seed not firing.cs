namespace WhatDyaThink.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedresponceseednotfiring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Responces", "responceType", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Responces", "responceType", c => c.Int(nullable: false));
        }
    }
}
