using Election.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election.DTO
{
    public class PoliticianModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
