using GigMatcher.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GigMatcher.SeedingClasses
{
    public interface ISeeder
    {
        void Seed(ApplicationDbContext context);
    }
}
