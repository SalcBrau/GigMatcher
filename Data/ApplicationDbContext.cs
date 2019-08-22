using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GigMatcher.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Data.Values;
using Microsoft.EntityFrameworkCore.Metadata;
using Data.Entities;

namespace GigMatcher.Data
{
    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Application>(entity =>
            {
                entity.ToTable(name: "Applications", schema: "dbo");

                entity.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                entity.Property<int>("ApplicationStatusId");

                entity.Property<int>("MusicianId");

                entity.Property<int>("PositionId");

                entity.HasKey("Id");

                entity.HasIndex("ApplicationStatusId");

                entity.HasIndex("MusicianId");

                entity.HasIndex("PositionId");

                entity.HasOne(a => a.Musician)
                    .WithMany(m => m.Applications)
                    .HasForeignKey("MusicianId")
                    .HasConstraintName("FK_Application_Musicians_MusicianId")
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(a => a.Position)
                    .WithMany(p => p.Applications)
                    .HasForeignKey("PositionId")
                    .HasConstraintName("FK_Application_Positions_PositionId")
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(a => a.ApplicationStatus)
                    .WithMany(ast => ast.Applications)
                    .HasForeignKey("ApplicationStatusId")
                    .HasConstraintName("FK_Application_ApplicationStatus_ApplicationStatusId")
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<ApplicationStatus>(entity =>
            {
                entity.ToTable(name: "ApplicationStatus", schema: "dbo");

                entity.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                entity.Property<DateTime>("DateCreated");

                entity.Property<string>("Name")
                    .IsRequired();

                entity.HasKey("Id");
            });

            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "AspNetUser", schema: "AspIdentity");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(au => au.Musician)
                    .WithOne(m => m.User)
                    .HasForeignKey("Musician", "MusicianId")
                    .HasConstraintName("FK_ApplicationUser_Musicians_MusicianId")
                    .OnDelete(DeleteBehavior.Restrict);

            });

            modelBuilder.Entity<Gig>(entity =>
            {
                entity.ToTable(name: "Gigs", schema: "dbo");

                entity.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                entity.Property<DateTime>("DateCreated");

                entity.Property<string>("Description")
                    .IsRequired();

                entity.Property<DateTime>("GigEnd");

                entity.Property<DateTime>("GigStart");

                entity.Property<int>("GigStatusId");

                entity.Property<string>("Location")
                    .IsRequired();

                entity.Property<int>("NumberOfPositions");

                entity.Property<int>("OwnerId")
                    .IsRequired();

                entity.Property<decimal>("TotalPay");

                entity.HasKey("Id");

                entity.HasIndex("GigStatusId");

                entity.HasIndex("OwnerId");
                /*
                entity.HasOne(g => g.Owner)
                    .WithMany(o => o.Gigs)
                    .HasForeignKey("Musician", "OwnerId")
                    .HasConstraintName("FK_Gig_Musicians_OwnerId")
                    .OnDelete(DeleteBehavior.Cascade);
*/
                entity.HasMany(g => g.Positions)
                    .WithOne(p => p.Gig);

                entity.HasOne(g => g.GigStatus)
                    .WithMany(gs => gs.Gigs)
                    .HasForeignKey("GigStatusId")
                    .HasConstraintName("FK_Gig_GigStatus_GigStatusId")
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<GigStatus>(entity =>
            {
                entity.ToTable(name: "GigStatus", schema: "dbo");

                entity.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                entity.Property<DateTime>("DateCreated")
                    .IsRequired()
                    .HasDefaultValue(DateTime.UtcNow);

                entity.HasKey("Id");
            });

            modelBuilder.Entity<Instrument>(entity =>
            {
                entity.ToTable(name: "Instruments", schema: "dbo");

                entity.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                entity.Property<DateTime>("DateCreated");

                entity.Property<int>("InstrumentTypeId");

                entity.Property<string>("Name")
                    .IsRequired();

                entity.HasKey("Id");

                entity.HasIndex("InstrumentTypeId");

                entity.HasOne(i => i.InstrumentType)
                    .WithMany(it => it.Instruments)
                    .HasForeignKey("InstrumentTypeId")
                    .HasConstraintName("FK_Instrument_InstrumentTypes_InstrumentTypeId")
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<InstrumentType>(entity =>
            {
                entity.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                entity.Property<DateTime>("DateCreated");

                entity.Property<string>("Name")
                    .IsRequired();

                entity.HasKey("Id");

                entity.ToTable(name: "InstrumentTypes", schema: "dbo");
            });

            modelBuilder.Entity<Musician>(entity =>
            {
                entity.ToTable(name: "Musicians", schema: "dbo");

                entity.Property<int>("Id")
                    .IsRequired()
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                entity.Property<DateTime>("DateCreated")
                    .IsRequired()
                    .HasDefaultValue(DateTime.UtcNow);

                entity.Property<DateTime>("DateOfBirth")
                    .IsRequired();

                entity.Property<string>("FirstName")
                    .IsRequired();

                entity.Property<string>("LastName")
                    .IsRequired();

                entity.Property<string>("Location");

                entity.Property<int>("Rating");

                entity.Property<int>("UserId");

                entity.Property<int>("YearPlaying");

                entity.Property<int>("YearsProfessionalExperience");

                entity.HasKey("Id");

                entity.HasIndex("UserId");

                entity.HasOne(m => m.User)
                    .WithOne(au => au.Musician)
                    .HasForeignKey("ApplicationUser", "UserId")
                    .HasConstraintName("FK_Musician_ApplicationUsers_UserId")
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(m => m.Gigs)
                    .WithOne(g => g.Owner)
                    .OnDelete(DeleteBehavior.Restrict); 

                entity.HasMany(m => m.Positions)
                    .WithOne(p => p.Musician)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(m => m.Applications)
                    .WithOne(a => a.Musician)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MusicianInstrument>(entity =>
            {
                entity.ToTable(name: "MusicianInstruments", schema: "dbo");

                entity.HasKey(mi => new { mi.MusicianId, mi.InstrumentId });

                entity.HasOne(mi => mi.Musician)
                    .WithMany(m => m.MusicianInstruments)
                    .HasForeignKey(mi => mi.MusicianId);

                entity.HasOne(mi => mi.Instrument)
                    .WithMany(i => i.MusicianInstruments)
                    .HasForeignKey(mi => mi.InstrumentId);
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.ToTable(name: "Positions", schema: "dbo");

                entity.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                entity.Property<string>("Description")
                    .IsRequired();

                entity.Property<int>("GigId");

                entity.Property<int?>("MusicianId");

                entity.Property<decimal>("Pay");

                entity.Property<int>("PositionStatusId");

                entity.HasKey("Id");

                entity.HasIndex("GigId");

                entity.HasIndex("MusicianId");

                entity.HasIndex("PositionStatusId");

                entity.HasMany(p => p.Applications)
                    .WithOne(a => a.Position);

                entity.HasOne(p => p.PositionStatus)
                    .WithMany(ps => ps.Positions);

                entity.HasOne(p => p.Musician)
                    .WithMany(m => m.Positions)
                    .HasForeignKey("MusicianId")
                    .HasConstraintName("FK_Position_Musicians_MusicianId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(false);
            });

            modelBuilder.Entity<PositionInstrument>(entity =>
            {
                entity.ToTable(name: "PositionInstruments", schema: "dbo");

                entity.Property<int>("PositionId");

                entity.Property<int>("InstrumentId");

                entity.HasKey("PositionId", "InstrumentId");

                entity.HasIndex("InstrumentId");

                entity.HasKey(pi => new { pi.PositionId, pi.InstrumentId });

                entity.HasOne(pi => pi.Position)
                    .WithMany(p => p.PositionInstruments)
                    .HasForeignKey(pi => pi.PositionId);

                entity.HasOne(pi => pi.Instrument)
                    .WithMany(i => i.PositionInstruments)
                    .HasForeignKey(pi => pi.InstrumentId);
            });

            modelBuilder.Entity<PositionStatus>(entity =>
            {
                entity.ToTable(name: "PositionStatus", schema: "dbo");

                entity.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                entity.Property<DateTime>("DateCreated");

                entity.Property<string>("Name")
                    .IsRequired();

                entity.HasKey("Id");
            });
  
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


        public DbValues DbStates { get => new DbValues(); }
    }
}
