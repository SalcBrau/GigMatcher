using Data.Repo.Interfaces;
using GigMatcher.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repo.Implementations
{
    public class RepositoryWrapper: IRepositoryWrapper
    {
        private ApplicationDbContext _context;
        private IApplicationRepository _application;
        private IGigRepository _gig;
        private IMusicianRepository _musician;
        private IPositionRepository _position;

        public RepositoryWrapper(ApplicationDbContext context)
        {
            _context = context;
        }

        public IApplicationRepository Application
        {
            get
            {
                if (_application == null)
                {
                    _application = new ApplicationRepository(_context);
                }

                return _application;
            }
        }

        public IGigRepository Gig
        {
            get
            {
                if (_gig == null)
                {
                    _gig = new GigRepository(_context);
                }

                return _gig;
            }
        }

        public IMusicianRepository Musician
        {
            get
            {
                if (_musician == null)
                {
                    _musician = new MusicianRepository(_context);
                }

                return _musician;
            }
        }

        public IPositionRepository Position
        {
            get
            {
                if (_position == null)
                {
                    _position = new PositionRepository(_context);
                }

                return _position;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
