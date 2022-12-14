using Election.Entities;
using Microsoft.EntityFrameworkCore;



namespace Election.Persistence
{
    public class ElectionContext : DbContext
    {
        public DbSet<Politician> Politicians { get; set; }
        public DbSet<Voter> Voters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=Election;Trusted_Connection=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


    }
}
