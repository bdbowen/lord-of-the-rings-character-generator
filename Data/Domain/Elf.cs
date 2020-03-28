namespace Data.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Elf
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonID { get; set; }

        [Required]
        [StringLength(50)]
        public string ElfType { get; set; }

        public bool OwnsRingOfPower { get; set; }

        public virtual Person Person { get; set; }
    }
}
