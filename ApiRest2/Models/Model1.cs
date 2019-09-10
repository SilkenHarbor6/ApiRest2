namespace ApiRest2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Cita> Cita { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Paciente> Paciente { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>()
                .Property(e => e.NombreCompleto)
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.Especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Telefono)
                .IsUnicode(false);
        }
    }
}
