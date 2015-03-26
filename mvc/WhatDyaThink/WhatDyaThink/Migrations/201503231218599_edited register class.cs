namespace WhatDyaThink.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editedregisterclass : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Registration", "PasswordSalt");
            DropColumn("dbo.Registration", "IPAddress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Registration", "IPAddress", c => c.String());
            AddColumn("dbo.Registration", "PasswordSalt", c => c.String());
        }
    }
}
