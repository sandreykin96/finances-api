using Microsoft.EntityFrameworkCore;

namespace Finances.Dal.EF
{
    public class FinancesContext : DbContext
    {
        public DbSet<Entities.Finances> Finances { get; set; }

        public FinancesContext(DbContextOptions<FinancesContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.Finances>()
                .HasKey(p => new { p.UserId, p.Period });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder
              .UseNpgsql()
              .UseSnakeCaseNamingConvention();
    }
}
