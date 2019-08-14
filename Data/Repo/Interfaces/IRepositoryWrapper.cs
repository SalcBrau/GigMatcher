using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repo.Interfaces
{
    public interface IRepositoryWrapper
    {
        IApplicationRepository Application { get; }
        IGigRepository Gig { get; }
        IMusicianRepository Musician { get; }
        IPositionRepository Position { get; }
        void Save();
    }
}
