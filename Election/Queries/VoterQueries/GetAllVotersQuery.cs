﻿using Election.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election.Queries.VoterQueries
{
    public record GetAllVoterQuery() : IRequest<List<Voter>>
    {
    }
}
