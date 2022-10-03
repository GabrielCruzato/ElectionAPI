using Election.Commands;
using Election.DTO;
using Election.Entities;
using Election.Handlers;
using Election.Persistence;
using Election.Queries;
using Election.Queries.VoterQueries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace ElectionAPI.Controllers.PoliticianControllers
{
    [Route("api")]
    [AllowAnonymous]
    [ApiController]

    public class VoterController : ControllerBase
    {
        private readonly ElectionContext _context;
        private readonly IMediator mediator;

        public VoterController(ElectionContext context, IMediator mediator)
        {
            _context = context;
            this.mediator = mediator;
        }

       
        [HttpPost("PostVoter")]
        public async Task<IActionResult> AddVoter([FromBody] VoterModel voter)
        {
            var command = new InsertVoterCommand(voter.Age, voter.Ethnicity, voter.State, voter.City, voter.Sex, voter.PoliticianId);
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("getallvoters")]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllVotersQuery();

            var result = await mediator.Send(query);

            return Ok(result);
        }


        [HttpGet("GetElectionPollResult")]
        public async Task<IActionResult> GetElectionPollResult()
        {
            var query = new GetElectionResultQuery();

            var result = await mediator.Send(query);

            return Ok(result);
        }


    }
}

//int votes = 0;
//int voteforlula = 0;
//int voteforbolsonaro = 0;

//foreach (var PoliticiansNumber in Result)
//{
//    if (votes == 13)
//    {
//        votes++;
//        voteforlula++;
//    }

//    else
//    {
//        votes++;
//        voteforbolsonaro++;
//    }
//}