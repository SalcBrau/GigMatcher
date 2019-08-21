using Data.Values;
using GigMatcher.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GigMatcher.Extensions
{
    public static class ApplicationDbContextExtensions
    {
        public static void Seed(this ApplicationDbContext context, IDbValues dbValues)
        {
            context.Database.EnsureCreated();

            List<Type> SeedClass = new List<Type>();
        }
    }
}
