using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Verstegen.Models
{
    public class Theme
    {
        public int ThemeId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ImgUrl { get; set; }

        public string IconUrl { get; set; }
    }
}
