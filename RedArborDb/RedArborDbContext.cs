using Microsoft.EntityFrameworkCore;

namespace RedArborDb
{
    public class RedArborDbContext : DbContext
    {
        public RedArborDbContext(DbContextOptions<RedArborDbContext> options) : base(options)
        {

        }

        public DbSet<Candidates> Candidates { get; set; }
        public DbSet<CandidateExperiences> CandidateExperiences { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidates>().ToTable("Candidates");
            modelBuilder.Entity<CandidateExperiences>().ToTable("CandidateExperiences");
        }
    }
}