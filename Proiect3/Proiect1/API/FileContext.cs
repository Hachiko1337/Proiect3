using Microsoft.EntityFrameworkCore;

namespace Proiect1.API
{
    public class FileContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public FileContext() : base() { }

        public Microsoft.EntityFrameworkCore.DbSet<File> Files { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Property> Properties { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Metadata> Metadata { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server = DESKTOP-EEBEU5F\\SQLEXPRESS; Database = TestPerson; Trusted_Connection = True");
            //ChangeTracker.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<File>()
                .HasMany<Property>(s => s.Properties)
                .WithOne(g => g.File);
            modelBuilder.Entity<File>()
                .HasOne<Metadata>(s => s.Metadata)
                .WithOne(g => g.File);
        }
    }
}
