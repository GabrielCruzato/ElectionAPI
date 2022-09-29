using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election.Entities
{
    public class PoliticalParty
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PartyName { get; set; }

        public string PartyNumber { get; set; }

        public IEnumerable<Politician> politicians { get; set; }
    }
}
