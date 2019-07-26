namespace EntityFrameworkExamples.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class product_Description : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Description", c => c.String());
            AddColumn("dbo.Products", "Category", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Category");
            DropColumn("dbo.Products", "Description");
        }
    }
}
