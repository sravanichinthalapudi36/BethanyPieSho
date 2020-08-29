namespace BethanyPieShop2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingonechangeinProdctDetailTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductDetails", "ImagePath", c => c.String());
            DropColumn("dbo.ProductDetails", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductDetails", "Image", c => c.Binary());
            DropColumn("dbo.ProductDetails", "ImagePath");
        }
    }
}
