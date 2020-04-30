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
        [Column(Order = 0)]
        [StringLength(50)]
        public string MagicType { get; set; }

        [Column(Order = 1)]
        [StringLength(50)]
        public string WizardColor { get; set; }
    }
}
