using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GigMatcher.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace GigMatcher.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // sets up one-to-many relationships
            modelBuilder.Entity<Musician>()
                .HasMany(m => m.Gigs)
                .WithOne(g => g.Owner);

            modelBuilder.Entity<Musician>()
                .HasMany(m => m.Positions)
                .WithOne(p => p.Musician);

            modelBuilder.Entity<Musician>()
                .HasMany(m => m.Applications)
                .WithOne(a => a.Musician);

            modelBuilder.Entity<Gig>()
                .HasMany(g => g.Positions)
                .WithOne(p => p.Gig);

            modelBuilder.Entity<Gig>()
                .HasOne(g => g.GigStatus)
                .WithMany(gs => gs.Gigs);

            modelBuilder.Entity<Position>()
                .HasMany(p => p.Applications)
                .WithOne(a => a.Position);

            modelBuilder.Entity<Position>()
                .HasOne(p => p.PositionStatus)
                .WithMany(ps => ps.Positions);

            // sets up join tables for many-to-many relationships
            modelBuilder.Entity<MusicianInstrument>()
                .HasKey(mi => new { mi.MusicianId, mi.InstrumentId });
            modelBuilder.Entity<MusicianInstrument>()
                .HasOne(mi => mi.Musician)
                .WithMany(m => m.MusicianInstruments)
                .HasForeignKey(mi => mi.MusicianId);
            modelBuilder.Entity<MusicianInstrument>()
                .HasOne(mi => mi.Instrument)
                .WithMany(i => i.MusicianInstruments)
                .HasForeignKey(mi => mi.InstrumentId);

            modelBuilder.Entity<PositionInstrument>()
                .HasKey(pi => new { pi.PositionId, pi.InstrumentId });
            modelBuilder.Entity<PositionInstrument>()
                .HasOne(pi => pi.Position)
                .WithMany(p => p.PositionInstruments)
                .HasForeignKey(pi => pi.PositionId);
            modelBuilder.Entity<PositionInstrument>()
                .HasOne(pi => pi.Instrument)
                .WithMany(i => i.PositionInstruments)
                .HasForeignKey(pi => pi.InstrumentId);
        }

        public DbSet<Application> Applications { get; set; }

        public DbSet<ApplicationStatus> ApplicationStatus { get; set; }

        public DbSet<Gig> Gigs { get; set; }

        public DbSet<GigStatus> GigStatus { get; set; }

        public DbSet<Instrument> Instruments { get; set; }

        public DbSet<InstrumentType> InstrumentTypes { get; set; }

        public DbSet<Musician> Musicians { get; set; }

        public DbSet<MusicianInstrument> MusicianInstruments { get; set; }

        public DbSet<Position> Position { get; set; }

        public DbSet<PositionInstrument> PositionInstruments { get; set; }

        public DbSet<PositionStatus> PositionStatus { get; set; }
    }
}
