using Microsoft.EntityFrameworkCore;

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
