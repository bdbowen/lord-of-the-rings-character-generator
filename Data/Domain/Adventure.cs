namespace Data.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Adventure
    {
        public int AdventureID { get; set; }

        [Required]
        [StringLength(50)]
        public string LeaderName { get; set; }

        public int WhereToLocationID { get; set; }

        [Required]
        public string CompanionNames { get; set; }

        public bool Successful { get; set; }

        public bool Fatal { get; set; }

        public int MainPersonID { get; set; }

        public virtual Location Location { get; set; }

        public virtual Person Person { get; set; }
    }
}
