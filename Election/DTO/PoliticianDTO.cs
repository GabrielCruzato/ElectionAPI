using Election.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election.DTO
{
    public class PoliticianDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string CpfCnpj { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int PoliticalParty { get; set; }
    }
}
