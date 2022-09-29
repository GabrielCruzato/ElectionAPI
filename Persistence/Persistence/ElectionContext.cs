using Election.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Election.Persistence
{
    public class ElectionContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server = localhost; Database = master; Trusted_Connection = True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

       public DbSet<PoliticianModel> politicianModels { get; set; }

    }
}
