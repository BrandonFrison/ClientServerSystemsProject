namespace StudentRegistrationCodeFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimeStamps : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        CourseDepartmentId = c.String(nullable: false, maxLength: 10),
                        CourseName = c.String(nullable: false, maxLength: 50),
                        Department_DepartmentId = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => new { t.CourseId, t.CourseDepartmentId })
                .ForeignKey("dbo.Departments", t => t.Department_DepartmentId)
                .Index(t => t.Department_DepartmentId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.String(nullable: false, maxLength: 10),
                        DepartmentName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentFirstName = c.String(nullable: false, maxLength: 50),
                        StudentLastName = c.String(nullable: false, maxLength: 50),
                        StudentMajor = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.StudentCourses",
                c => new
                    {
                        Student_StudentId = c.Int(nullable: false),
                        Course_CourseId = c.Int(nullable: false),
                        Course_CourseDepartmentId = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => new { t.Student_StudentId, t.Course_CourseId, t.Course_CourseDepartmentId })
                .ForeignKey("dbo.Students", t => t.Student_StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => new { t.Course_CourseId, t.Course_CourseDepartmentId }, cascadeDelete: true)
                .Index(t => t.Student_StudentId)
                .Index(t => new { t.Course_CourseId, t.Course_CourseDepartmentId });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentCourses", new[] { "Course_CourseId", "Course_CourseDepartmentId" }, "dbo.Courses");
            DropForeignKey("dbo.StudentCourses", "Student_StudentId", "dbo.Students");
            DropForeignKey("dbo.Courses", "Department_DepartmentId", "dbo.Departments");
            DropIndex("dbo.StudentCourses", new[] { "Course_CourseId", "Course_CourseDepartmentId" });
            DropIndex("dbo.StudentCourses", new[] { "Student_StudentId" });
            DropIndex("dbo.Courses", new[] { "Department_DepartmentId" });
            DropTable("dbo.StudentCourses");
            DropTable("dbo.Students");
            DropTable("dbo.Departments");
            DropTable("dbo.Courses");
        }
    }
}
