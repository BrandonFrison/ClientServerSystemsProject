using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ProjectTeam08HospitalWFA.EF_Classes;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;

namespace ProjectTeam08HospitalWFA
{
    public partial class Admin : Form
    {
        private HospitalEntities context;


        public Admin()
        {
            InitializeComponent();

            context = new HospitalEntities();
            context.Doctors.Load();
            context.Medicines.Load();
            context.Patients.Load();
            context.Rooms.Load();
            context.Prescriptions.Load();
            createHospitalDataTables();

            

        }

        
   
        private void createHospitalDataTables()
        {
            //for output window, probably remove in final code.
            
       
            dataGridViewPrescriptions.DataSource = context.Prescriptions.Local.ToBindingList();
            dataGridViewPrescriptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPrescriptions.Columns["Doctor"].Visible = false;
            dataGridViewPrescriptions.Columns["Medicine"].Visible = false;
            dataGridViewPrescriptions.Columns["Patient"].Visible = false;


            dataGridViewPatients.DataSource = context.Patients.Local.ToBindingList();
            dataGridViewPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPatients.Columns["Prescriptions"].Visible = false;
            dataGridViewPatients.Columns["Room"].Visible = false;

            dataGridViewMedicine.DataSource = context.Medicines.Local.ToBindingList();
            dataGridViewMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMedicine.Columns["Prescriptions"].Visible = false;




        
            context.SaveChanges();
        }


        private void buttonAddNewPatient_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            AddPatient patientForm = new AddPatient();
            
            var result = patientForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                
                context.Patients.Add(patientForm.patient);
                context.SaveChanges();
            }
        }

        private void buttonAddNewMedicine_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            AddMedicine medicineForm = new AddMedicine();


            var result = medicineForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                context.Medicines.Add(medicineForm.medicine);
                context.SaveChanges();
            }
        }

        private void buttonAdminExit_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            Environment.Exit(1);
        }

       
     /*   private void Admin_Load(object sender, EventArgs e)
        {
            createHospitalDataTables();

        }  */

        private void buttonAddNewPrescription_Click(object sender, EventArgs e)
        {
            NewPrescription prescriptionForm = new NewPrescription();


            var result = prescriptionForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                context.Prescriptions.Add(prescriptionForm.prescription);
                context.SaveChanges();
                dataGridViewPrescriptions.Refresh();
            }
            
        }

        public int getPatientID()
        {
            return dataGridViewPatients.Rows.Count - 1; 
        }

        public int getPrescriptionID()
        {
            return dataGridViewPrescriptions.Rows.Count;
        }

        public int getMedicineID()
        {
            return dataGridViewMedicine.Rows.Count - 1;
        }



        public void buttonFilterPrescriptions_Click(object sender, EventArgs e)
        {

            
            int dID = 0;
            int pID = 0;
            int mID = 0;

            // changing text boxes to variables
            if (!textBoxFilterDocID.Text.Equals(""))
            {
                dID = int.Parse(textBoxFilterDocID.Text);
            }

            if (!textBoxFilterMedID.Text.Equals(""))
            {
                mID = int.Parse(textBoxFilterMedID.Text);
            }

            if (!textBoxFilterPatientID.Text.Equals(""))
            {
                pID = int.Parse(textBoxFilterPatientID.Text);
            }

            if (textBoxFilterDocID.Text.Equals("") && textBoxFilterMedID.Text.Equals("") && textBoxFilterPatientID.Text.Equals(""))
            {
                var query =
                    from rows in context.Prescriptions
                    select rows;

                dataGridViewPrescriptions.DataSource = query.ToList();
            }

                //different queries for what is typed in. first checking for no boxes filled then all boxes filled then single box only typed in to avoid multiple ifs working.
             else if (!textBoxFilterDocID.Text.Equals("") && !textBoxFilterMedID.Text.Equals("") && !textBoxFilterPatientID.Text.Equals(""))
            {
                var query =
                from rows in context.Prescriptions
                where rows.PatientID == pID &&
                      rows.DoctorID == dID &&
                      rows.MedicineID == mID
                select rows;

                dataGridViewPrescriptions.DataSource = query.ToList();
            }
            else if (textBoxFilterDocID.Text.Equals("") && textBoxFilterMedID.Text.Equals(""))
            {
                var query =
                from rows in context.Prescriptions
                where rows.PatientID == pID
                select rows;

                dataGridViewPrescriptions.DataSource = query.ToList();
            }
            else if (textBoxFilterDocID.Text.Equals("") && textBoxFilterPatientID.Text.Equals(""))
            {
                var query =
                from rows in context.Prescriptions
                where rows.MedicineID == mID
                select rows;

                dataGridViewPrescriptions.DataSource = query.ToList();
            }
            else if (textBoxFilterMedID.Text.Equals("") && textBoxFilterPatientID.Text.Equals(""))
            {
                var query =
                from rows in context.Prescriptions
                where rows.DoctorID == dID
                select rows;

                dataGridViewPrescriptions.DataSource = query.ToList();
            }
            else if (textBoxFilterDocID.Text.Equals(""))
            {
                var query =
                from rows in context.Prescriptions
                where rows.PatientID == pID &&
                      rows.MedicineID == mID
                select rows;

                dataGridViewPrescriptions.DataSource = query.ToList();
            }
            else if (textBoxFilterMedID.Text.Equals(""))
            {
                var query =
                from rows in context.Prescriptions
                where rows.PatientID == pID &&
                      rows.DoctorID == dID
                select rows;

                dataGridViewPrescriptions.DataSource = query.ToList();
            }
            else if (textBoxFilterPatientID.Text.Equals(""))
            {
                var query =
                from rows in context.Prescriptions
                where rows.DoctorID == dID &&
                      rows.MedicineID == mID
                select rows;

                dataGridViewPrescriptions.DataSource = query.ToList();
            }

            dataGridViewPrescriptions.Refresh();
        }

        private void buttonSwitchToUserView_Click(object sender, EventArgs e)
        {
            var userForm = new User();
            userForm.Show();
            this.Hide();
        }
    }
}
