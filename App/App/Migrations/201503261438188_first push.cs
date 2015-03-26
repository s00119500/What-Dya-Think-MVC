namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstpush : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Login",
                c => new
                    {
                        fakeUserLoginKey = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        UserPassword = c.String(),
                    })
                .PrimaryKey(t => t.fakeUserLoginKey);
            
            CreateTable(
                "dbo.Register",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 100),
                        email = c.String(nullable: false, maxLength: 100),
                        PhoneNumber = c.String(nullable: false, maxLength: 10),
                        Passoword = c.String(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Register");
            DropTable("dbo.Login");
        }
    }
}
