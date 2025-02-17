namespace ApiRest2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doctor")]
    public partial class Doctor
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Doctor()
        //{
        //    Cita = new HashSet<Cita>();
        //}

        [Key]
        public int id_Doctor { get; set; }

        [StringLength(100)]
        public string NombreCompleto { get; set; }

        [StringLength(25)]
        public string Especialidad { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Cita> Cita { get; set; }
    }
}
