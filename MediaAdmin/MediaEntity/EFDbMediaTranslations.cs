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

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Translator> Translators { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.CompanyName)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Jobs)
                .WithRequired(e => e.Customers)
                .WillCascadeOnDelete(false);
        }
    }
}
