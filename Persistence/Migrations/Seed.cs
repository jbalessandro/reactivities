using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence.Migrations
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Activities.Any())
            {
                var activities = new List<Activity>
                {
                    new Activity
                    {
                        City = "Sao Paulo"
                    }
                };
            }
        }
    }
}