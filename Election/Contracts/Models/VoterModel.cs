using Election.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election.DTO
{
    public class VoterModel
    {
        public string Age { get; set; }

        public string Ethnicity { get; set; }

        public string Sex { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public int Id { get; set; }
    }
}
