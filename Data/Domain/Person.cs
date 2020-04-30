namespace Data.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Persons")]
    public abstract partial class Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            Adventures = new HashSet<Adventure>();
            Abilities = new HashSet<Ability>();
        }

        public int PersonID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Age { get; set; }

        [Required]
        [StringLength(50)]
        public string HairColor { get; set; }

        [Required]
        [StringLength(50)]
        public string EyeColor { get; set; }

        [Required]
        [StringLength(50)]
        public string SkinComplexion { get; set; }

        [Required]
        [StringLength(1)]
        public string Gender { get; set; }

        public int HomeTownLocationID { get; set; }

        public int PositionRoleID { get; set; }

        public bool Evil { get; set; }

        [Required]
        [StringLength(50)]
        public string RaceType { get; set; }

        public int LengthOfRoleOccupancy { get; set; }

        public int NumberOfSubordinates { get; set; }

        [Required]
        [StringLength(50)]
        public string WeaponOfChoice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adventure> Adventures { get; set; }

        public virtual Location Location { get; set; }

        public virtual Role Role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ability> Abilities { get; set; }
    }
}
