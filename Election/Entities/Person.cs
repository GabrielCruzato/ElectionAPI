using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election.Entities
{
    public class Person
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Age { get; set; }

        [Required]
        public string Ethnicity { get; set; }

        [Required]
        public string SexualOrientation { get; set; }
        
        [Key]
        public int Id { get; set; }
    }
}
