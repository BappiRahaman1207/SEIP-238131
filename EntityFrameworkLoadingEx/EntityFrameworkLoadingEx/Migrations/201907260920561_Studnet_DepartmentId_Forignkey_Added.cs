namespace EntityFrameworkLoadingEx.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Studnet_DepartmentId_Forignkey_Added : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Department_ID", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "Department_ID" });
            RenameColumn(table: "dbo.Students", name: "Department_ID", newName: "DepartmentId");
            AlterColumn("dbo.Students", "DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "DepartmentId");
            AddForeignKey("dbo.Students", "DepartmentId", "dbo.Departments", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "DepartmentId" });
            AlterColumn("dbo.Students", "DepartmentId", c => c.Int());
            RenameColumn(table: "dbo.Students", name: "DepartmentId", newName: "Department_ID");
            CreateIndex("dbo.Students", "Department_ID");
            AddForeignKey("dbo.Students", "Department_ID", "dbo.Departments", "ID");
        }
    }
}
