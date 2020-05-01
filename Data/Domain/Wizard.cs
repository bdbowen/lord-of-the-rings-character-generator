namespace Data.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Wizards")]

    public partial class Wizard : Person
    {
        [Key]
        [StringLength(50)]
        public string MagicType { get; set; }

        [Key]
        [StringLength(50)]
        public string WizardColor { get; set; }
    }
}
