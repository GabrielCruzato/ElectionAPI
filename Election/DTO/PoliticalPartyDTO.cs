using Election.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election.DTO
{
    public class PoliticalPartyDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string PartyAbreviation { get; set; }
        [Required]
        public string PartyLogo { get; set; }
        [Required]
        public IEnumerable<Politician> MembersOfTheParty { get; set; }
    }
}
