using Election.Entities;
using Election.Persistence;
using Election.Queries.VoterQueries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election.Handlers.VoterHandlers
{
    public class GetAllVotersHandler : IRequestHandler<GetAllVotersQuery, List<Voter>>
    {
        private readonly ElectionContext _context;

        public GetAllVotersHandler(ElectionContext context)
        {
            _context = context;
        }

        public async Task<List<Voter>> Handle(GetAllVotersQuery request, CancellationToken cancellationToken)
        {
            var Result = await _context.Voters.ToListAsync();

            return Result;
        }
    }
}
