using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election.Entities
{
    public class Politician : Person
    {

        [Required]
        public string CpfCnpj { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string City { get; set; }

        [ForeignKey("PoliticalParty")]
        public int PoliticalPartyId { get; set; }
        public virtual PoliticalParty PoliticalParty {get; set;}

    }
}
