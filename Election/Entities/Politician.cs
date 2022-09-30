using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election.Entities
{
    public sealed class Politician : BaseEntity
    {   

        [Required]
        public string Name { get; private set; }

    }
}
