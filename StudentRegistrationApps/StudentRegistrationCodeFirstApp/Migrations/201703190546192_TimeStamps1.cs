namespace StudentRegistrationCodeFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimeStamps1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentCourses", "CourseId", "dbo.Courses");
            DropIndex("dbo.StudentCourses", new[] { "CourseId" });
            RenameColumn(table: "dbo.Courses", name: "Department_DepartmentId", newName: "DepartmentId");
            RenameIndex(table: "dbo.Courses", name: "IX_Department_DepartmentId", newName: "IX_DepartmentId");
            DropPrimaryKey("dbo.Courses");
            DropPrimaryKey("dbo.StudentCourses");
            AddColumn("dbo.StudentCourses", "DepartmentId", c => c.String(nullable: false, maxLength: 10));
            AddPrimaryKey("dbo.Courses", new[] { "CourseId", "DepartmentId" });
            AddPrimaryKey("dbo.StudentCourses", new[] { "CourseId", "DepartmentId", "StudentId" });
            CreateIndex("dbo.StudentCourses", new[] { "CourseId", "DepartmentId" });
            AddForeignKey("dbo.StudentCourses", new[] { "CourseId", "DepartmentId" }, "dbo.Courses", new[] { "CourseId", "DepartmentId" }, cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentCourses", new[] { "CourseId", "DepartmentId" }, "dbo.Courses");
            DropIndex("dbo.StudentCourses", new[] { "CourseId", "DepartmentId" });
            DropPrimaryKey("dbo.StudentCourses");
            DropPrimaryKey("dbo.Courses");
            DropColumn("dbo.StudentCourses", "DepartmentId");
            AddPrimaryKey("dbo.StudentCourses", new[] { "CourseId", "StudentId" });
            AddPrimaryKey("dbo.Courses", "CourseId");
            RenameIndex(table: "dbo.Courses", name: "IX_DepartmentId", newName: "IX_Department_DepartmentId");
            RenameColumn(table: "dbo.Courses", name: "DepartmentId", newName: "Department_DepartmentId");
            CreateIndex("dbo.StudentCourses", "CourseId");
            AddForeignKey("dbo.StudentCourses", "CourseId", "dbo.Courses", "CourseId", cascadeDelete: true);
        }
    }
}
