namespace BethanyPieShop2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingOrderDetailTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        NoOfOrder = c.Int(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        IsDelivered = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Registers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "UserId", "dbo.Registers");
            DropIndex("dbo.OrderDetails", new[] { "UserId" });
            DropTable("dbo.OrderDetails");
        }
    }
}
