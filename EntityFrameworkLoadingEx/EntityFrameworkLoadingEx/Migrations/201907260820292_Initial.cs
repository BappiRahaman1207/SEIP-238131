namespace EntityFrameworkLoadingEx.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        RegNo = c.String(),
                        Department_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departments", t => t.Department_ID)
                .Index(t => t.Department_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Department_ID", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "Department_ID" });
            DropTable("dbo.Students");
            DropTable("dbo.Departments");
        }
    }
}
