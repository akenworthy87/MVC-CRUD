using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVC_CRUD.Data;
using System;
using System.Linq;

namespace MVC_CRUD.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVC_CRUDContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MVC_CRUDContext>>()))
            {
                // Look for any records.
                if (context.Severity.Any())
                {
                    return;   // DB has been seeded
                }

                context.Severity.AddRange(
                    new Severity
                    {
                        Id = 1,
                        SeverityName = "CRITICAL"
                    },

                    new Severity
                    {
                        Id = 2,
                        SeverityName = "High"
                    },

                    new Severity
                    {
                        Id = 3,
                        SeverityName = "Medium"
                    },

                    new Severity
                    {
                        Id = 4,
                        SeverityName = "Low"
                    }
                );
                context.SaveChanges();

                // These add in reverse order, which is a bit weird!
                context.Issue.AddRange(
                    new Issue
                    {
                        Name = "Jeremy Clarkson",
                        Location = "Clarkson's office",
                        SeverityId = 2,
                        SubmittedDate = DateTime.Parse("01-04-2021"),
                        ResolvedDate = DateTime.Parse("02-04-2021"),
                        Description = "Monitor no work!!",
                        Notes = "Power button pushed in too hard",
                        Resolution = "Swapped monitor",
                        Resolved = true
                    },

                    new Issue
                    {
                        Name = "Richard Hammond",
                        Location = "Garage",
                        SeverityId = 1,
                        SubmittedDate = DateTime.Parse("05-04-2021"),
                        Description = "System has crashed again"
                    },

                    new Issue
                    {
                        Name = "James May",
                        Location = "James May",
                        SeverityId = 4,
                        SubmittedDate = DateTime.Parse("06-04-2021"),
                        Description = "Requested new gramophone",
                        Notes = "Ordered to arrive next week, along with the woofers and tweeters"
                    },

                    new Issue
                    {
                        Name = "The Stig",
                        Location = "Stig Cave",
                        SeverityId = 3,
                        SubmittedDate = DateTime.Parse("07-04-2021"),
                        ResolvedDate = DateTime.Parse("07-04-2021"),
                        Description = "...",
                        Resolution = "Needs more information",
                        Resolved = true
                    }
                );
                context.SaveChanges();
            }
        }
    }
}