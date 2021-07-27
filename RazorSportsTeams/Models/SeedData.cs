using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorSportsTeams.Data;
using System;
using System.Linq;

namespace RazorSportsTeams.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorSportsTeamsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorSportsTeamsContext>>()))
            {
                // Look for any Teams.
                if (context.Team.Any())
                {
                    return;   // DB has been seeded
                }

                context.Team.AddRange(
                    new Team
                    {
                        City = "New Orleans",
                        TeamName = "Saints",
                        Stadium = "Superdome",
                      
                    },

                    new Team
                    {
                        City = "Tampa Bay",
                        TeamName = "Buccaneers",
                        Stadium = "Raymond James",
                        
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
