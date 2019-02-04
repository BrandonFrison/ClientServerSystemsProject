using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentRegistrationConsoleApp.EF_Classes;
using System.Diagnostics;

namespace StudentRegistrationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            createRegistrationDataTables();
        }

        static private void createRegistrationDataTables()
        {
            // students data

            List<Student> students = new List<Student>()
            {
                new Student { StudentFirstName = "Svetlana", StudentLastName = "Rostov", StudentMajor = "CSIS" },
                new Student { StudentFirstName = "Claire", StudentLastName = "Bloome", StudentMajor = "ACCT" },
                new Student { StudentFirstName = "Sven", StudentLastName = "Baertschi", StudentMajor = "MKTG" },
                new Student { StudentFirstName = "Cesar", StudentLastName = "Chavez", StudentMajor = "FINC" },
                new Student { StudentFirstName = "Debra", StudentLastName = "Manning", StudentMajor = "CSIS" },
                new Student { StudentFirstName = "Fadi", StudentLastName = "Hadari", StudentMajor = "ACCT" },
                new Student { StudentFirstName = "Hanyeng", StudentLastName = "Fen", StudentMajor = "MKTG" },
                new Student { StudentFirstName = "Hugo", StudentLastName = "Victor", StudentMajor = "FINC" },
                new Student { StudentFirstName = "Lance", StudentLastName = "Armstrong", StudentMajor = "MKTG" },
                new Student { StudentFirstName = "Terry", StudentLastName = "Matthews", StudentMajor = "CSIS" },
                new Student { StudentFirstName = "Eugene", StudentLastName = "Fei", StudentMajor = "FINC" },
                new Student { StudentFirstName = "Michael", StudentLastName = "Thorson", StudentMajor = "CSIS" },
                new Student { StudentFirstName = "Simon", StudentLastName = "Li", StudentMajor = "CSIS" },
            };

            // departments data

            List<Department> departments = new List<Department>()
            {
                new Department { DepartmentId = "CSIS", DepartmentName = "Computing Studies" },
                new Department { DepartmentId = "ACCT", DepartmentName = "Accounting" },
                new Department { DepartmentId = "MKTG", DepartmentName = "Marketing" },
                new Department { DepartmentId = "FINC", DepartmentName = "Finance" },
            };

            // courses data

            List<Course> courses = new List<Course>()
            {
                new Course { CourseId = 101, CourseDepartmentId = "CSIS", CourseName = "Programming I"},
                new Course { CourseId = 102, CourseDepartmentId = "CSIS", CourseName = "Programming II" },
                new Course { CourseId = 101, CourseDepartmentId = "ACCT", CourseName = "Accounting I" },
                new Course { CourseId = 102, CourseDepartmentId = "ACCT", CourseName = "Accounting II" },
                new Course { CourseId = 101, CourseDepartmentId = "FINC", CourseName = "Corporate Finance" },
            };

            // registration data - note consists of a registration object, and a student id.
            // if the students table is set up with a different autoincrement that starting at 1, this won't work

            //List<Registration> registrations = new List<Registration>()
            //{
            //    new Registration { RegisteredCourse = courses[0], StudentId = 1 },
            //    new Registration { RegisteredCourse = courses[0], StudentId = 2 },
            //    new Registration { RegisteredCourse = courses[1], StudentId = 1 },
            //    new Registration { RegisteredCourse = courses[4], StudentId = 1 },
            //};

            var context = new StudentRegistrationEntities();
            context.Database.Log = s => Debug.Write(s);
            context.SaveChanges();

            // first clear the list of students linked to courses

            foreach (Course c in context.Courses)
                c.Students.Clear();
            context.Students.RemoveRange(context.Students);
            context.SaveChanges();
            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Students', RESEED, 0)");

            Console.ReadLine();

            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            foreach (Student s in context.Students)
                Console.WriteLine(s);

            var query =
                from s in context.Students
                where s.StudentMajor == "ACCT"
                select s;

            Console.WriteLine($"Found {query.Count()} students in {query.First<Student>().StudentMajor}");
            foreach (Student s in query)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
