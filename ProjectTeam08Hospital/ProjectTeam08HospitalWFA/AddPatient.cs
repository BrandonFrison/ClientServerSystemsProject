using ProjectTeam08HospitalWFA.EF_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam08HospitalWFA
{
    public partial class AddPatient : Form
    {
        public Patient patient { get; set; }
       

        public AddPatient()
        {
            InitializeComponent();
        }

        private void buttonInsertPatientRecord_Click(object sender, EventArgs e)
        {
            if (textBoxPatientCareId.Text.Trim().Length == 0
                || textBoxPatientDateOfBirth.Text.Trim().Length == 0
                || textBoxPatientFirstName.Text.Trim().Length == 0
                || textBoxPatientLastName.Text.Trim().Length == 0
                || textBoxPatientRoomNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("Patient Information is missing re enter the data");
            }
            else
            {
                
                Admin adm = new Admin();
                patient = new Patient();
                patient.PatientID = adm.getPatientID();
                patient.DateOfBirth = textBoxPatientDateOfBirth.Text;
                patient.MedicalCardID = int.Parse(textBoxPatientCareId.Text);
                patient.RoomNumberID = int.Parse(textBoxPatientRoomNumber.Text);
                patient.FirstName = textBoxPatientFirstName.Text;
                patient.LastName = textBoxPatientLastName.Text;
                patient.Gender = textBoxPatientGender.Text;
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
