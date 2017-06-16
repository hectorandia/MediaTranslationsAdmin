namespace MediaAdmin.MediaEntity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
 

    public partial class EFDbMediaTranslations : DbContext
    {
        public EFDbMediaTranslations()
            : base("name=DBMediaTranslations")
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Jobs> Jobs { get; set; }
        public virtual DbSet<Translators> Translators { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>()
                .Property(e => e.CompanyName)
                .IsFixedLength();

            modelBuilder.Entity<Customers>()
                .HasMany(e => e.Jobs)
                .WithRequired(e => e.Customers)
                .WillCascadeOnDelete(false);
        }
    }
}
