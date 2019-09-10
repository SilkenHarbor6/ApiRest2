namespace ApiRest2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cita")]
    public partial class Cita
    {
        [Key]
        public int id_Cita { get; set; }

        public DateTime? FechaCita { get; set; }

        public int? id_Paciente { get; set; }

        public int? id_Doctor { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Paciente Paciente { get; set; }
    }
}
