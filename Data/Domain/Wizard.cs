namespace Data.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Wizard
    {
        public int PersonID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MagicType { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string WizardColor { get; set; }
    }
}
