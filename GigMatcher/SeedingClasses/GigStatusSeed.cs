using GigMatcher.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GigMatcher.SeedingClasses
{
    public class GigStatusSeed : ISeeder
    {
        public void Seed(ApplicationDbContext context)
        {
            foreach (var state in context.DbStates.GigStatus.Values)
            {
                if (!context.GigStatus.Any(gs => gs.Id == state.Id))
                {

                }
            }
        }
    }
}
