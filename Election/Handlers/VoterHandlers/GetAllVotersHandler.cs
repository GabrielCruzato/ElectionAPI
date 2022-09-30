using Election.Entities;
using Election.Persistence;
using Election.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election.Handlers.VoterHandlers
{
    public class GetVoterHandler : IRequestHandler<GetAllVoterQuery, List<Voter>>
    {
        private readonly ElectionContext _context;

        public GetVoterHandler(ElectionContext context)
        {
            _context = context;
        }

        public async Task<List<Voter>> Handle(GetAllVoterQuery request, CancellationToken cancellationToken)
        {
            var Result = await _context.Voters.ToListAsync();

            return Result;
        }
    }
}
