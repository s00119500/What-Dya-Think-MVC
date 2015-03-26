namespace WhatDyaThink.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRegistrationclass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registration",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 150),
                        Password = c.String(nullable: false, maxLength: 150),
                        PasswordSalt = c.String(),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        UserType = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IPAddress = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Registration");
        }
    }
}
