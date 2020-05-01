namespace Data.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ability
    {
        public int AbilityID { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(2400)]
        public string Description { get; set; }

        public int DifficultyLevel { get; set; }

        public bool Exhausting { get; set; }

        [Required]
        [StringLength(50)]
        public string abilityType { get; set; }

        public virtual Magical Magical { get; set; }

        public virtual Mental Mental { get; set; }
    }
}
