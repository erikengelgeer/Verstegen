using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Verstegen.Models
{
    public class Contact
    {
        [Required]
        public int ContactId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Function { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string Province { get; set; }

        [Required]
        public string Tel { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string ImgUrl { get; set; }
        
    }
}
