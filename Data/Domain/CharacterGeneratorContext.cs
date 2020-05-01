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

        public virtual DbSet<Adventure> Adventures { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Dwarf> Dwarves { get; set; }
        public virtual DbSet<Elf> Elves { get; set; }
        public virtual DbSet<Hobbit> Hobbits { get; set; }
        public virtual DbSet<Human> Humans { get; set; }
        public virtual DbSet<Wizard> Wizards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adventure>()
                .Property(e => e.LeaderName)
                .IsUnicode(false);

            modelBuilder.Entity<Adventure>()
                .Property(e => e.CompanionNames)
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
                .HasMany(e => e.Persons)
                .WithRequired(e => e.Location)
                .HasForeignKey(e => e.HomeTownLocationID);

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
                .HasForeignKey(e => e.MainPersonID);

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
                .HasForeignKey(e => e.PositionRoleID);

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

            modelBuilder.Entity<Wizard>()
                .Property(e => e.MagicType)
                .IsUnicode(false);

            modelBuilder.Entity<Wizard>()
                .Property(e => e.WizardColor)
                .IsUnicode(false);
        }
    }
}
