using CA.ApplicationCore.Domain;
using CA.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CA.Infrastructure
{
    public class CagnotteContext : DbContext
    {
        public CagnotteContext(DbContextOptions options) : base(options)
        {}

        public CagnotteContext()
        {
            //Database.EnsureCreated();
        }

        public DbSet<Cagnotte> Cagnotte { get; set; }
        public DbSet<Entreprise> Entreprise { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Cagnotte ;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new ParticipationConfiguration().Configure(modelBuilder.Entity<Participation>());
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
        }

    }
}