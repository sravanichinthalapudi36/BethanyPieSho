namespace BethanyPieShop2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingProductDetailTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductDetails",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        Price = c.Double(nullable: false),
                        Image = c.Binary(),
                        CatagoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Categories", t => t.CatagoryId, cascadeDelete: true)
                .Index(t => t.CatagoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductDetails", "CatagoryId", "dbo.Categories");
            DropIndex("dbo.ProductDetails", new[] { "CatagoryId" });
            DropTable("dbo.ProductDetails");
        }
    }
}
