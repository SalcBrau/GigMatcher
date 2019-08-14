using Data.Repo.Interfaces;
using GigMatcher.Data;
using GigMatcher.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repo.Implementations
{
    public class GigRepository: RepositoryBase<Gig>, IGigRepository
    {
        public GigRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
