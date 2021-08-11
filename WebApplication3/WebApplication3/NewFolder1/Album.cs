namespace WebApplication3.NewFolder1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Album : DbContext
    {
        public Album()
            : base("name=Album")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Position)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Office)
                .IsUnicode(false);
        }
    }
}
