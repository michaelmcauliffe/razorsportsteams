using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSportsTeams.Data;
using RazorSportsTeams.Models;

namespace RazorSportsTeams.Pages.Teams
{
    public class DetailsModel : PageModel
    {
        private readonly RazorSportsTeams.Data.RazorSportsTeamsContext _context;

        public DetailsModel(RazorSportsTeams.Data.RazorSportsTeamsContext context)
        {
            _context = context;
        }

        public Team Team { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Team = await _context.Team.FirstOrDefaultAsync(m => m.ID == id);

            if (Team == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
