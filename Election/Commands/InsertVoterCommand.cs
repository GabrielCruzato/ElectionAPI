using Election.DTO;
using Election.Entities;
using MediatR;

namespace Election.Commands
{
    public record InsertVoterCommand(
     string Age,

     string Ethnicity,

     string Sex,

     string State,

     string City,

     int PoliticianId) : IRequest<VoterModel>;
}

