using Election.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election.Persistence
{
    public interface IElectionContext
    {
         DbSet<Politician> Politicians { get; set; }
         DbSet<Voter> Voters { get; set; }
    }
}
