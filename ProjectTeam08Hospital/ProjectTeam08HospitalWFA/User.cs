using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using ProjectTeam08HospitalWFA.EF_Classes;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace ProjectTeam08HospitalWFA
{
    public partial class User : Form
    {

        private HospitalEntities context;
        public User()
        {
            InitializeComponent();

            context = new HospitalEntities();
        

            context.Doctors.Load();
            context.Medicines.Load();
            context.Patients.Load();
            context.Rooms.Load();
            context.Prescriptions.Load();
        }

        private void buttonUserExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void buttonFillGridViews_Click(object sender, EventArgs e)
        {
            createUserTables();
        }

        private void createUserTables()
        {
            
            if (textBoxPatientIdInput.Text.Equals(""))
            {
                MessageBox.Show("please enter your patient id in the textbox");
            }
            else
            {

                int pID = int.Parse(textBoxPatientIdInput.Text);

                var query =
                        from rows in context.Prescriptions
                        where rows.PatientID == pID
                        select rows;
                dataGridViewPrescriptions.DataSource = query.ToList();
                dataGridViewPrescriptions.Columns["Doctor"].Visible = false;
                dataGridViewPrescriptions.Columns["Medicine"].Visible = false;
                dataGridViewPrescriptions.Columns["Patient"].Visible = false;
                dataGridViewPrescriptions.Columns["PatientID"].Visible = false;

                //queries original query and returns doctor entities associated with it
                var query2 =
                    from rows in query
                    select rows.Doctor;

                var q = query2.Distinct(); //deletes duplicate records of the same doctor

                dataGridViewDoctors.DataSource = q.ToList();

                dataGridViewDoctors.Columns["Prescriptions"].Visible = false;
                dataGridViewDoctors.Columns["Room"].Visible = false;


                //queries original query and returns medicine associated with prescriptions.
                var query3 =
                    from rows in query.Distinct()
                    select rows.Medicine;

                var q2 = query3.Distinct();

                dataGridViewMedicineList.DataSource = q2.ToList();
                dataGridViewMedicineList.Columns["Prescriptions"].Visible = false;
                dataGridViewMedicineList.Columns["AmountInStock"].Visible = false;

            }
           

            


        }
    }
}
