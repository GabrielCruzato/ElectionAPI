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
            var quantityOfVotes = new QuantityOfVotesDto();

            var total = await _context.Voters.CountAsync();

            var LulaVotes = await _context.Voters.Where(a => a.PoliticianId == 1).CountAsync();
            var BolsonaroVotes = await _context.Voters.Where(a => a.PoliticianId == 2).CountAsync();
            var CiroVotes = await _context.Voters.Where(a => a.PoliticianId == 3).CountAsync();


            quantityOfVotes.Lula = (int)Math.Round((double)(100 * LulaVotes) / total);

            quantityOfVotes.Bolsonaro = (int)Math.Round((double)(100 * BolsonaroVotes) / total);

            quantityOfVotes.Ciro = (int)Math.Round((double)(100 * CiroVotes) / total);

            return quantityOfVotes;

        }
    }
}
