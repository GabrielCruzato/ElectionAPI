using Election.Contracts.Models;
using Election.Persistence;
using Election.Queries.VoterQueries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election.Handlers.VoterHandlers
{
    public class GetElectionResultHandler : IRequestHandler<GetElectionResultQuery, QuantityOfVotesDto>
    {
        private readonly ElectionContext _context;

        public GetElectionResultHandler(ElectionContext context)
        {
            _context = context;
        }

        public async Task<QuantityOfVotesDto> Handle(GetElectionResultQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Voters.ToListAsync();
            var quantityOfVotes = new QuantityOfVotesDto();

            foreach(var voter in entity)
            {
                if(_context.Voters.Any(a => a.PoliticianId == 1))
                {
                    quantityOfVotes.Bolsonaro++;
                }

                if(_context.Voters.Any(a => a.PoliticianId == 2))
                {
                    quantityOfVotes.Lula++;
                }

                else
                {
                    quantityOfVotes.Ciro++;
                }
            }

            return quantityOfVotes;

        }
    }
}
