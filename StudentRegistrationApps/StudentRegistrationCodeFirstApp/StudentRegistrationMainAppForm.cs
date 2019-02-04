using System;
using System.Collections.Generic;
using System.ComponentModel; // for data annotations
using System.Data;
using System.Linq;
using System.Windows.Forms;
using StudentRegistrationCodeFirstApp.EF_Classes;
using System.Diagnostics;
using System.Data.Entity; // need this for ToBindingList() and 

namespace StudentRegistrationCodeFirstApp
{

    public partial class StudentRegistrationMainAppForm : Form
    {
        private StudentRegistrationEntities context; // save DB context here

        public StudentRegistrationMainAppForm()
        {
            InitializeComponent();
            context = new StudentRegistrationEntities();
        }
        // initialization method to zero out the database tabels,
        //   then seed Students, Courses, and Departments with initial data

        private void createRegistrationDataTables()
        {
            // set up database log to write to output window in VS

            context.Database.Log = (s => Debug.Write(s));
            context.SaveChanges();

            // zero out the db tables
            // load fully, clear, then save back

            context.Students.Load();
            context.Departments.Load();
            context.Courses.Load();
            context.Courses.Local.Clear();
            context.Departments.Local.Clear();
            context.Students.Local.Clear();
            context.SaveChanges();

            // finally, reseed students to 0

            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Students', RESEED, 0)");

            // seed student data into Students table

            List<Student> students = new List<Student>() {
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

            context.Students.AddRange(students);

            // seed departments data

            List<Department> departments = new List<Department>()  {
                new Department { DepartmentId = "CSIS", DepartmentName = "Computing Studies" },
                new Department { DepartmentId = "ACCT", DepartmentName = "Accounting" },
                new Department { DepartmentId = "MKTG", DepartmentName = "Marketing" },
                new Department { DepartmentId = "FINC", DepartmentName = "Finance" },
            };

            context.Departments.AddRange(departments);

            // seed courses data

            List<Course> courses = new List<Course>() {
                new Course { CourseId = 101, CourseName = "Programming I", Department = departments[0] },
                new Course { CourseId = 102, CourseName = "Programming II" , Department = departments[0]},
                new Course { CourseId = 101, CourseName = "Accounting I", Department = departments[1] },
                new Course { CourseId = 102, CourseName = "Accounting II", Department = departments[1] },
                new Course { CourseId = 101, CourseName = "Corporate Finance", Department = departments[3], },
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            // set up initial registration
            // note that we can add a student to a course or
            // add a course to a student, both will work and set up proper links

            courses[0].Students.Add(students[0]);
            courses[0].Students.Add(students[1]);
            courses[1].Students.Add(students[0]);
            courses[4].Students.Add(students[0]);

            students[2].Courses.Add(courses[2]);

            context.SaveChanges();

            // show the tables
            // don't show the foreign key objects

            dataGridViewStudents.DataSource = context.Students.Local.ToBindingList();
            dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudents.Columns["Courses"].Visible = false;

            dataGridViewCourses.DataSource = context.Courses.Local.ToBindingList();
            dataGridViewCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCourses.Columns["Department"].Visible = false;
            dataGridViewCourses.Columns["Students"].Visible = false;

            dataGridViewDepartments.DataSource = context.Departments.Local.ToBindingList();
            dataGridViewDepartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDepartments.Columns["Courses"].Visible = false;

            dataGridViewStudentRegistration.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // set up registration gridview

            updateRegistration();
            context.SaveChanges();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // need try/catch here

            context.SaveChanges();

            dataGridViewCourses.Refresh();
            dataGridViewStudents.Refresh();
            dataGridViewDepartments.Refresh();

            // need to update registration as well
            updateRegistration();
            context.SaveChanges();

        }

        // update the registration gridview

        private void updateRegistration()
        {
            // Notice no need to use a join in EF, as the parent-child link exists
            //  so we can just walk from parent to child (Student to Courses)
            // If we use an anonymous class, the gridview can't be sorted or edited by the user
            // So we use StudentCourseRegistration and set the fields from the Students and Courses tables

            var query =
                 (from student in context.Students
                 from studentreg in student.Courses
                 orderby student.StudentLastName
                 select new StudentCourseRegistration
                 {
                     StudentID = student.StudentId,
                     StudentLastName = student.StudentLastName,
                     CourseID = studentreg.CourseId,
                     Department = studentreg.Department.DepartmentId,
                     CourseName = studentreg.CourseName,
                 }).ToList();

            // set gridview datasource to the query result

            dataGridViewStudentRegistration.DataSource = query;
            dataGridViewStudentRegistration.Refresh();

            // doesn't work - tried to get gridview to allow for sorting, but needs a lot more code
            // the following allows for edit (which is allowed but doesn't and shouldn't work)
            //    but not sorting!

            // need context.Students.Load() and context.Students.Local as well I think
            //
            //BindingList<StudentCourseRegistration> cr = new BindingList<StudentCourseRegistration>(query.ToList());
            //dataGridViewStudentRegistration.DataSource = cr;
            //dataGridViewStudentRegistration.Columns[0].SortMode = DataGridViewColumnSortMode.Automatic;
            //dataGridViewStudentRegistration.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;

        }

        // Used to populate the registration gridview
        //   gridview columns are in order of the fields below.
        //   note use of annotation for DisplayName which sets the column header text
        private class StudentCourseRegistration
        {
            [DisplayName("Student ID")]
            public int StudentID { get; set; }
            [DisplayName("Last Name")]
            public string StudentLastName { get; set; }
            [DisplayName("Course ID")]
            public int CourseID { get; set; }
            [DisplayName("Course Name")]
            public string CourseName { get; set; }
            [DisplayName("Department")]
            public string Department { get; set; }

        }

        // Register students, and update the registration gridview 
        // user selectes rows in Students and Courses gridviews
        // the we register all
        // todo: no check to see if a student is already registered

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // make sure rows have been selected in each gridview

            if (dataGridViewStudents.SelectedRows.Count == 0 ||
                dataGridViewCourses.SelectedRows.Count == 0)
                return;

            // get the selected students and keep in a list
            //  match selected StudentId

            List<Student> studentsToRegister = new List<Student>();
            foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
                studentsToRegister.Add(context.Students.Find(row.Cells[0].Value));

            // same for courses, match against CourseId

            List<Course> coursesToRegister = new List<Course>();
            foreach (DataGridViewRow row in dataGridViewCourses.SelectedRows)
                coursesToRegister.Add(context.Courses.Find(row.Cells[0].Value, row.Cells[1].Value));

            // The nice thing about EF is that you could add to Course.Students or Student.Courses
            //   will do the former

            foreach (Course c in coursesToRegister)
                foreach (Student s in studentsToRegister)
                    c.Students.Add(s);

            // update database and registration gridview

            context.SaveChanges();
            updateRegistration();
        }

        private void StudentRegistrationMainAppForm_Load(object sender, EventArgs e)
        {
            createRegistrationDataTables();
        }
    }
}
