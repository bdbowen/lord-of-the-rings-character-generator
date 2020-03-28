namespace Data.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ability
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ability()
        {
            Persons = new HashSet<Person>();
        }

        public int AbilityID { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(2400)]
        public string Description { get; set; }

        public int DifficultyLevel { get; set; }

        public bool Exhausting { get; set; }

        [Required]
        [StringLength(50)]
        public string abilityType { get; set; }

        public virtual Magical Magical { get; set; }

        public virtual Mental Mental { get; set; }

        public virtual Physical Physical { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person> Persons { get; set; }
    }
}
