using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election.Entities
{
    public sealed class Voter : BaseEntity
    {

        [Required]
        public string Age { get; private set; }

        [Required]
        public string Ethnicity { get; private set; }

        [Required]
        public string Sex { get; private set; }

        [Required]  
        public string State { get; private set; }

        [Required]
        public string City { get; private set; }

        [Required]
        public int PoliticianId { get; private set; }
    }
}
