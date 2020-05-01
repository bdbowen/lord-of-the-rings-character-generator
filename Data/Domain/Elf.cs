namespace Data.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Elves")]

    public partial class Elf : Person
    {
        [Key]
        [StringLength(50)]
        public string ElfType { get; set; }

        [Key]
        public bool OwnsRingOfPower { get; set; }
    }
}
