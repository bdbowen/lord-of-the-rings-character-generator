namespace Data.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dwarves")]

    public partial class Dwarf : Person
    {
        [Key]
        [StringLength(50)]
        public string DwarfGroup { get; set; }
    }
}
