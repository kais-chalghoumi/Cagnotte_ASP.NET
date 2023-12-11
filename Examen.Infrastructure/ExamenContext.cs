
using Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Examen.Infrastructure
{
    public class ExamenContext: DbContext
    {
        public ExamenContext(DbContextOptions options) : base(options)
        {

        }

        public ExamenContext()
        {
            //Database.EnsureCreated();
        }

        public DbSet<Cagnotte> Cagnotte { get; set; }
        public DbSet<Entreprise> Entreprise { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=ExamenDB32;Integrated Security=true");
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