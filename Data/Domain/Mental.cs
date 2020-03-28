namespace Data.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mental
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AbilityID { get; set; }

        [Required]
        [StringLength(50)]
        public string RaceOfOrigin { get; set; }

        [Required]
        [StringLength(50)]
        public string Subject { get; set; }

        public int SchoolLocationID { get; set; }

        public bool RequiresSubjectMastery { get; set; }

        public virtual Ability Ability { get; set; }

        public virtual Location Location { get; set; }
    }
}
