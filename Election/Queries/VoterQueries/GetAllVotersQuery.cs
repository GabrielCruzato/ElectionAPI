using Election.DTO;
using Election.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election.Queries.VoterQueries
{
    public record GetAllVotersQuery() : IRequest<List<VoterModel>>
    {
    }
}
