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
    public class IndexModel : PageModel
    {
        private readonly RazorSportsTeams.Data.RazorSportsTeamsContext _context;

        public IndexModel(RazorSportsTeams.Data.RazorSportsTeamsContext context)
        {
            _context = context;
        }

        public IList<Team> Team { get;set; }

        public async Task OnGetAsync()
        {
            Team = await _context.Team.ToListAsync();
        }
    }
}
