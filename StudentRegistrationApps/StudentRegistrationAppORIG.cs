using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentRegistrationFormsApp.EF_Classes;
using System.Diagnostics;


namespace StudentRegistrationFormsApp
{
    public partial class FormStudentRegistration : Form
    {
        private StudentRegistrationEntities context;
        public FormStudentRegistration()
        {
            InitializeComponent();
            context = new StudentRegistrationEntities();

        }
        private void createRegistrationDataTables()
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

            List<EF_Classes.Course> courses = new List<EF_Classes.Course>()
            {
                new EF_Classes.Course { CourseId = 101, CourseDepartmentId = "CSIS", CourseName = "Programming I"},
                new EF_Classes.Course { CourseId = 102, CourseDepartmentId = "CSIS", CourseName = "Programming II" },
                new EF_Classes.Course { CourseId = 101, CourseDepartmentId = "ACCT", CourseName = "Accounting I" },
                new EF_Classes.Course { CourseId = 102, CourseDepartmentId = "ACCT", CourseName = "Accounting II" },
                new EF_Classes.Course { CourseId = 101, CourseDepartmentId = "FINC", CourseName = "Corporate Finance" },
            };

            // registration data - note consists of a registration object, and a student id.
            // if the students table is set up with a different autoincrement that starting at 1, this won't work

            //List<Registration> registrations = new List<Registration>()
            //{
            //    new Registration { RegisteredCourse = courses[0], StudentId = 1 },
            //    new Registration { RegisteredCourse = courses[0], StudentId = 2 },
            //    new Registration { RegisteredCourse = courses[1], StudentId = 1 },
            //    new Registration { RegisteredCourse = courses[4], StudentId = 1 },
            //}


            context.Database.Log = s => Debug.Write(s);
            context.SaveChanges();
            context.Students.RemoveRange(context.Students);
            context.SaveChanges();
            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Students', RESEED, 0)");


            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            dataGridViewStudents.DataSource = context.Students.ToList();
            //dataGridViewStudents.Refresh();
            //foreach (Student s in context.Students)
            //    Console.WriteLine(s);

            //var query =
            //    from s in context.Students
            //    where s.StudentMajor == "ACCT"
            //    select s;

            //Console.WriteLine($"Found {query.Count()} students in {query.First<Student>().StudentMajor}");
            //foreach (Student s in query)
            //    Console.WriteLine(s);
            //Console.ReadLine();

        }

        private void FormStudentRegistration_Load(object sender, EventArgs e)
        {
            dataGridViewStudents.DataSource = context.Students.ToList(); 
        }
    }
}
