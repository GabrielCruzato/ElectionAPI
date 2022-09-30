using AutoMapper;
using Election.DTO;
using Election.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election.Contracts.Mapping
{
    internal class PoliticianProfile : Profile
    {
        public PoliticianProfile()
        {
            CreateMap<PoliticianModel, Politician>().ReverseMap();
        }
    }
}
