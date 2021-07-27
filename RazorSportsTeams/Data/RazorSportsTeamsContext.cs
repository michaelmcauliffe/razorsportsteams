using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorSportsTeams.Models;

namespace RazorSportsTeams.Data
{
    public class RazorSportsTeamsContext : DbContext
    {
        public RazorSportsTeamsContext (DbContextOptions<RazorSportsTeamsContext> options)
            : base(options)
        {
        }

        public DbSet<RazorSportsTeams.Models.Team> Team { get; set; }
    }
}
