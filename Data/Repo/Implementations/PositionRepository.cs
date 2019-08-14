using Data.Repo.Interfaces;
using GigMatcher.Data;
using GigMatcher.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repo.Implementations
{
    class PositionRepository : RepositoryBase<Position>, IPositionRepository
    {
        public PositionRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
