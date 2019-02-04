namespace ProjectTeam08HospitalWFA.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Medicine")]
    public partial class Medicine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medicine()
        {
            Prescriptions = new HashSet<Prescription>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MedicineID { get; set; }

        [Required]
        [StringLength(50)]
        public string MedicineName { get; set; }

        public int AmountInStock { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}
