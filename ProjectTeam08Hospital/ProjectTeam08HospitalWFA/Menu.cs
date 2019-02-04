using ProjectTeam08HospitalWFA.EF_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam08HospitalWFA
{

  
    public partial class Menu : Form
    {

        private HospitalEntities context;



        public Menu()
        {
            InitializeComponent();
            context = new HospitalEntities();
            //checks if database is seeded and hides button for it.
            if (context.Prescriptions.Count() > 0)
            {
                buttonLoadDatabase.Hide();
            }


         

        }

        private void buttonSignInAsUser_Click(object sender, EventArgs e)
        {
           //all users can use this function as it is read only.
            var userForm = new User();
            userForm.Show();
            this.Hide();

        }

        private void buttonSignInAsAdmin_Click(object sender, EventArgs e)
        {
           
            if (textBoxUserNameInput.Text.Equals("admin") && textBoxPasswordInput.Text.Equals("password123"))
            {

                var adminForm = new Admin();
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Password or Username try again");
            }  
        }

        private void buttonLoadDatabase_Click(object sender, EventArgs e)
        {
            buttonLoadDatabase.Hide();
            context = new HospitalEntities();

            context.Database.Log = s => Debug.Write(s);
            context.SaveChanges();

            //initial loading and clearing of context.
            context.Doctors.Load();
            context.Medicines.Load();
            context.Patients.Load();
            context.Rooms.Load();
            context.Prescriptions.Load();
            context.Doctors.Local.Clear();
            context.Medicines.Local.Clear();
            context.Patients.Local.Clear();
            context.Rooms.Local.Clear();
            context.Prescriptions.Local.Clear();
            context.SaveChanges();



            //database seeding


            List<Room> rooms = new List<Room>()
            {
                new Room { RoomID = 1234 , Ward = "Offices", Description = "Dr. Gordon's Office" },
                new Room { RoomID = 4321, Ward = "Offices", Description = "Dr. Jefferson's Office"},
                new Room { RoomID = 2869, Ward = "Offices", Description = "Dr. Johnson's Office"},
                new Room { RoomID = 3403, Ward = "Offices", Description = "Dr. McKnight's Office"},
                new Room { RoomID = 5128, Ward = "Offices", Description = "Dr. Cannon's Office"},
                new Room { RoomID = 6109, Ward = "Offices", Description = "Dr. Evans' Office"},
                new Room { RoomID = 4234, Ward = "Offices", Description = "Dr. McGlade's Office"},
                new Room { RoomID = 3123, Ward = "Offices", Description = "Dr. Hess' Office"},
                new Room { RoomID = 5239, Ward = "Offices", Description = "Dr. Simmons' Office"},
                new Room { RoomID = 2858, Ward = "Offices", Description = "Dr. Brooks' Office"},
                new Room { RoomID = 3484, Ward = "Offices", Description = "Dr. Kyle's Office"},
                new Room { RoomID = 4504, Ward = "Offices", Description = "Dr. Jones' Office"},
                new Room { RoomID = 1568, Ward = "Psych", Description = "Waiting Room"},
                new Room { RoomID = 1688, Ward = "Psych", Description = "Surgery Room"},
                new Room { RoomID = 1345, Ward = "Psych", Description = "Office Room"},
                new Room { RoomID = 1456, Ward = "Psych", Description = "Patient Room"},
                new Room { RoomID = 1798, Ward = "Psych", Description = "Patient Room"},
                new Room { RoomID = 1923, Ward = "Psych", Description = null},
                new Room { RoomID = 2856, Ward = "Pediatrics", Description = "Waiting Room"},
                new Room { RoomID = 2245, Ward = "Pediatrics", Description = "Surgery Room"},
                new Room { RoomID = 2785, Ward = "Pediatrics", Description = "Office Room"},
                new Room { RoomID = 2945, Ward = "Pediatrics", Description = "Patient Room"},
                new Room { RoomID = 2356, Ward = "Pediatrics", Description = "Patient Room"},
                new Room { RoomID = 2255, Ward = "Pediatrics",  Description = null},
                new Room { RoomID = 3345, Ward = "Maternity", Description = "Waiting Room"},
                new Room { RoomID = 3685, Ward = "Maternity", Description = "Surgery Room"},
                new Room { RoomID = 3967, Ward = "Maternity", Description = "Office Room"},
                new Room { RoomID = 3346, Ward = "Maternity", Description = "Patient Room"},
                new Room { RoomID = 3765, Ward = "Maternity", Description = "Patient Room"},
                new Room { RoomID = 3568, Ward = "Maternity", Description = null},
                new Room { RoomID = 4237, Ward = "Geriatrics", Description = "Waiting Room"},
                new Room { RoomID = 4478, Ward = "Geriatrics", Description = "Surgery Room"},
                new Room { RoomID = 4576, Ward = "Geriatrics", Description = "Office Room"},
                new Room { RoomID = 4397, Ward = "Geriatrics", Description = "Patient Room"},
                new Room { RoomID = 4870, Ward = "Geriatrics", Description = "Patient Room"},
                new Room { RoomID = 4023, Ward = "Geriatrics", Description = null},


            };

            context.Rooms.AddRange(rooms);
            context.SaveChanges();


            List<Doctor> doctors = new List<Doctor>()
           {
                new Doctor { DoctorID = 0 , Room = rooms[0], FirstName = "Greg", LastName = "Gordon" },
                new Doctor { DoctorID = 1 , Room = rooms[1], FirstName = "Jeremy", LastName = "Jefferson"},
                new Doctor { DoctorID = 2 , Room = rooms[2], FirstName = "Emily", LastName = "Johnson"},
                new Doctor { DoctorID = 3 , Room = rooms[3], FirstName = "Fred", LastName = "McKnight"},
                new Doctor { DoctorID = 4 , Room = rooms[4], FirstName = "Roy", LastName = "Cannon"},
                new Doctor { DoctorID = 5 , Room = rooms[5], FirstName = "Edward", LastName = "Evans"},
                new Doctor { DoctorID = 6 , Room = rooms[6], FirstName = "Janice", LastName = "McGlade"},
                new Doctor { DoctorID = 7 , Room = rooms[7], FirstName = "Patricia", LastName = "Hess"},
                new Doctor { DoctorID = 8 , Room = rooms[8], FirstName = "James", LastName = "Simmons"},
                new Doctor { DoctorID = 9 , Room = rooms[9], FirstName = "David", LastName = "Brooks"},
                new Doctor { DoctorID = 10 , Room = rooms[10], FirstName = "Chris", LastName = "Kyle"},
                new Doctor { DoctorID = 11 , Room = rooms[11], FirstName = "Janet", LastName = "Jones"},

           };

            context.Doctors.AddRange(doctors);
            context.SaveChanges();


            List<Patient> patients = new List<Patient>()
            {
                new Patient {  PatientID = 0  ,  Room = rooms[0], MedicalCardID = 12345, DateOfBirth = "2002-02-12", FirstName = "Jeff", LastName = "Jones", Gender = "Male" },
                new Patient {  PatientID = 1  ,  Room = rooms[1], MedicalCardID = 34343, DateOfBirth = "2001-03-21", FirstName = "Ramsay", LastName = "Bolton", Gender = "Male"},
                new Patient {  PatientID = 2  ,  Room = rooms[13], MedicalCardID = 59345, DateOfBirth = "1997-12-14", FirstName = "Marjorie", LastName = "Dennis", Gender = "Female"},
                new Patient {  PatientID = 3  ,  Room = rooms[20], MedicalCardID = 76876, DateOfBirth = "1960-04-19", FirstName = "Barbara", LastName = "Holloway", Gender = "Female"},
                new Patient {  PatientID = 4  ,  Room = rooms[15], MedicalCardID = 34895, DateOfBirth = "1965-08-22", FirstName = "Ramona", LastName = "Critchfield", Gender = "Female"},
                new Patient {  PatientID = 5  ,  Room = rooms[18], MedicalCardID = 23462, DateOfBirth = "1974-06-13", FirstName = "Kristina", LastName = "Phillips", Gender = "Female"},
                new Patient {  PatientID = 6  ,  Room = rooms[14], MedicalCardID = 76906, DateOfBirth = "1987-10-07", FirstName = "Robert", LastName = "Nunn", Gender = "Male"},
                new Patient {  PatientID = 7  ,  Room = rooms[16], MedicalCardID = 92394, DateOfBirth = "1992-12-05", FirstName = "Flora", LastName = "Winchester", Gender = "Female"},
                new Patient {  PatientID = 8  ,  Room = rooms[21], MedicalCardID = 22342, DateOfBirth = "1996-07-03", FirstName = "Carrie", LastName = "Jones", Gender = "Female"},
                new Patient {  PatientID = 9  ,  Room = rooms[17], MedicalCardID = 23464, DateOfBirth = "2005-05-20", FirstName = "Curtis", LastName = "Leatherman", Gender = "Male"},
                new Patient {  PatientID = 10  ,  Room = rooms[19], MedicalCardID = 34532, DateOfBirth = "1940-09-14", FirstName = "Jim", LastName = "Quinn", Gender = "Male"},
                new Patient {  PatientID = 11  ,  Room = rooms[20], MedicalCardID = 84386, DateOfBirth = "1935-07-09", FirstName = "Casey", LastName = "Taylor", Gender = "Male"},
                new Patient {  PatientID = 12  , Room = rooms[18], MedicalCardID = 54689, DateOfBirth = "1967-02-29", FirstName = "Roger", LastName = "Deboer", Gender = "Male"},
                new Patient {   PatientID = 13 , Room = rooms[5], MedicalCardID = 12389, DateOfBirth = "1923-05-25", FirstName = "Floyd", LastName = "Harris", Gender = "Male"},
                new Patient {  PatientID = 14 , Room = rooms[8], MedicalCardID = 45334, DateOfBirth = "1990-06-27", FirstName = "Francine", LastName = "Nelson", Gender = "Female"},
            };
            context.Patients.AddRange(patients);

            context.SaveChanges();


            List<Medicine> medicines = new List<Medicine>()
            {
                new Medicine { MedicineID = 0, MedicineName = "Insulin", AmountInStock = 324 },
                new Medicine { MedicineID = 1, MedicineName = "Morphine", AmountInStock = 120 },
                new Medicine { MedicineID = 2, MedicineName = "Adderall", AmountInStock = 287  },
                new Medicine { MedicineID = 3, MedicineName = "Baclofen", AmountInStock = 675  },
                new Medicine { MedicineID = 4, MedicineName = "Clonidine", AmountInStock = 556  },
                new Medicine { MedicineID = 5, MedicineName = "Diphenhydramine", AmountInStock = 307  },
                new Medicine { MedicineID = 6, MedicineName = "Erythromycin", AmountInStock = 456  },
                new Medicine { MedicineID = 7, MedicineName = "Furosemide", AmountInStock = 1433  },
                new Medicine { MedicineID = 8, MedicineName = "Gemfibrozil", AmountInStock = 547  },
                new Medicine { MedicineID = 9, MedicineName = "Hydrocodone", AmountInStock = 789  },
                new Medicine { MedicineID = 10, MedicineName = "Ibuprofen", AmountInStock = 79  },
                new Medicine { MedicineID = 11, MedicineName = "Kombiglyze XR", AmountInStock = 457  },
                new Medicine { MedicineID = 12, MedicineName = "Lidoderm", AmountInStock = 845  },
                new Medicine { MedicineID = 13, MedicineName = "Melatonin", AmountInStock = 2883  },
                new Medicine { MedicineID = 14, MedicineName = "NovoLog", AmountInStock = 456  },
                new Medicine { MedicineID = 15, MedicineName = "Oxycodone", AmountInStock = 893  },
                new Medicine { MedicineID = 16, MedicineName = "Restasis", AmountInStock = 8694  },
            };
            context.Medicines.AddRange(medicines);
            context.SaveChanges();

            List<Prescription> prescriptions = new List<Prescription>()
            {
                new Prescription { PrescriptionID = 0 , Doctor = doctors[1], Patient = patients[0], Medicine = medicines[1] },
                new Prescription { PrescriptionID = 1 , Doctor = doctors[0], Patient = patients[1], Medicine = medicines[0] },
                new Prescription { PrescriptionID = 2 , Doctor = doctors[0], Patient = patients[0], Medicine = medicines[0] },
                new Prescription { PrescriptionID = 3 , Doctor = doctors[1], Patient = patients[1], Medicine = medicines[12] },
                new Prescription { PrescriptionID = 4 , Doctor = doctors[2], Patient = patients[14], Medicine = medicines[16] },
                new Prescription { PrescriptionID = 6 , Doctor = doctors[3], Patient = patients[13], Medicine = medicines[11] },
                new Prescription { PrescriptionID = 7 , Doctor = doctors[4], Patient = patients[12], Medicine = medicines[12] },
                new Prescription { PrescriptionID = 8 , Doctor = doctors[5], Patient = patients[12], Medicine = medicines[13] },
                new Prescription { PrescriptionID = 9 , Doctor = doctors[6], Patient = patients[7], Medicine = medicines[14] },
                new Prescription { PrescriptionID = 10 , Doctor = doctors[7], Patient = patients[8], Medicine = medicines[2] },
                new Prescription { PrescriptionID = 11 , Doctor = doctors[8], Patient = patients[9], Medicine = medicines[3] },
                new Prescription { PrescriptionID = 12 , Doctor = doctors[9], Patient = patients[10], Medicine = medicines[4] },
                new Prescription { PrescriptionID = 13 , Doctor = doctors[10], Patient = patients[11], Medicine = medicines[5] },
                new Prescription { PrescriptionID = 14 , Doctor = doctors[11], Patient = patients[11], Medicine = medicines[6]},
                new Prescription { PrescriptionID = 15 , Doctor = doctors[11], Patient = patients[13], Medicine = medicines[7] },
                new Prescription { PrescriptionID = 16 , Doctor = doctors[10], Patient = patients[13], Medicine = medicines[8] },
                new Prescription { PrescriptionID = 17 , Doctor = doctors[9], Patient = patients[2], Medicine = medicines[9] },
                new Prescription { PrescriptionID = 18 , Doctor = doctors[8], Patient = patients[3], Medicine = medicines[10] },
                new Prescription { PrescriptionID = 19 ,Doctor = doctors[7], Patient = patients[4], Medicine = medicines[11] },
                new Prescription { PrescriptionID = 20 , Doctor = doctors[6], Patient = patients[5], Medicine = medicines[12] },
                new Prescription { PrescriptionID = 21 , Doctor = doctors[5], Patient = patients[6], Medicine = medicines[13] },
                new Prescription { PrescriptionID = 22 , Doctor = doctors[4], Patient = patients[7], Medicine = medicines[14] },
                new Prescription { PrescriptionID = 23 , Doctor = doctors[3], Patient = patients[3], Medicine = medicines[15]},
                new Prescription { PrescriptionID = 24 , Doctor = doctors[2], Patient = patients[3], Medicine = medicines[16] },
                new Prescription { PrescriptionID = 25 , Doctor = doctors[1], Patient = patients[2], Medicine = medicines[16] },
                new Prescription { PrescriptionID = 26 , Doctor = doctors[0], Patient = patients[11], Medicine = medicines[12]},
                new Prescription { PrescriptionID = 27 , Doctor = doctors[1], Patient = patients[11], Medicine = medicines[9] },
                new Prescription { PrescriptionID = 28 , Doctor = doctors[2], Patient = patients[11], Medicine = medicines[11] },
                new Prescription { PrescriptionID = 29 , Doctor = doctors[3], Patient = patients[2], Medicine = medicines[10] },
                new Prescription { PrescriptionID = 30 , Doctor = doctors[4], Patient = patients[0], Medicine = medicines[4] },
                new Prescription { PrescriptionID = 31 , Doctor = doctors[5], Patient = patients[0], Medicine = medicines[5] },
                new Prescription { PrescriptionID = 32 , Doctor = doctors[5], Patient = patients[11], Medicine = medicines[8] },
                new Prescription { PrescriptionID = 33 , Doctor = doctors[5], Patient = patients[14], Medicine = medicines[4] },
                new Prescription { PrescriptionID = 34 , Doctor = doctors[6], Patient = patients[12], Medicine = medicines[2] },
                new Prescription { PrescriptionID = 35 , Doctor = doctors[6], Patient = patients[14], Medicine = medicines[3] },
                new Prescription { PrescriptionID = 36 , Doctor = doctors[7], Patient = patients[13], Medicine = medicines[7] },
                new Prescription { PrescriptionID = 37 , Doctor = doctors[9], Patient = patients[6], Medicine = medicines[9] },
                new Prescription { PrescriptionID = 38 , Doctor = doctors[11], Patient = patients[8], Medicine = medicines[14] },


            };
            context.Prescriptions.AddRange(prescriptions);
            context.SaveChanges();
        }
    }
}
