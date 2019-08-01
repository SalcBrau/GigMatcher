using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GigMatcher.Data.Entities;

namespace GigMatcher.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Gig> Gigs { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Opening> Openings { get; set; }
    }
}
