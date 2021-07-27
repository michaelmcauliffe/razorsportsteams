using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorSportsTeams.Models
{
    public class Team
    {
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string City { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string Stadium { get; set; }
    }
}
