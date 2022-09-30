using Election.Commands;
using Election.DTO;
using Election.Entities;
using Election.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election.Handlers.VoterHandlers
{
    public class InsertVoterHandler : IRequestHandler<InsertVoterCommand, Voter>
    {
        private readonly ElectionContext _context;

        public InsertVoterHandler(ElectionContext context)
        {
            _context = context;
        }

        public async Task<Voter> Handle(InsertVoterCommand request, CancellationToken cancellationToken)
        {
             var entity = new Voter();

            entity.Ethnicity = request.Ethnicity;
            entity.Age = request.Age;
            entity.State = request.State;
            entity.City = request.City;
            entity.Sex = request.Sex;
            entity.PoliticianId = request.PoliticianId;

            _context.Voters.Add(entity);
            await _context.SaveChangesAsync();

            return entity;

        }
    }
}
