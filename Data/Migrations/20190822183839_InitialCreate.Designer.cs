﻿// <auto-generated />
using System;
using GigMatcher.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190822183839_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Entities.ApplicationRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("GigMatcher.Data.Entities.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApplicationStatusId");

                    b.Property<int>("MusicianId");

                    b.Property<int>("PositionId");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationStatusId");

                    b.HasIndex("MusicianId");

                    b.HasIndex("PositionId");

                    b.ToTable("Applications","dbo");
                });

            modelBuilder.Entity("GigMatcher.Data.Entities.ApplicationStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ApplicationStatus","dbo");
                });

            modelBuilder.Entity("GigMatcher.Data.Entities.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<int>("MusicianId");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<int?>("UserId");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("AspNetUser","AspIdentity");
                });

            modelBuilder.Entity("GigMatcher.Data.Entities.Gig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<DateTime>("GigEnd");

                    b.Property<DateTime>("GigStart");

                    b.Property<int>("GigStatusId");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<int>("NumberOfPositions");

                    b.Property<int>("OwnerId");

                    b.Property<decimal>("TotalPay");

                    b.HasKey("Id");

                    b.HasIndex("GigStatusId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Gigs","dbo");
                });

            modelBuilder.Entity("GigMatcher.Data.Entities.GigStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 8, 22, 18, 38, 38, 965, DateTimeKind.Utc).AddTicks(2710));

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("GigStatus","dbo");
                });

            modelBuilder.Entity("GigMatcher.Data.Entities.Instrument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<int>("InstrumentTypeId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("InstrumentTypeId");

                    b.ToTable("Instruments","dbo");
                });

            modelBuilder.Entity("GigMatcher.Data.Entities.InstrumentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("InstrumentTypes","dbo");
                });

            modelBuilder.Entity("GigMatcher.Data.Entities.Musician", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 8, 22, 18, 38, 38, 969, DateTimeKind.Utc).AddTicks(2942));

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Location");

                    b.Property<int?>("MusicianId");

                    b.Property<int>("Rating");

                    b.Property<int>("UserId");

                    b.Property<int>("YearPlaying");

                    b.Property<int>("YearsPlaying");

                    b.Property<int>("YearsProfessionalExperience");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Musicians","dbo");
                });

            modelBuilder.Entity("GigMatcher.Data.Entities.MusicianInstrument", b =>
                {
                    b.Property<int>("MusicianId");

                    b.Property<int>("InstrumentId");

                    b.HasKey("MusicianId", "InstrumentId");

                    b.HasIndex("InstrumentId");

                    b.ToTable("MusicianInstruments","dbo");
                });

            modelBuilder.Entity("GigMatcher.Data.Entities.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("GigId");

                    b.Property<int?>("MusicianId");

                    b.Property<decimal>("Pay");

                    b.Property<int>("PositionStatusId");

                    b.HasKey("Id");

                    b.HasIndex("GigId");

                    b.HasIndex("MusicianId");

                    b.HasIndex("PositionStatusId");

                    b.ToTable("Positions","dbo");
                });

            modelBuilder.Entity("GigMatcher.Data.Entities.PositionInstrument", b =>
                {
                    b.Property<int>("PositionId");

                    b.Property<int>("InstrumentId");

                    b.HasKey("PositionId", "InstrumentId");

                    b.HasIndex("InstrumentId");

                    b.ToTable("PositionInstruments","dbo");
                });

            modelBuilder.Entity("GigMatcher.Data.Entities.PositionStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("PositionStatus","dbo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GigMatcher.Data.Entities.Application", b =>
                {
                    b.HasOne("GigMatcher.Data.Entities.ApplicationStatus", "ApplicationStatus")
                        .WithMany("Applications")
                        .HasForeignKey("ApplicationStatusId")
                        .HasConstraintName("FK_Application_ApplicationStatus_ApplicationStatusId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("GigMatcher.Data.Entities.Musician", "Musician")
                        .WithMany("Applications")
                        .HasForeignKey("MusicianId")
                        .HasConstraintName("FK_Application_Musicians_MusicianId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("GigMatcher.Data.Entities.Position", "Position")
                        .WithMany("Applications")
                        .HasForeignKey("PositionId")
                        .HasConstraintName("FK_Application_Positions_PositionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GigMatcher.Data.Entities.ApplicationUser", b =>
                {
                    b.HasOne("GigMatcher.Data.Entities.Musician", "Musician")
                        .WithOne("User")
                        .HasForeignKey("GigMatcher.Data.Entities.ApplicationUser", "UserId")
                        .HasConstraintName("FK_Musician_ApplicationUsers_UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GigMatcher.Data.Entities.Gig", b =>
                {
                    b.HasOne("GigMatcher.Data.Entities.GigStatus", "GigStatus")
                        .WithMany("Gigs")
                        .HasForeignKey("GigStatusId")
                        .HasConstraintName("FK_Gig_GigStatus_GigStatusId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("GigMatcher.Data.Entities.Musician", "Owner")
                        .WithMany("Gigs")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("GigMatcher.Data.Entities.Instrument", b =>
                {
                    b.HasOne("GigMatcher.Data.Entities.InstrumentType", "InstrumentType")
                        .WithMany("Instruments")
                        .HasForeignKey("InstrumentTypeId")
                        .HasConstraintName("FK_Instrument_InstrumentTypes_InstrumentTypeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("GigMatcher.Data.Entities.MusicianInstrument", b =>
                {
                    b.HasOne("GigMatcher.Data.Entities.Instrument", "Instrument")
                        .WithMany("MusicianInstruments")
                        .HasForeignKey("InstrumentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GigMatcher.Data.Entities.Musician", "Musician")
                        .WithMany("MusicianInstruments")
                        .HasForeignKey("MusicianId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GigMatcher.Data.Entities.Position", b =>
                {
                    b.HasOne("GigMatcher.Data.Entities.Gig", "Gig")
                        .WithMany("Positions")
                        .HasForeignKey("GigId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GigMatcher.Data.Entities.Musician", "Musician")
                        .WithMany("Positions")
                        .HasForeignKey("MusicianId")
                        .HasConstraintName("FK_Position_Musicians_MusicianId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("GigMatcher.Data.Entities.PositionStatus", "PositionStatus")
                        .WithMany("Positions")
                        .HasForeignKey("PositionStatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GigMatcher.Data.Entities.PositionInstrument", b =>
                {
                    b.HasOne("GigMatcher.Data.Entities.Instrument", "Instrument")
                        .WithMany("PositionInstruments")
                        .HasForeignKey("InstrumentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GigMatcher.Data.Entities.Position", "Position")
                        .WithMany("PositionInstruments")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Data.Entities.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("GigMatcher.Data.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("GigMatcher.Data.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Data.Entities.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GigMatcher.Data.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("GigMatcher.Data.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}