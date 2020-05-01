namespace Data.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Physical
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AbilityID { get; set; }

        [Required]
        [StringLength(50)]
        public string ToolRequired { get; set; }

        [Required]
        [StringLength(50)]
        public string RaceOfOrigin { get; set; }

        public int TrainingLocationID { get; set; }

        public bool Fighting { get; set; }

        public bool Lethal { get; set; }

        public bool RequiresWeaponMastery { get; set; }

        public virtual Location Location { get; set; }
    }
}
