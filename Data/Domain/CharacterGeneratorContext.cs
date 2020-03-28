namespace Data.Domain
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CharacterGeneratorContext : DbContext
    {
        public CharacterGeneratorContext()
            : base("name=CharacterGeneratorContext")
        {
        }

        public virtual DbSet<Ability> Abilities { get; set; }
        public virtual DbSet<Adventure> Adventures { get; set; }
        public virtual DbSet<Dwarf> Dwarves { get; set; }
        public virtual DbSet<Elf> Elves { get; set; }
        public virtual DbSet<Hobbit> Hobbits { get; set; }
        public virtual DbSet<Human> Humans { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Magical> Magicals { get; set; }
        public virtual DbSet<Mental> Mentals { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Physical> Physicals { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Wizard> Wizards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ability>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Ability>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Ability>()
                .Property(e => e.abilityType)
                .IsUnicode(false);

            modelBuilder.Entity<Ability>()
                .HasOptional(e => e.Magical)
                .WithRequired(e => e.Ability);

            modelBuilder.Entity<Ability>()
                .HasOptional(e => e.Mental)
                .WithRequired(e => e.Ability);

            modelBuilder.Entity<Ability>()
                .HasOptional(e => e.Physical)
                .WithRequired(e => e.Ability);

            modelBuilder.Entity<Ability>()
                .HasMany(e => e.Persons)
                .WithMany(e => e.Abilities)
                .Map(m => m.ToTable("PersonAbilityXref").MapLeftKey("AbilityID").MapRightKey("PersonID"));

            modelBuilder.Entity<Adventure>()
                .Property(e => e.LeaderName)
                .IsUnicode(false);

            modelBuilder.Entity<Adventure>()
                .Property(e => e.CompanionNames)
                .IsUnicode(false);

            modelBuilder.Entity<Dwarf>()
                .Property(e => e.DwarfGroup)
                .IsUnicode(false);

            modelBuilder.Entity<Elf>()
                .Property(e => e.ElfType)
                .IsUnicode(false);

            modelBuilder.Entity<Hobbit>()
                .Property(e => e.HomeType)
                .IsUnicode(false);

            modelBuilder.Entity<Human>()
                .Property(e => e.AncestralLine)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.InhabitantsPrimaryRace)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.RelativeMapPosition)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.Region)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.Adventures)
                .WithRequired(e => e.Location)
                .HasForeignKey(e => e.WhereToLocationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.Magicals)
                .WithRequired(e => e.Location)
                .HasForeignKey(e => e.ArchiveLocationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.Mentals)
                .WithRequired(e => e.Location)
                .HasForeignKey(e => e.SchoolLocationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.Persons)
                .WithRequired(e => e.Location)
                .HasForeignKey(e => e.HomeTownLocationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.Physicals)
                .WithRequired(e => e.Location)
                .HasForeignKey(e => e.TrainingLocationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Magical>()
                .Property(e => e.MagicType)
                .IsUnicode(false);

            modelBuilder.Entity<Mental>()
                .Property(e => e.RaceOfOrigin)
                .IsUnicode(false);

            modelBuilder.Entity<Mental>()
                .Property(e => e.Subject)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.HairColor)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.EyeColor)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.SkinComplexion)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.RaceType)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.WeaponOfChoice)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Adventures)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.MainPersonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasOptional(e => e.Dwarf)
                .WithRequired(e => e.Person);

            modelBuilder.Entity<Person>()
                .HasOptional(e => e.Elf)
                .WithRequired(e => e.Person);

            modelBuilder.Entity<Physical>()
                .Property(e => e.ToolRequired)
                .IsUnicode(false);

            modelBuilder.Entity<Physical>()
                .Property(e => e.RaceOfOrigin)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.PrimaryRace)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.GenderRole)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Persons)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.PositionRoleID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Wizard>()
                .Property(e => e.MagicType)
                .IsUnicode(false);

            modelBuilder.Entity<Wizard>()
                .Property(e => e.WizardColor)
                .IsUnicode(false);
        }
    }
}
