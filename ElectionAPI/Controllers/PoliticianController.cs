using Election.Entities;
using Election.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Refit;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;
using MediatR;

namespace ElectionAPI.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class PoliticianController : ControllerBase
    { 
        private readonly ElectionContext _context;

        public PoliticianController(ElectionContext context)
        {
            _context = context;
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var result = await _context.politician.FindAsync(Id);

            if(result is null)
            {
                return BadRequest();
            }

            return Ok(result);
        }



        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _context.politician.ToListAsync());
        }

        [HttpPost("addAll")]
        public async Task<IActionResult> AddPolitician([FromBody] Politician politician)
        {
            var entity = new Politician();

            entity.City = politician.City;
            entity.Age = politician.Age;
            entity.State = politician.State;
            entity.FirstName = politician.FirstName;
            entity.LastName = politician.LastName;
            entity.CpfCnpj = politician.CpfCnpj;

             _context.politician.Add(entity);
             await _context.SaveChangesAsync();

            return Ok();
        }
        
    }
}
