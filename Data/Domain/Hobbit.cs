namespace Data.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hobbits")]
    public partial class Hobbit : Person
    {
        [Required]
        [StringLength(50)]
        public string HomeType { get; set; }

        public bool IsAdventurer { get; set; }

        public bool OwnsOneRing { get; set; }
    }
}
