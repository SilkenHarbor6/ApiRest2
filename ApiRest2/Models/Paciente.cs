namespace ApiRest2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Paciente")]
    public partial class Paciente
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Paciente()
        //{
        //    Cita = new HashSet<Cita>();
        //}

        [Key]
        public int id_Paciente { get; set; }

        [StringLength(50)]
        public string Nombres { get; set; }

        [StringLength(50)]
        public string Apellidos { get; set; }

        public int? Edad { get; set; }

        [StringLength(12)]
        public string Telefono { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Cita> Cita { get; set; }
    }
}
