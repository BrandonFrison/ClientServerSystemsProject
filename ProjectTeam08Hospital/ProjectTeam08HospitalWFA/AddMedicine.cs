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
    public partial class AddMedicine : Form
    {

        public Medicine medicine { get; set; }
        public AddMedicine()
        {
            InitializeComponent();
        }

        private void buttonInsertMedicine_Click(object sender, EventArgs e)
        {
            if (textBoxMedicineName.Text.Trim().Length == 0 || textBoxAmountInStock.Text.Trim().Length == 0)
            {
                MessageBox.Show("Medicine Information is missing re enter the data");
            }
            else
            {
                Admin adm = new Admin();
                medicine = new Medicine();
                medicine.MedicineID = adm.getMedicineID();
                medicine.MedicineName = textBoxMedicineName.Text;
                medicine.AmountInStock = int.Parse(textBoxAmountInStock.Text);
                this.DialogResult = DialogResult.OK;
                Close();
            }

            


            
        }
    }
}
