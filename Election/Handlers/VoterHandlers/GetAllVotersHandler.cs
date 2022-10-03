using AutoMapper;
using Election.DTO;
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
        private readonly IMapper _mapper;

        public GetAllVotersHandler(ElectionContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Voter>> Handle(GetAllVotersQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Voters.ToListAsync();

            return entity;
        }
    }
}
