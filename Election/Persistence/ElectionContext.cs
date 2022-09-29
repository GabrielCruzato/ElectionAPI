using Election.Entities;
using Microsoft.EntityFrameworkCore;



namespace Election.Persistence
{
    public class ElectionContext : DbContext
    {
        public DbSet<Politician> politician { get; set; }
        public DbSet<PoliticalParty> politicalParty { get; set; }
        public DbSet<Person> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=politician;Trusted_Connection=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


    }
}
