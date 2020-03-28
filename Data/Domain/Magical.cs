namespace Data.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Magical
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AbilityID { get; set; }

        public int ArchiveLocationID { get; set; }

        public bool LightMagic { get; set; }

        [Required]
        [StringLength(50)]
        public string MagicType { get; set; }

        public virtual Ability Ability { get; set; }

        public virtual Location Location { get; set; }
    }
}
