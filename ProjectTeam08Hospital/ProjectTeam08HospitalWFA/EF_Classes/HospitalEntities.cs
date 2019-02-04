namespace ProjectTeam08HospitalWFA.EF_Classes
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HospitalEntities : DbContext
    {
        public HospitalEntities()
            : base("name=HospitalConnection")
        {
        }

        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Prescription> Prescriptions { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Prescriptions)
                .WithRequired(e => e.Doctor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Medicine>()
                .HasMany(e => e.Prescriptions)
                .WithRequired(e => e.Medicine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.DateOfBirth)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Prescriptions)
                .WithRequired(e => e.Patient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Doctors)
                .WithRequired(e => e.Room)
                .HasForeignKey(e => e.OfficeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Patients)
                .WithRequired(e => e.Room)
                .HasForeignKey(e => e.RoomNumberID)
                .WillCascadeOnDelete(false);
        }
    }
}
