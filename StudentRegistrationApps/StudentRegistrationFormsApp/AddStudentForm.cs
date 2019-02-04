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

namespace StudentRegistrationFormsApp
{
    // form to collect student information
    //  info is saved in the student field, which is read by the parent

    public partial class AddStudentForm : Form
    {
        public Student student { get; set; }

        public AddStudentForm()
        {
            InitializeComponent();
        }

        // add button is clicked
        //   if any of the textboxes are empty, give an error message
        //   otherwise store the data in the object, signal OK and close

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text.Trim().Length == 0 ||
                textBoxLastName.Text.Trim().Length == 0 ||
                textBoxMajor.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student information is missing.");
            }
            else
            {
                student = new Student();
                student.StudentFirstName = textBoxFirstName.Text;
                student.StudentLastName = textBoxLastName.Text;
                student.StudentMajor = textBoxMajor.Text;
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
