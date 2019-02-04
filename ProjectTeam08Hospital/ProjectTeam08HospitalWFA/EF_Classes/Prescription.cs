namespace ProjectTeam08HospitalWFA.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Prescription
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PrescriptionID { get; set; }

        public int DoctorID { get; set; }

        public int PatientID { get; set; }

        public int MedicineID { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Medicine Medicine { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
