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
    [Route("api/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class PoliticianController : ControllerBase
    {
        private readonly IElectionContext _context;
        private readonly IMediator mediator;

        public PoliticianController(IElectionContext context, IMediator mediator)
        {
            _context = context;
            this.mediator = mediator;
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var result = await _context.Voters.FindAsync(Id);

            if (result is null)
            {
                return BadRequest();
            }

            return Ok(result);
        }



        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllVotersQuery();

            var result = await mediator.Send(query);

            return Ok(result);
        }

        //[HttpPost("addAll")]
        //public async Task<IActionResult> AddPolitician([FromBody] Politician politician)
        //{

        //}

    }
}
