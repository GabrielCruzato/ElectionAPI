using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election.Entities
{
    public class Voter
    {

        [Required]
        public string Age { get; set; }

        [Required]
        public string Ethnicity { get; set; }

        [Required]
        public string Sex { get; set; }

        [Required]  
        public string State { get; set; }

        [Required]
        public string City { get; set; }

        public virtual Politician Politician { get; set; }

        [ForeignKey("Politician")]
        public int PoliticianId { get; set; }

        [Key]
        public int Id { get; set; }
    }
}
