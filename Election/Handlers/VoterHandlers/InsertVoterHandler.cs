using AutoMapper;
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
    public class InsertVoterHandler : IRequestHandler<InsertVoterCommand, VoterModel>
    {
        private readonly ElectionContext _context;
        private readonly IMapper _mapper;

        public InsertVoterHandler(ElectionContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<VoterModel> Handle(InsertVoterCommand request, CancellationToken cancellationToken)
        {
                var entity = new VoterModel();
             

            entity.Ethnicity = request.Ethnicity;
            entity.Age = request.Age;
            entity.State = request.State;
            entity.City = request.City;
            entity.Sex = request.Sex;
            entity.PoliticianId = request.PoliticianId;

            var entitymapped = _mapper.Map<Voter>(entity);
            

            _context.Voters.Add(entitymapped);
            await _context.SaveChangesAsync();

            return entity;

        }
    }
}
