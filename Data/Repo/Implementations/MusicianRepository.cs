using Data.Repo.Interfaces;
using GigMatcher.Data;
using GigMatcher.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repo.Implementations
{
    public class MusicianRepository: RepositoryBase<Musician>, IMusicianRepository
    {
        public MusicianRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
