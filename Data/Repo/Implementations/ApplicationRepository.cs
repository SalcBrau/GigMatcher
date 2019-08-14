using Data.Repo.Interfaces;
using GigMatcher.Data;
using GigMatcher.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repo.Implementations
{
    public class ApplicationRepository : RepositoryBase<Application>, IApplicationRepository
    {
        public ApplicationRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
