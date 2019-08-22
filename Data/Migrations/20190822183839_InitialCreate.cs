using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.EnsureSchema(
                name: "AspIdentity");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationStatus",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GigStatus",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 8, 22, 18, 38, 38, 965, DateTimeKind.Utc).AddTicks(2710))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GigStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstrumentTypes",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstrumentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Musicians",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    YearsPlaying = table.Column<int>(nullable: false),
                    YearsProfessionalExperience = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 8, 22, 18, 38, 38, 969, DateTimeKind.Utc).AddTicks(2942)),
                    MusicianId = table.Column<int>(nullable: true),
                    YearPlaying = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musicians", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PositionStatus",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instruments",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InstrumentTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instrument_InstrumentTypes_InstrumentTypeId",
                        column: x => x.InstrumentTypeId,
                        principalSchema: "dbo",
                        principalTable: "InstrumentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUser",
                schema: "AspIdentity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    MusicianId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musician_ApplicationUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Musicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gigs",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OwnerId = table.Column<int>(nullable: false),
                    GigStatusId = table.Column<int>(nullable: false),
                    NumberOfPositions = table.Column<int>(nullable: false),
                    TotalPay = table.Column<decimal>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    GigStart = table.Column<DateTime>(nullable: false),
                    GigEnd = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gigs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gig_GigStatus_GigStatusId",
                        column: x => x.GigStatusId,
                        principalSchema: "dbo",
                        principalTable: "GigStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Gigs_Musicians_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "dbo",
                        principalTable: "Musicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MusicianInstruments",
                schema: "dbo",
                columns: table => new
                {
                    MusicianId = table.Column<int>(nullable: false),
                    InstrumentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicianInstruments", x => new { x.MusicianId, x.InstrumentId });
                    table.ForeignKey(
                        name: "FK_MusicianInstruments_Instruments_InstrumentId",
                        column: x => x.InstrumentId,
                        principalSchema: "dbo",
                        principalTable: "Instruments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusicianInstruments_Musicians_MusicianId",
                        column: x => x.MusicianId,
                        principalSchema: "dbo",
                        principalTable: "Musicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUser_UserId",
                        column: x => x.UserId,
                        principalSchema: "AspIdentity",
                        principalTable: "AspNetUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUser_UserId",
                        column: x => x.UserId,
                        principalSchema: "AspIdentity",
                        principalTable: "AspNetUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUser_UserId",
                        column: x => x.UserId,
                        principalSchema: "AspIdentity",
                        principalTable: "AspNetUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUser_UserId",
                        column: x => x.UserId,
                        principalSchema: "AspIdentity",
                        principalTable: "AspNetUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PositionStatusId = table.Column<int>(nullable: false),
                    GigId = table.Column<int>(nullable: false),
                    MusicianId = table.Column<int>(nullable: true),
                    Pay = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Positions_Gigs_GigId",
                        column: x => x.GigId,
                        principalSchema: "dbo",
                        principalTable: "Gigs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Position_Musicians_MusicianId",
                        column: x => x.MusicianId,
                        principalSchema: "dbo",
                        principalTable: "Musicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Positions_PositionStatus_PositionStatusId",
                        column: x => x.PositionStatusId,
                        principalSchema: "dbo",
                        principalTable: "PositionStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MusicianId = table.Column<int>(nullable: false),
                    ApplicationStatusId = table.Column<int>(nullable: false),
                    PositionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Application_ApplicationStatus_ApplicationStatusId",
                        column: x => x.ApplicationStatusId,
                        principalSchema: "dbo",
                        principalTable: "ApplicationStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Application_Musicians_MusicianId",
                        column: x => x.MusicianId,
                        principalSchema: "dbo",
                        principalTable: "Musicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Application_Positions_PositionId",
                        column: x => x.PositionId,
                        principalSchema: "dbo",
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PositionInstruments",
                schema: "dbo",
                columns: table => new
                {
                    PositionId = table.Column<int>(nullable: false),
                    InstrumentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionInstruments", x => new { x.PositionId, x.InstrumentId });
                    table.ForeignKey(
                        name: "FK_PositionInstruments_Instruments_InstrumentId",
                        column: x => x.InstrumentId,
                        principalSchema: "dbo",
                        principalTable: "Instruments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PositionInstruments_Positions_PositionId",
                        column: x => x.PositionId,
                        principalSchema: "dbo",
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "AspIdentity",
                table: "AspNetUser",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "AspIdentity",
                table: "AspNetUser",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUser_UserId",
                schema: "AspIdentity",
                table: "AspNetUser",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ApplicationStatusId",
                schema: "dbo",
                table: "Applications",
                column: "ApplicationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_MusicianId",
                schema: "dbo",
                table: "Applications",
                column: "MusicianId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_PositionId",
                schema: "dbo",
                table: "Applications",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Gigs_GigStatusId",
                schema: "dbo",
                table: "Gigs",
                column: "GigStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Gigs_OwnerId",
                schema: "dbo",
                table: "Gigs",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Instruments_InstrumentTypeId",
                schema: "dbo",
                table: "Instruments",
                column: "InstrumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MusicianInstruments_InstrumentId",
                schema: "dbo",
                table: "MusicianInstruments",
                column: "InstrumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Musicians_UserId",
                schema: "dbo",
                table: "Musicians",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PositionInstruments_InstrumentId",
                schema: "dbo",
                table: "PositionInstruments",
                column: "InstrumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_GigId",
                schema: "dbo",
                table: "Positions",
                column: "GigId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_MusicianId",
                schema: "dbo",
                table: "Positions",
                column: "MusicianId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_PositionStatusId",
                schema: "dbo",
                table: "Positions",
                column: "PositionStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Applications",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MusicianInstruments",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PositionInstruments",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUser",
                schema: "AspIdentity");

            migrationBuilder.DropTable(
                name: "ApplicationStatus",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Instruments",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Positions",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "InstrumentTypes",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Gigs",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PositionStatus",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "GigStatus",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Musicians",
                schema: "dbo");
        }
    }
}
