namespace BethanyPieShop2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingRegisterTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registers",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FName = c.String(nullable: false, maxLength: 20),
                        LName = c.String(nullable: false, maxLength: 20),
                        PhoneNo = c.String(nullable: false),
                        EmailId = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Registers");
        }
    }
}
