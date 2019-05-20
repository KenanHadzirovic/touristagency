namespace TouristAgency.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Feature> Feature { get; set; }
        public virtual DbSet<FeatureType> FeatureType { get; set; }
        public virtual DbSet<Hotel> Hotel { get; set; }
        public virtual DbSet<Privilege> Privilege { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RolePrivilege> RolePrivilege { get; set; }
        public virtual DbSet<Tour> Tour { get; set; }
        public virtual DbSet<Tourist> Tourist { get; set; }
        public virtual DbSet<TourType> TourType { get; set; }
        public virtual DbSet<UserAccount> UserAccount { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Feature>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<FeatureType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<FeatureType>()
                .HasMany(e => e.Feature)
                .WithRequired(e => e.FeatureType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hotel>()
                .HasMany(e => e.Tour)
                .WithRequired(e => e.Hotel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Privilege>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Privilege>()
                .HasMany(e => e.RolePrivilege)
                .WithRequired(e => e.Privilege)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.RolePrivilege)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.UserAccount)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tour>()
                .HasMany(e => e.Feature)
                .WithRequired(e => e.Tour)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tourist>()
                .HasMany(e => e.Tour)
                .WithRequired(e => e.Tourist)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TourType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TourType>()
                .Property(e => e.Price)
                .HasPrecision(4, 2);

            modelBuilder.Entity<TourType>()
                .HasMany(e => e.Tour)
                .WithRequired(e => e.TourType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserAccount>()
                .HasMany(e => e.Employee)
                .WithRequired(e => e.UserAccount)
                .WillCascadeOnDelete(false);
        }
    }
}
