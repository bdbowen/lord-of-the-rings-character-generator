namespace Data.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Humans")]
    public partial class Human : Person
    {
        [Key]
        [StringLength(50)]
        public string AncestralLine { get; set; }
    }
}
