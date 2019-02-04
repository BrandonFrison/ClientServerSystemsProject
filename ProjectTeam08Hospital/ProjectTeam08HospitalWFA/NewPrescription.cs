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
    public partial class NewPrescription : Form
    {
        public Prescription prescription { get; set; }


        public NewPrescription()
        {
            InitializeComponent();
        }

        private void buttonInsertNewPrescription_Click(object sender, EventArgs e)
        {
            if (textBoxDoctorID.Text.Trim().Length == 0
               || textBoxMedicineID.Text.Trim().Length == 0
               || textBoxPatientID.Text.Trim().Length == 0)
            { 
                MessageBox.Show("Patient Information is missing re enter the data");
            }
            else
            {
                Admin adm = new Admin();
                prescription = new Prescription();
                prescription.PrescriptionID = adm.getPrescriptionID();
                prescription.DoctorID = int.Parse(textBoxDoctorID.Text);
                prescription.MedicineID = int.Parse(textBoxMedicineID.Text);
                prescription.PatientID = int.Parse(textBoxPatientID.Text);

                adm.buttonFilterPrescriptions_Click(this, e); // so it updates the prescription right away
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
